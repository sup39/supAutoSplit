using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveSplit.UI.Components;
using SupExtension;
using LiveSplit.Model;
using LiveSplit.UI;
using System.Xml;
using OpenCvSharp;

namespace LiveSplit.SupAutoSplit.UI {
  using MatchAction = Action<TimerModel>;
  using EnableIfFactory = Func<string, Predicate<LiveSplitState>>;
  using MatchMethodFactory = Func<Mat, Func<Mat, double>>;

  public partial class TemplateSettings : UserControl {
	internal Action<TemplateSettings> RemoveHandler;

	#region Parameters
	public string TemplateName { get; set; }
	public string TemplateTitle => $"Template: {TemplateName}";

	public int EnableIfISel { get; set; } = 0;
	public string EnableIfArg { get; set; }
	private ListItem<EnableIfFactory> EnableIfSel => MatchTemplate.EnableIfFactories[EnableIfISel];
	private bool IsActionStart => matchActionISel == 0; // start
	public Predicate<LiveSplitState> EnableIf => IsActionStart ? (state => state.CurrentSplitIndex == -1): EnableIfSel.value(EnableIfArg);

	private int matchActionISel;
	public int MatchActionISel {
	  get => matchActionISel;
	  set {
		matchActionISel = value;
		// Start => Disable Arg
		cbbEnableIf.Enabled = ttbEnableIfArg.Enabled = !IsActionStart;
	  }
	}
	private ListItem<MatchAction> MatchActionSel => MatchTemplate.MatchActions[MatchActionISel];
	public MatchAction MatchAction => MatchActionSel.value;

	public int ActionTimingISel { get; set; } = 1;
	private ListItem<bool> ActionTimingSel => MatchTemplate.ActionTimings[ActionTimingISel];
	public bool IsActionOnPosedge => ActionTimingSel.value;

	private string _imagePath;
	public string ImagePath {
	  get => _imagePath;
	  set {
		try {
		  if (value != "") {
			var img = Image.FromFile(value);
			var h0 = btnImage.Height;
			var h = Math.Max(11, Math.Min(66, img.Height));
			btnImage.Height = h;
			btnImage.Width = h * img.Width / img.Height;
			btnImage.BackgroundImage = img;
			// adjust this.Height
			Height += h - h0;
		  }
		  _imagePath = value;
		} catch {
		  _imagePath = "";
		}
	  }
	}

	private int ImageOffsetX;
	private int ImageOffsetY;
	public string ImageOffsetXStr {
	  get => ImageOffsetX.ToString();
	  set => int.TryParse(value, out ImageOffsetX);
	}
	public string ImageOffsetYStr {
	  get => ImageOffsetY.ToString();
	  set => int.TryParse(value, out ImageOffsetY);
	}
	public OpenCvSharp.Point ImageOffset => new OpenCvSharp.Point(ImageOffsetX, ImageOffsetY);

	public int MatchMethodISel { get; set; }
	private ListItem<MatchMethodFactory> MatchMethodSel => MatchTemplate.MatchMethodFactories[MatchMethodISel];
	public MatchMethodFactory MatchMethodFactory => MatchMethodSel.value;

	private double matchThreshold;
	public double MatchThreshold => matchThreshold;
	public string MatchThresholdStr {
	  get => MatchThreshold.ToString();
	  set => double.TryParse(value, out matchThreshold);
	}

	private double matchThresholdNeg;
	public double MatchThresholdNeg => matchThresholdNeg;
	public string MatchThresholdNegStr {
	  get => MatchThresholdNeg.ToString();
	  set => double.TryParse(value, out matchThresholdNeg);
	}
	#endregion

	public TemplateSettings(XmlElement settings, Action<TemplateSettings> removeHandler) {
	  RemoveHandler = removeHandler;

	  InitializeComponent();
	  SetSettings(settings);

	  cbbEnableIf.DataSource = MatchTemplate.EnableIfItems;
	  cbbEnableIf.DataBindings.Add("SelectedIndex", this, "EnableIfISel", false, DataSourceUpdateMode.OnPropertyChanged);
	  cbbAction.DataSource = MatchTemplate.MatchActionItems;
	  cbbAction.DataBindings.Add("SelectedIndex", this, "MatchActionISel", false, DataSourceUpdateMode.OnPropertyChanged);
	  cbbActionTiming.DataSource = MatchTemplate.ActionTimingItems;
	  cbbActionTiming.DataBindings.Add("SelectedIndex", this, "ActionTimingISel", false, DataSourceUpdateMode.OnPropertyChanged);
	  cbbMethod.DataSource = MatchTemplate.MatchMethodItems;
	  cbbMethod.DataBindings.Add("SelectedIndex", this, "MatchMethodISel", false, DataSourceUpdateMode.OnPropertyChanged);
	}

	private void BtnTemplate_Click(object sender, EventArgs e) {
	  if (ofdTemplate.ShowDialog() == DialogResult.OK)
		ImagePath = ofdTemplate.FileName;
	}
	private void BtnRemove_Click(object sender, EventArgs e) {
	  RemoveHandler(this);
	}

	internal int CreateSettingsNode(XmlDocument document, XmlElement parent) {
	  var hashCode =
		SettingsHelper.CreateSetting(document, parent, "Name", TemplateName) ^
		SettingsHelper.CreateSetting(document, parent, "EnableIf", EnableIfSel.key) ^
		SettingsHelper.CreateSetting(document, parent, "EnableIfArg", EnableIfArg) ^
		SettingsHelper.CreateSetting(document, parent, "Action", MatchActionSel.key) ^
		SettingsHelper.CreateSetting(document, parent, "ActionOn", ActionTimingSel.key) ^
		SettingsHelper.CreateSetting(document, parent, "Image", ImagePath) ^
		SettingsHelper.CreateSetting(document, parent, "OffsetX", ImageOffsetX) ^
		SettingsHelper.CreateSetting(document, parent, "OffsetY", ImageOffsetY) ^
		SettingsHelper.CreateSetting(document, parent, "Method", MatchMethodSel.key) ^
		SettingsHelper.CreateSetting(document, parent, "Threshold", MatchThreshold);
		SettingsHelper.CreateSetting(document, parent, "ThresholdNeg", MatchThresholdNeg);
	  return hashCode;
	}
	private void SetSettings(XmlElement settings) {
	  TemplateName = SettingsHelper.ParseString(settings?["Name"], "");
	  EnableIfISel = SupSettingsHelper.ParseListISel(settings?["EnableIf"], MatchTemplate.EnableIfFactories, 0);
	  EnableIfArg = SettingsHelper.ParseString(settings?["EnableIfArg"], "");
	  MatchActionISel = SupSettingsHelper.ParseListISel(settings?["Action"], MatchTemplate.MatchActions, 1);
	  ActionTimingISel = SupSettingsHelper.ParseListISel(settings?["ActionOn"], MatchTemplate.ActionTimings, 0);
	  ImagePath = SettingsHelper.ParseString(settings?["Image"], "");
	  ImageOffsetX = SettingsHelper.ParseInt(settings?["OffsetX"], 0);
	  ImageOffsetY = SettingsHelper.ParseInt(settings?["OffsetY"], 0);
	  MatchMethodISel = SupSettingsHelper.ParseListISel(settings?["Method"], MatchTemplate.MatchMethodFactories, 0);
	  matchThreshold = SettingsHelper.ParseDouble(settings?["Threshold"], 0);
	  matchThresholdNeg = SettingsHelper.ParseDouble(settings?["ThresholdNeg"], 0);
	}
  }
}

namespace SupExtension {
  public struct ListItem<V> {
	public string key;
	public string text;
	public V value;

	public static implicit operator ListItem<V>((string, V) arg) =>
	  new ListItem<V>() { key = arg.Item1, text = arg.Item1, value = arg.Item2 };
	public static implicit operator ListItem<V>((string, string, V) arg) =>
	  new ListItem<V>() { key = arg.Item1, text = arg.Item2, value = arg.Item3 };
  }
  public static class SupArray {
	public static int FindIndex<T>(this T[] self, Predicate<T> match) =>
	  Array.FindIndex(self, match);
  }
  static class SupSettingsHelper {
	internal static int ParseListISel<T>(XmlElement element, ListItem<T>[] items, int defaultValue=-1) {
	  var key = SettingsHelper.ParseString(element);
	  if (key == null) return defaultValue;
	  var index = Array.FindIndex(items, o => o.key == key);
	  return index == -1 ? defaultValue : index;
	}
  }
}
