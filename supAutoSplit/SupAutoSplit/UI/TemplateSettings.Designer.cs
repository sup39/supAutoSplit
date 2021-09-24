namespace LiveSplit.SupAutoSplit.UI {
  partial class TemplateSettings {
	/// <summary> 
	/// 必要なデザイナー変数です。
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary> 
	/// 使用中のリソースをすべてクリーンアップします。
	/// </summary>
	/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
	protected override void Dispose(bool disposing) {
	  if (disposing && (components != null)) {
		components.Dispose();
	  }
	  base.Dispose(disposing);
	}

	#region コンポーネント デザイナーで生成されたコード

	/// <summary> 
	/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
	/// コード エディターで変更しないでください。
	/// </summary>
	private void InitializeComponent() {
	  this.ofdTemplate = new System.Windows.Forms.OpenFileDialog();
	  this.gpbRoot = new System.Windows.Forms.GroupBox();
	  this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
	  this.ttbThresholdNeg = new System.Windows.Forms.TextBox();
	  this.cbbEnableIf = new System.Windows.Forms.ComboBox();
	  this.cbbActionTiming = new System.Windows.Forms.ComboBox();
	  this.label1 = new System.Windows.Forms.Label();
	  this.ttbThreshold = new System.Windows.Forms.TextBox();
	  this.label10 = new System.Windows.Forms.Label();
	  this.label7 = new System.Windows.Forms.Label();
	  this.label5 = new System.Windows.Forms.Label();
	  this.label4 = new System.Windows.Forms.Label();
	  this.label2 = new System.Windows.Forms.Label();
	  this.cbbAction = new System.Windows.Forms.ComboBox();
	  this.ttbName = new System.Windows.Forms.TextBox();
	  this.label9 = new System.Windows.Forms.Label();
	  this.cbbMethod = new System.Windows.Forms.ComboBox();
	  this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
	  this.label12 = new System.Windows.Forms.Label();
	  this.ttbOffsetX = new System.Windows.Forms.TextBox();
	  this.label11 = new System.Windows.Forms.Label();
	  this.ttbOffsetY = new System.Windows.Forms.TextBox();
	  this.label13 = new System.Windows.Forms.Label();
	  this.btnImage = new System.Windows.Forms.Button();
	  this.ttbEnableIfArg = new System.Windows.Forms.TextBox();
	  this.btnRemove = new System.Windows.Forms.Button();
	  this.label3 = new System.Windows.Forms.Label();
	  this.label6 = new System.Windows.Forms.Label();
	  this.gpbRoot.SuspendLayout();
	  this.tableLayoutPanel3.SuspendLayout();
	  this.flowLayoutPanel3.SuspendLayout();
	  this.SuspendLayout();
	  // 
	  // ofdTemplate
	  // 
	  this.ofdTemplate.Filter = "Image Files|*.bmp;*.pbm;*.pgm;*.ppm;*.sr;*.ras;*.jpeg;*.jpg;*.jpe;*.jp2;*.tiff;*." +
    "tif;*.png";
	  // 
	  // gpbRoot
	  // 
	  this.gpbRoot.AutoSize = true;
	  this.gpbRoot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
	  this.gpbRoot.Controls.Add(this.tableLayoutPanel3);
	  this.gpbRoot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "TemplateTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
	  this.gpbRoot.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.gpbRoot.Location = new System.Drawing.Point(0, 0);
	  this.gpbRoot.Name = "gpbRoot";
	  this.gpbRoot.Size = new System.Drawing.Size(434, 314);
	  this.gpbRoot.TabIndex = 16;
	  this.gpbRoot.TabStop = false;
	  this.gpbRoot.Text = "Template: ";
	  // 
	  // tableLayoutPanel3
	  // 
	  this.tableLayoutPanel3.ColumnCount = 3;
	  this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
	  this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
	  this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
	  this.tableLayoutPanel3.Controls.Add(this.ttbThresholdNeg, 1, 8);
	  this.tableLayoutPanel3.Controls.Add(this.cbbEnableIf, 1, 1);
	  this.tableLayoutPanel3.Controls.Add(this.cbbActionTiming, 1, 3);
	  this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
	  this.tableLayoutPanel3.Controls.Add(this.ttbThreshold, 1, 7);
	  this.tableLayoutPanel3.Controls.Add(this.label10, 0, 7);
	  this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
	  this.tableLayoutPanel3.Controls.Add(this.label5, 0, 5);
	  this.tableLayoutPanel3.Controls.Add(this.label4, 0, 4);
	  this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
	  this.tableLayoutPanel3.Controls.Add(this.cbbAction, 1, 2);
	  this.tableLayoutPanel3.Controls.Add(this.ttbName, 1, 0);
	  this.tableLayoutPanel3.Controls.Add(this.label9, 0, 6);
	  this.tableLayoutPanel3.Controls.Add(this.cbbMethod, 1, 6);
	  this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 1, 5);
	  this.tableLayoutPanel3.Controls.Add(this.btnImage, 1, 4);
	  this.tableLayoutPanel3.Controls.Add(this.ttbEnableIfArg, 2, 1);
	  this.tableLayoutPanel3.Controls.Add(this.btnRemove, 2, 9);
	  this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
	  this.tableLayoutPanel3.Controls.Add(this.label6, 0, 8);
	  this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
	  this.tableLayoutPanel3.Name = "tableLayoutPanel3";
	  this.tableLayoutPanel3.RowCount = 10;
	  this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tableLayoutPanel3.Size = new System.Drawing.Size(428, 293);
	  this.tableLayoutPanel3.TabIndex = 2;
	  // 
	  // ttbThresholdNeg
	  // 
	  this.tableLayoutPanel3.SetColumnSpan(this.ttbThresholdNeg, 2);
	  this.ttbThresholdNeg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "MatchThresholdNegStr", true));
	  this.ttbThresholdNeg.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.ttbThresholdNeg.Location = new System.Drawing.Point(97, 239);
	  this.ttbThresholdNeg.Name = "ttbThresholdNeg";
	  this.ttbThresholdNeg.Size = new System.Drawing.Size(328, 22);
	  this.ttbThresholdNeg.TabIndex = 28;
	  // 
	  // cbbEnableIf
	  // 
	  this.cbbEnableIf.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.cbbEnableIf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
	  this.cbbEnableIf.FormattingEnabled = true;
	  this.cbbEnableIf.Location = new System.Drawing.Point(97, 31);
	  this.cbbEnableIf.Name = "cbbEnableIf";
	  this.cbbEnableIf.Size = new System.Drawing.Size(120, 20);
	  this.cbbEnableIf.TabIndex = 26;
	  // 
	  // cbbActionTiming
	  // 
	  this.tableLayoutPanel3.SetColumnSpan(this.cbbActionTiming, 2);
	  this.cbbActionTiming.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.cbbActionTiming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
	  this.cbbActionTiming.FormattingEnabled = true;
	  this.cbbActionTiming.Location = new System.Drawing.Point(97, 85);
	  this.cbbActionTiming.Name = "cbbActionTiming";
	  this.cbbActionTiming.Size = new System.Drawing.Size(328, 20);
	  this.cbbActionTiming.TabIndex = 25;
	  // 
	  // label1
	  // 
	  this.label1.AutoSize = true;
	  this.label1.Location = new System.Drawing.Point(3, 59);
	  this.label1.Margin = new System.Windows.Forms.Padding(3);
	  this.label1.Name = "label1";
	  this.label1.Padding = new System.Windows.Forms.Padding(3);
	  this.label1.Size = new System.Drawing.Size(45, 18);
	  this.label1.TabIndex = 22;
	  this.label1.Text = "Action:";
	  // 
	  // ttbThreshold
	  // 
	  this.tableLayoutPanel3.SetColumnSpan(this.ttbThreshold, 2);
	  this.ttbThreshold.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "MatchThresholdStr", true));
	  this.ttbThreshold.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.ttbThreshold.Location = new System.Drawing.Point(97, 211);
	  this.ttbThreshold.Name = "ttbThreshold";
	  this.ttbThreshold.Size = new System.Drawing.Size(328, 22);
	  this.ttbThreshold.TabIndex = 8;
	  // 
	  // label10
	  // 
	  this.label10.AutoSize = true;
	  this.label10.Location = new System.Drawing.Point(3, 211);
	  this.label10.Margin = new System.Windows.Forms.Padding(3);
	  this.label10.Name = "label10";
	  this.label10.Padding = new System.Windows.Forms.Padding(3);
	  this.label10.Size = new System.Drawing.Size(87, 18);
	  this.label10.TabIndex = 17;
	  this.label10.Text = "Max Difference:";
	  // 
	  // label7
	  // 
	  this.label7.AutoSize = true;
	  this.label7.Location = new System.Drawing.Point(3, 3);
	  this.label7.Margin = new System.Windows.Forms.Padding(3);
	  this.label7.Name = "label7";
	  this.label7.Padding = new System.Windows.Forms.Padding(3);
	  this.label7.Size = new System.Drawing.Size(41, 18);
	  this.label7.TabIndex = 14;
	  this.label7.Text = "Name:";
	  // 
	  // label5
	  // 
	  this.label5.AutoSize = true;
	  this.label5.Location = new System.Drawing.Point(3, 157);
	  this.label5.Margin = new System.Windows.Forms.Padding(3);
	  this.label5.Name = "label5";
	  this.label5.Padding = new System.Windows.Forms.Padding(3);
	  this.label5.Size = new System.Drawing.Size(88, 18);
	  this.label5.TabIndex = 6;
	  this.label5.Text = "Template Offset:";
	  // 
	  // label4
	  // 
	  this.label4.AutoSize = true;
	  this.label4.Location = new System.Drawing.Point(3, 111);
	  this.label4.Margin = new System.Windows.Forms.Padding(3);
	  this.label4.Name = "label4";
	  this.label4.Padding = new System.Windows.Forms.Padding(3);
	  this.label4.Size = new System.Drawing.Size(57, 18);
	  this.label4.TabIndex = 5;
	  this.label4.Text = "Template:";
	  // 
	  // label2
	  // 
	  this.label2.AutoSize = true;
	  this.label2.Location = new System.Drawing.Point(3, 31);
	  this.label2.Margin = new System.Windows.Forms.Padding(3);
	  this.label2.Name = "label2";
	  this.label2.Padding = new System.Windows.Forms.Padding(3);
	  this.label2.Size = new System.Drawing.Size(57, 18);
	  this.label2.TabIndex = 4;
	  this.label2.Text = "Enable If:";
	  // 
	  // cbbAction
	  // 
	  this.tableLayoutPanel3.SetColumnSpan(this.cbbAction, 2);
	  this.cbbAction.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.cbbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
	  this.cbbAction.FormattingEnabled = true;
	  this.cbbAction.Location = new System.Drawing.Point(97, 59);
	  this.cbbAction.Name = "cbbAction";
	  this.cbbAction.Size = new System.Drawing.Size(328, 20);
	  this.cbbAction.TabIndex = 3;
	  // 
	  // ttbName
	  // 
	  this.tableLayoutPanel3.SetColumnSpan(this.ttbName, 2);
	  this.ttbName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "TemplateName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
	  this.ttbName.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.ttbName.Location = new System.Drawing.Point(97, 3);
	  this.ttbName.Name = "ttbName";
	  this.ttbName.Size = new System.Drawing.Size(328, 22);
	  this.ttbName.TabIndex = 1;
	  // 
	  // label9
	  // 
	  this.label9.AutoSize = true;
	  this.label9.Location = new System.Drawing.Point(3, 185);
	  this.label9.Margin = new System.Windows.Forms.Padding(3);
	  this.label9.Name = "label9";
	  this.label9.Padding = new System.Windows.Forms.Padding(3);
	  this.label9.Size = new System.Drawing.Size(82, 18);
	  this.label9.TabIndex = 16;
	  this.label9.Text = "Match Method:";
	  // 
	  // cbbMethod
	  // 
	  this.tableLayoutPanel3.SetColumnSpan(this.cbbMethod, 2);
	  this.cbbMethod.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.cbbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
	  this.cbbMethod.FormattingEnabled = true;
	  this.cbbMethod.Location = new System.Drawing.Point(97, 185);
	  this.cbbMethod.Name = "cbbMethod";
	  this.cbbMethod.Size = new System.Drawing.Size(328, 20);
	  this.cbbMethod.TabIndex = 7;
	  // 
	  // flowLayoutPanel3
	  // 
	  this.flowLayoutPanel3.AutoSize = true;
	  this.tableLayoutPanel3.SetColumnSpan(this.flowLayoutPanel3, 2);
	  this.flowLayoutPanel3.Controls.Add(this.label12);
	  this.flowLayoutPanel3.Controls.Add(this.ttbOffsetX);
	  this.flowLayoutPanel3.Controls.Add(this.label11);
	  this.flowLayoutPanel3.Controls.Add(this.ttbOffsetY);
	  this.flowLayoutPanel3.Controls.Add(this.label13);
	  this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.flowLayoutPanel3.Location = new System.Drawing.Point(94, 154);
	  this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
	  this.flowLayoutPanel3.Name = "flowLayoutPanel3";
	  this.flowLayoutPanel3.Size = new System.Drawing.Size(334, 28);
	  this.flowLayoutPanel3.TabIndex = 18;
	  // 
	  // label12
	  // 
	  this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
	  this.label12.AutoSize = true;
	  this.label12.Location = new System.Drawing.Point(3, 8);
	  this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
	  this.label12.Name = "label12";
	  this.label12.Size = new System.Drawing.Size(9, 12);
	  this.label12.TabIndex = 19;
	  this.label12.Text = "(";
	  // 
	  // ttbOffsetX
	  // 
	  this.ttbOffsetX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "ImageOffsetXStr", true));
	  this.ttbOffsetX.Location = new System.Drawing.Point(15, 3);
	  this.ttbOffsetX.Name = "ttbOffsetX";
	  this.ttbOffsetX.Size = new System.Drawing.Size(48, 22);
	  this.ttbOffsetX.TabIndex = 5;
	  // 
	  // label11
	  // 
	  this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
	  this.label11.AutoSize = true;
	  this.label11.Location = new System.Drawing.Point(66, 13);
	  this.label11.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
	  this.label11.Name = "label11";
	  this.label11.Size = new System.Drawing.Size(11, 12);
	  this.label11.TabIndex = 17;
	  this.label11.Text = ", ";
	  // 
	  // ttbOffsetY
	  // 
	  this.ttbOffsetY.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "ImageOffsetYStr", true));
	  this.ttbOffsetY.Location = new System.Drawing.Point(80, 3);
	  this.ttbOffsetY.Name = "ttbOffsetY";
	  this.ttbOffsetY.Size = new System.Drawing.Size(48, 22);
	  this.ttbOffsetY.TabIndex = 6;
	  // 
	  // label13
	  // 
	  this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
	  this.label13.AutoSize = true;
	  this.label13.Location = new System.Drawing.Point(131, 8);
	  this.label13.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
	  this.label13.Name = "label13";
	  this.label13.Size = new System.Drawing.Size(9, 12);
	  this.label13.TabIndex = 20;
	  this.label13.Text = ")";
	  // 
	  // btnImage
	  // 
	  this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
	  this.tableLayoutPanel3.SetColumnSpan(this.btnImage, 2);
	  this.btnImage.Location = new System.Drawing.Point(97, 111);
	  this.btnImage.Name = "btnImage";
	  this.btnImage.Size = new System.Drawing.Size(40, 40);
	  this.btnImage.TabIndex = 4;
	  this.btnImage.UseVisualStyleBackColor = true;
	  this.btnImage.Click += new System.EventHandler(this.BtnTemplate_Click);
	  // 
	  // ttbEnableIfArg
	  // 
	  this.ttbEnableIfArg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this, "EnableIfArg", true));
	  this.ttbEnableIfArg.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.ttbEnableIfArg.Location = new System.Drawing.Point(223, 31);
	  this.ttbEnableIfArg.Name = "ttbEnableIfArg";
	  this.ttbEnableIfArg.Size = new System.Drawing.Size(202, 22);
	  this.ttbEnableIfArg.TabIndex = 2;
	  // 
	  // btnRemove
	  // 
	  this.btnRemove.AutoSize = true;
	  this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
	  this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
	  this.btnRemove.Location = new System.Drawing.Point(325, 267);
	  this.btnRemove.Name = "btnRemove";
	  this.btnRemove.Size = new System.Drawing.Size(100, 23);
	  this.btnRemove.TabIndex = 23;
	  this.btnRemove.TabStop = false;
	  this.btnRemove.Text = "Remove Template";
	  this.btnRemove.UseVisualStyleBackColor = true;
	  this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
	  // 
	  // label3
	  // 
	  this.label3.AutoSize = true;
	  this.label3.Location = new System.Drawing.Point(3, 85);
	  this.label3.Margin = new System.Windows.Forms.Padding(3);
	  this.label3.Name = "label3";
	  this.label3.Padding = new System.Windows.Forms.Padding(3);
	  this.label3.Size = new System.Drawing.Size(82, 18);
	  this.label3.TabIndex = 24;
	  this.label3.Text = "Action Timing:";
	  // 
	  // label6
	  // 
	  this.label6.AutoSize = true;
	  this.label6.Location = new System.Drawing.Point(3, 239);
	  this.label6.Margin = new System.Windows.Forms.Padding(3);
	  this.label6.Name = "label6";
	  this.label6.Padding = new System.Windows.Forms.Padding(3);
	  this.label6.Size = new System.Drawing.Size(88, 18);
	  this.label6.TabIndex = 27;
	  this.label6.Text = "Ready Min Diff:";
	  // 
	  // TemplateSettings
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.Controls.Add(this.gpbRoot);
	  this.Name = "TemplateSettings";
	  this.Size = new System.Drawing.Size(434, 314);
	  this.gpbRoot.ResumeLayout(false);
	  this.tableLayoutPanel3.ResumeLayout(false);
	  this.tableLayoutPanel3.PerformLayout();
	  this.flowLayoutPanel3.ResumeLayout(false);
	  this.flowLayoutPanel3.PerformLayout();
	  this.ResumeLayout(false);
	  this.PerformLayout();

	}

	#endregion
	private System.Windows.Forms.OpenFileDialog ofdTemplate;
	private System.Windows.Forms.GroupBox gpbRoot;
	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
	private System.Windows.Forms.TextBox ttbEnableIfArg;
	private System.Windows.Forms.TextBox ttbThreshold;
	private System.Windows.Forms.Label label10;
	private System.Windows.Forms.Label label7;
	private System.Windows.Forms.Label label5;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.TextBox ttbName;
	private System.Windows.Forms.Label label9;
	private System.Windows.Forms.ComboBox cbbMethod;
	private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
	private System.Windows.Forms.Label label12;
	private System.Windows.Forms.TextBox ttbOffsetX;
	private System.Windows.Forms.Label label11;
	private System.Windows.Forms.TextBox ttbOffsetY;
	private System.Windows.Forms.Label label13;
	private System.Windows.Forms.Button btnImage;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.ComboBox cbbAction;
	private System.Windows.Forms.Button btnRemove;
	private System.Windows.Forms.ComboBox cbbActionTiming;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.ComboBox cbbEnableIf;
	private System.Windows.Forms.TextBox ttbThresholdNeg;
	private System.Windows.Forms.Label label6;
  }
}
