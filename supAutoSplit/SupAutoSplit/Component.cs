using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using OpenCvSharp;

namespace LiveSplit.SupAutoSplit {
  public sealed class Component : LogicComponent {
    public override string ComponentName => "supAutoSplit";
    private UI.Settings Settings { get; set; }
    private LiveSplitState State { get; set; }
    private TimerModel Model { get; }

    public Component(LiveSplitState state) {
      // TODO
      Environment.SetEnvironmentVariable("OPENCV_VIDEOIO_MSMF_ENABLE_HW_TRANSFORMS", "0", EnvironmentVariableTarget.User);
      Settings = new UI.Settings();
      State = state;
      Model = new TimerModel {
        CurrentState = state
      };

      ContextMenuControls = new Dictionary<string, Action> {
        { "Start supAutoSplit", Start }
      };
    }

    private Thread captureThread;
    private List<MatchHandler> handlersAll;
    private List<MatchHandler> handlers;
    private volatile bool handlerReady = false;
    private void UpdateHandlers(object sender, EventArgs e) {
      handlers = handlersAll.Where(h => h.Reset(State)).ToList();
      handlerReady = true;
    }
    private void UpdateHandlers_Reset(object sender, TimerPhase e) => UpdateHandlers(null, null);
    private void Start() {
      ContextMenuControls.Clear();
      ContextMenuControls.Add("Reload supAutoSplit", Reload);
      ContextMenuControls.Add("Stop supAutoSplit", Stop);

      Reload();
      State.OnStart += UpdateHandlers;
      State.OnSplit += UpdateHandlers;
      State.OnSkipSplit += UpdateHandlers;
      State.OnUndoSplit += UpdateHandlers;
      State.OnPause += UpdateHandlers;
      State.OnResume += UpdateHandlers;
      State.OnReset += UpdateHandlers_Reset;

      captureThread = new Thread(() => {
        using (var capture = new VideoCapture(Settings.CaptureDevice))
        using (var window = new Window(Settings.WindowName))
        using (Mat frame = new Mat()) {
          try {
            // Stopwatch sw = new Stopwatch();
            // Stopwatch sw1 = new Stopwatch();
            // Stopwatch sw2 = new Stopwatch();
            // sw.Start();
            while (capture.Read(frame)) {
              // sw1.Restart();
              if (handlerReady) {
                foreach (var handler in handlers) {
                  if (handler.Match(frame)) {
                    handlerReady = false;
                    handler.Action(Model);
                    break;
                  }
                }
              }
              // sw1.Stop();
              // sw2.Restart();
              window.ShowImage(frame);
              // sw2.Stop();
              // sw.Stop();
              // Debug.WriteLine($"{sw1.ElapsedMilliseconds:#0} ({sw1.ElapsedTicks}) {sw2.ElapsedMilliseconds:#0} ({sw2.ElapsedTicks}) {sw.ElapsedMilliseconds:#0}");
              Cv2.WaitKey(1);
              // sw.Restart();
            }
          } catch (ThreadInterruptedException) { }
        }
      });
      captureThread.Start();
    }
    private void Reload() {
      handlersAll = Settings.TemplateSettings.Select(o => new MatchHandler(o)).ToList();
      UpdateHandlers(null, null);
    }
    private void Stop() {
      captureThread?.Abort();
      captureThread = null;

      State.OnStart -= UpdateHandlers;
      State.OnSplit -= UpdateHandlers;
      State.OnSkipSplit -= UpdateHandlers;
      State.OnUndoSplit -= UpdateHandlers;
      State.OnPause -= UpdateHandlers;
      State.OnResume -= UpdateHandlers;
      State.OnReset -= UpdateHandlers_Reset;

      ContextMenuControls.Clear();
      ContextMenuControls.Add("Start supAutoSplit", Start);
    }

    public override void Dispose() {
      captureThread?.Abort();
    }

    public override XmlNode GetSettings(XmlDocument document) => Settings.GetSettings(document);
    public override Control GetSettingsControl(LayoutMode mode) => Settings;
    public int GetSettingsHashCode() => Settings.GetSettingsHashCode();
    public override void SetSettings(XmlNode settings) => Settings.SetSettings(settings);
    public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) { }
  }
}

namespace LiveSplit.SupAutoSplit {
  class MatchHandler {
    private readonly Predicate<LiveSplitState> fEnabled;
    private readonly Rect imageRange;
    private readonly Func<Mat, double> fSim;
    private readonly Predicate<double> fMatch;
    private readonly Predicate<double> fMatchNeg;
    public Action<TimerModel> Action { get; }
    private int ready = 0;
    private readonly int maxReady;
    private int count = 0;
    private readonly int maxCount;

    public MatchHandler(UI.TemplateSettings settings) {
      fEnabled = settings.EnableIf;
      using (var timg = Cv2.ImRead(settings.ImagePath, ImreadModes.Unchanged)) {
        imageRange = new Rect(settings.ImageOffset, timg.Size());
        fSim = settings.MatchMethodFactory(timg);
      }
      var threshold = settings.MatchThreshold;
      var thresholdNeg = settings.MatchThresholdNeg;
      if (thresholdNeg <= 0) thresholdNeg = threshold;
      maxReady = settings.IsActionOnPosedge ? 1 : 2;
      fMatch = sim => sim <= threshold;
      fMatchNeg = sim => sim >= thresholdNeg;
      maxCount = settings.MatchCount;
      Action = settings.MatchAction;
    }

    public bool Reset(LiveSplitState state) {
      ready = count = 0;
      return fEnabled(state);
    }
    public bool Match(Mat frame) {
      // Stopwatch sw = new Stopwatch();
      var fimg = frame[imageRange];
      var sim = fSim(fimg);
      // sw.Stop();
      // Debug.WriteLine($"#sim {sim} | {sw.ElapsedMilliseconds} ({sw.ElapsedTicks})");
      Debug.WriteLine($"#[{count}/{maxCount}] {sim} {ready}");
      if (((ready & 1) == 0 ? fMatchNeg : fMatch)(sim)) {
        if (++ready > maxReady) {
          ready = 0;
          return ++count >= maxCount;
        }
      }
      return false;
    }
  }
}
