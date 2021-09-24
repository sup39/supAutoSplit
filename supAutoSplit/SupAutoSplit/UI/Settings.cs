using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.UI.Components;
using LiveSplit.UI;
using SupExtension;

namespace LiveSplit.SupAutoSplit.UI {
  public partial class Settings : UserControl {
	public int CaptureDevice = 0; // TODO
	public string WindowName = "supAutoSplit"; // TODO
	public List<TemplateSettings> TemplateSettings { get; set; } = new List<TemplateSettings>();

	public Settings() {
	  InitializeComponent();
	}
	public XmlNode GetSettings(XmlDocument document) {
	  var parent = document.CreateElement("Settings");
	  CreateSettingsNode(document, parent);
	  return parent;
	}
	public int GetSettingsHashCode() {
	  return CreateSettingsNode(null, null);
	}
	public int CreateSettingsNode(XmlDocument document, XmlElement parent) {
	  var hashCode =
		SettingsHelper.CreateSetting(document, parent, "Version", "1.0.0");
	  // profile TODO
	  var profileRoot = document?.CreateElement("Profile", parent);
	  SettingsHelper.CreateSetting(document, profileRoot, "Name", "SMS Any%");
	  // templates
	  var templatesRoot = document?.CreateElement("Templates", profileRoot);
	  foreach (var ts in TemplateSettings) {
		XmlElement templateParent = document?.CreateElement("Template", templatesRoot);
		hashCode ^= ts.CreateSettingsNode(document, templateParent);
	  }
	  // return
	  return hashCode;
	}

	public void SetSettings(XmlNode settings) {
	  if (settings == null) return;
	  // profile
	  var profileRoot = settings["Profile"];
	  if (profileRoot == null) return;
	  // template
	  var templatesRoot = profileRoot["Templates"];
	  if (templatesRoot == null) return;

	  // reset RowStyles
	  var rs = tlpTemplates.RowStyles[0];
	  tlpTemplates.RowStyles.Clear();
	  tlpTemplates.RowStyles.Add(rs);
	  // remove UI
	  foreach (var ts in TemplateSettings) {
		tlpTemplates.Controls.Remove(ts);
	  }
	  tlpTemplates.RowCount = 1;
	  // reinit TemplateSettings[]
	  TemplateSettings.Clear();
	  foreach (var templateParent in templatesRoot.ChildNodes) {
		AddTemplateSettings((XmlElement)templateParent);
	  }
	}

	private void BtnAddTemplate_Click(object sender, EventArgs e) {
	  AddTemplateSettings(null);
	}
	private void AddTemplateSettings(XmlElement settings) {
	  var irow = tlpTemplates.RowCount;
	  tlpTemplates.RowCount = irow + 1;
	  tlpTemplates.RowStyles.Add(new RowStyle(SizeType.AutoSize));
	  var v = new TemplateSettings(settings, o => {
		tlpTemplates.Controls.Remove(o);
		tlpTemplates.RowCount = irow;
		tlpTemplates.RowStyles.RemoveAt(irow);
		TemplateSettings.Remove(o);
	  });
	  // tlpTemplates.RowStyles.Add(new RowStyle(SizeType.Absolute, v.Height));
	  // v.Width = tlpTemplates.Width;
	  tlpTemplates.Controls.Add(v, 0, irow);
	  TemplateSettings.Add(v);
	}
  }
}
