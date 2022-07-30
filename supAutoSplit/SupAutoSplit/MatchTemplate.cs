using LiveSplit.Model;
using OpenCvSharp;
using SupExtension;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LiveSplit.SupAutoSplit {
  using MatchAction = Action<TimerModel>;
  using EnableIfFactory = Func<string, Predicate<LiveSplitState>>;
  using MatchMethodFactory = Func<Mat, Func<Mat, double>>;

  class MatchTemplate {
    static public readonly ListItem<EnableIfFactory>[] EnableIfFactories = {
      ("Index", "Split Index in range", arg => {
        var testers = arg.Split(',').Select(s => {
          string[] ns = s.Split(':');
          if (ns.Length == 0 || ns.Length > 3) return null;
          int start = 0, end = int.MaxValue, step = 1;
          if (ns[0] != "" && !int.TryParse(ns[0], out start)) return null;
          if (ns.Length == 1) return start < 0 ?
          (Func<int, int, bool>)((idx, len) => idx == len + start) :
          ((idx, len) => idx==start);
          if (ns[1] != "" && !int.TryParse(ns[1], out end)) return null;
          if (ns.Length == 3 && ns[2] != "" && (!int.TryParse(ns[2], out step) || step==0)) return null;
          return (idx, len) => {
          int start1 = start<0 ? start+len : start;
          int end1 = end<0 ? end+len : end;
          return start1 <= idx && idx < end1 && (idx-start1)%step == 0;
          };
        }).Where(s => s!=null).ToList();
        return state => testers.Any(f => f(state.CurrentSplitIndex, state.Run.Count));
      }),
      ("Name", "Split Name matches", arg => {
        try {
          var re = new Regex(arg);
          return state => state.CurrentSplit == null ? false : re.IsMatch(state.CurrentSplit.Name);
        } catch {
          // not regex
          return state => state.CurrentSplit == null ? false : state.CurrentSplit.Name == arg;
        }
      }),
    };
    static public readonly string[] EnableIfItems = EnableIfFactories.Select(e => e.text).ToArray();
    static public readonly ListItem<MatchAction>[] MatchActions = {
      ("Start", "Start", model => model.Start()),
      ("Split", "Split", model => model.Split()),
      ("Skip", "Skip Split", model => model.SkipSplit()),
      ("Undo", "Undo Split", model => model.UndoSplit()),
      ("Reset", "Reset", model => model.Reset()),
      ("Pause", "Pause", model => model.Pause()),
    };
    static public readonly string[] MatchActionItems = MatchActions.Select(e => e.text).ToArray();

    static public readonly ListItem<bool>[] ActionTimings = {
      ("Posedge", "Posedge: First Match after unmatch", true),
      ("Negedge", "Negedge: First Unmatch after match", false),
    };
    static public readonly string[] ActionTimingItems = ActionTimings.Select(e => e.text).ToArray();

    static public readonly ListItem<MatchMethodFactory>[] MatchMethodFactories = {
      ("COSINE", "1 - Cosine Similarity", timg => {
        Mat[] bchs = timg.Split();
        Mat mask = bchs[3];
        Array.Resize(ref bchs, 3);
        Mat[] bimg = bchs.Select(m => (Mat)m.BitwiseAnd(mask)).ToArray();
        var b1 = Math.Sqrt(bimg.Select(m => m.Norm(NormTypes.L2SQR, mask)).Sum());
        return frame => {
          Mat[] fimg = frame.Split();
          var f1 = Math.Sqrt(fimg.Select(m => m.Norm(NormTypes.L2SQR, mask)).Sum());
          var fb = fimg.Zip(bimg, (mf, mb) => mf.Dot(mb)).Sum();
          fimg.ForEach(m => m.Release());
          return 1-fb/f1/b1;
        };
      }),
      ("SQDIFF_NORM", "Normalized Squared Difference", timg => {
        Mat[] bimg = timg.Split();
        Mat mask = bimg[3];
        Array.Resize(ref bimg, 3);
        var b1 = Math.Sqrt(bimg.Select(m => m.Norm(NormTypes.L2SQR, mask)).Sum());
        return frame => {
          Mat[] fimg = frame.Split();
          var f1 = Math.Sqrt(fimg.Select(m => m.Norm(NormTypes.L2SQR, mask)).Sum());
          var d2 = fimg.Zip(bimg, (mf, mb) => Cv2.Norm(mf, mb, NormTypes.L2SQR, mask)).Sum();
          fimg.ForEach(m => m.Release());
          return d2/f1/b1;
        };
      }),
      ("RMSE", "Root Mean Squared Error", timg => {
        Mat[] bimgs = timg.Split();
        Mat bimg = new Mat();
        Mat mask = bimgs[3];
        Array.Resize(ref bimgs, 3);
        Cv2.Merge(bimgs, bimg);
        var div = Math.Sqrt(3*bimg.Total())*255.0;
        return fimg => Math.Sqrt(Cv2.Norm(fimg, bimg, NormTypes.L2SQR, mask))/div;
      }),
      ("V128_BINARY", "V128 Binary Classification: MAX(R,G,B)<128 or not", timg => {
        Mat bimg;
        {
          Mat[] chs = timg.Split();
          if (chs.Length == 3) {
          using (Mat v = RGB2V(chs))
            bimg = v.LessThan(128);
          } else {
          bimg = chs[0].LessThan(128);
          }
          chs.ForEach(m => m.Release());
        }
        return frame => {
          Mat[] chs = frame.Split();
          using (Mat v = RGB2V(chs)) {
          chs.ForEach(ch => ch.Release());
          using (Mat fimg = v.LessThan(128))
            return Cv2.Mean(fimg.NotEquals(bimg)).ToDouble()/255.0;
          }
        };
      }),
    };
    static public readonly string[] MatchMethodItems = MatchMethodFactories.Select(e => e.text).ToArray();

    static public Mat RGB2V(Mat[] chs) {
      Mat m = new Mat();
      Cv2.Max(chs[0], chs[1], m);
      Cv2.Max(m, chs[2], m);
      return m;
    }
  }
}
