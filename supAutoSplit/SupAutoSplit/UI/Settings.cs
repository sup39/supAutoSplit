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
      tlpTemplates.RowStyles.Insert(0, new RowStyle(SizeType.AutoSize));
      var v = new TemplateSettings(settings, o => {
        tlpTemplates.Controls.Remove(o);
        var irowD = tlpTemplates.RowCount - 1;
        tlpTemplates.RowCount = irowD;
        tlpTemplates.RowStyles.RemoveAt(0); // remove 1 TemplateSettings RowStyle
        TemplateSettings.Remove(o);
        // move button to the last row
        tlpTemplates.Controls.Remove(btnAddTemplate);
        tlpTemplates.Controls.Add(btnAddTemplate, 0, irowD - 1);
      });
      // move button to the last row
      tlpTemplates.Controls.Remove(btnAddTemplate);
      tlpTemplates.Controls.Add(btnAddTemplate, 0, irow);
      // add new template view
      tlpTemplates.Controls.Add(v, 0, irow - 1);
      TemplateSettings.Add(v);
      // TODO scroll to bottom
    }
  }
}
