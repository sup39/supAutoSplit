namespace LiveSplit.SupAutoSplit.UI {
  partial class Settings {
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
	  this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
	  this.label3 = new System.Windows.Forms.Label();
	  this.label1 = new System.Windows.Forms.Label();
	  this.groupBox1 = new System.Windows.Forms.GroupBox();
	  this.tlpTemplates = new System.Windows.Forms.TableLayoutPanel();
	  this.btnAddTemplate = new System.Windows.Forms.Button();
	  this.tableLayoutPanel1.SuspendLayout();
	  this.groupBox1.SuspendLayout();
	  this.tlpTemplates.SuspendLayout();
	  this.SuspendLayout();
	  // 
	  // tableLayoutPanel1
	  // 
	  this.tableLayoutPanel1.AutoSize = true;
	  this.tableLayoutPanel1.ColumnCount = 2;
	  this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
	  this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
	  this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
	  this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
	  this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
	  this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
	  this.tableLayoutPanel1.Name = "tableLayoutPanel1";
	  this.tableLayoutPanel1.RowCount = 2;
	  this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
	  this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 79);
	  this.tableLayoutPanel1.TabIndex = 0;
	  // 
	  // label3
	  // 
	  this.label3.AutoSize = true;
	  this.label3.Location = new System.Drawing.Point(54, 3);
	  this.label3.Margin = new System.Windows.Forms.Padding(3);
	  this.label3.Name = "label3";
	  this.label3.Padding = new System.Windows.Forms.Padding(3);
	  this.label3.Size = new System.Drawing.Size(65, 18);
	  this.label3.TabIndex = 2;
	  this.label3.Text = "SMS Any%";
	  // 
	  // label1
	  // 
	  this.label1.AutoSize = true;
	  this.label1.Location = new System.Drawing.Point(3, 3);
	  this.label1.Margin = new System.Windows.Forms.Padding(3);
	  this.label1.Name = "label1";
	  this.label1.Padding = new System.Windows.Forms.Padding(3);
	  this.label1.Size = new System.Drawing.Size(45, 18);
	  this.label1.TabIndex = 0;
	  this.label1.Text = "Profile:";
	  // 
	  // groupBox1
	  // 
	  this.groupBox1.AutoSize = true;
	  this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
	  this.groupBox1.Controls.Add(this.tlpTemplates);
	  this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.groupBox1.Location = new System.Drawing.Point(3, 27);
	  this.groupBox1.Name = "groupBox1";
	  this.groupBox1.Size = new System.Drawing.Size(444, 49);
	  this.groupBox1.TabIndex = 3;
	  this.groupBox1.TabStop = false;
	  this.groupBox1.Text = "Templates";
	  // 
	  // tlpTemplates
	  // 
	  this.tlpTemplates.AutoSize = true;
	  this.tlpTemplates.ColumnCount = 1;
	  this.tlpTemplates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
	  this.tlpTemplates.Controls.Add(this.btnAddTemplate, 0, 0);
	  this.tlpTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
	  this.tlpTemplates.Location = new System.Drawing.Point(3, 18);
	  this.tlpTemplates.Name = "tlpTemplates";
	  this.tlpTemplates.RowCount = 1;
	  this.tlpTemplates.RowStyles.Add(new System.Windows.Forms.RowStyle());
	  this.tlpTemplates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
	  this.tlpTemplates.Size = new System.Drawing.Size(438, 28);
	  this.tlpTemplates.TabIndex = 0;
	  // 
	  // btnAddTemplate
	  // 
	  this.btnAddTemplate.AutoSize = true;
	  this.btnAddTemplate.Location = new System.Drawing.Point(3, 3);
	  this.btnAddTemplate.Name = "btnAddTemplate";
	  this.btnAddTemplate.Size = new System.Drawing.Size(81, 22);
	  this.btnAddTemplate.TabIndex = 0;
	  this.btnAddTemplate.Text = "Add Template";
	  this.btnAddTemplate.UseVisualStyleBackColor = true;
	  this.btnAddTemplate.Click += new System.EventHandler(this.BtnAddTemplate_Click);
	  // 
	  // Settings
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.AutoSize = true;
	  this.Controls.Add(this.tableLayoutPanel1);
	  this.Name = "Settings";
	  this.Padding = new System.Windows.Forms.Padding(3);
	  this.Size = new System.Drawing.Size(456, 85);
	  this.tableLayoutPanel1.ResumeLayout(false);
	  this.tableLayoutPanel1.PerformLayout();
	  this.groupBox1.ResumeLayout(false);
	  this.groupBox1.PerformLayout();
	  this.tlpTemplates.ResumeLayout(false);
	  this.tlpTemplates.PerformLayout();
	  this.ResumeLayout(false);
	  this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.GroupBox groupBox1;
	private System.Windows.Forms.TableLayoutPanel tlpTemplates;
	private System.Windows.Forms.Button btnAddTemplate;
  }
}
