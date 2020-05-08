namespace GhidraSymbolsExporter
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MainTblLytPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ControlsTblLytPanel = new System.Windows.Forms.TableLayoutPanel();
			this.FileTblLytPanel = new System.Windows.Forms.TableLayoutPanel();
			this.OutputBrowseButton = new System.Windows.Forms.Button();
			this.OutputGroupBox = new System.Windows.Forms.GroupBox();
			this.OutputTextBox = new System.Windows.Forms.TextBox();
			this.InputBrowseButton = new System.Windows.Forms.Button();
			this.InputGroupBox = new System.Windows.Forms.GroupBox();
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.ControlsGroupBox = new System.Windows.Forms.GroupBox();
			this.ExportingTblLytPanel = new System.Windows.Forms.TableLayoutPanel();
			this.NDSStandardProjectCheckBox = new System.Windows.Forms.CheckBox();
			this.ExportButton = new System.Windows.Forms.Button();
			this.NDSProjectStandardLinkLabel = new System.Windows.Forms.LinkLabel();
			this.ProgressBarTblLytPanel = new System.Windows.Forms.TableLayoutPanel();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.StatusLabel = new System.Windows.Forms.Label();
			this.InputFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SymbolsFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.OutputFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SkipSwitchSymbolsCheckBox = new System.Windows.Forms.CheckBox();
			this.MainTblLytPanel.SuspendLayout();
			this.ControlsTblLytPanel.SuspendLayout();
			this.FileTblLytPanel.SuspendLayout();
			this.OutputGroupBox.SuspendLayout();
			this.InputGroupBox.SuspendLayout();
			this.ControlsGroupBox.SuspendLayout();
			this.ExportingTblLytPanel.SuspendLayout();
			this.ProgressBarTblLytPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTblLytPanel
			// 
			this.MainTblLytPanel.ColumnCount = 1;
			this.MainTblLytPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.MainTblLytPanel.Controls.Add(this.ControlsTblLytPanel, 0, 0);
			this.MainTblLytPanel.Controls.Add(this.ProgressBarTblLytPanel, 0, 1);
			this.MainTblLytPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainTblLytPanel.Location = new System.Drawing.Point(0, 0);
			this.MainTblLytPanel.Name = "MainTblLytPanel";
			this.MainTblLytPanel.RowCount = 2;
			this.MainTblLytPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.MainTblLytPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.MainTblLytPanel.Size = new System.Drawing.Size(720, 207);
			this.MainTblLytPanel.TabIndex = 0;
			// 
			// ControlsTblLytPanel
			// 
			this.ControlsTblLytPanel.ColumnCount = 2;
			this.ControlsTblLytPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
			this.ControlsTblLytPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.ControlsTblLytPanel.Controls.Add(this.FileTblLytPanel, 0, 0);
			this.ControlsTblLytPanel.Controls.Add(this.ControlsGroupBox, 1, 0);
			this.ControlsTblLytPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ControlsTblLytPanel.Location = new System.Drawing.Point(3, 3);
			this.ControlsTblLytPanel.Name = "ControlsTblLytPanel";
			this.ControlsTblLytPanel.RowCount = 1;
			this.ControlsTblLytPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ControlsTblLytPanel.Size = new System.Drawing.Size(714, 138);
			this.ControlsTblLytPanel.TabIndex = 1;
			// 
			// FileTblLytPanel
			// 
			this.FileTblLytPanel.ColumnCount = 2;
			this.FileTblLytPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.FileTblLytPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.FileTblLytPanel.Controls.Add(this.OutputBrowseButton, 1, 1);
			this.FileTblLytPanel.Controls.Add(this.OutputGroupBox, 0, 1);
			this.FileTblLytPanel.Controls.Add(this.InputBrowseButton, 1, 0);
			this.FileTblLytPanel.Controls.Add(this.InputGroupBox, 0, 0);
			this.FileTblLytPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FileTblLytPanel.Location = new System.Drawing.Point(3, 3);
			this.FileTblLytPanel.Name = "FileTblLytPanel";
			this.FileTblLytPanel.RowCount = 2;
			this.FileTblLytPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.FileTblLytPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.FileTblLytPanel.Size = new System.Drawing.Size(458, 132);
			this.FileTblLytPanel.TabIndex = 0;
			// 
			// OutputBrowseButton
			// 
			this.OutputBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputBrowseButton.Location = new System.Drawing.Point(369, 87);
			this.OutputBrowseButton.Name = "OutputBrowseButton";
			this.OutputBrowseButton.Size = new System.Drawing.Size(86, 23);
			this.OutputBrowseButton.TabIndex = 4;
			this.OutputBrowseButton.Text = "Browse...";
			this.OutputBrowseButton.UseVisualStyleBackColor = true;
			this.OutputBrowseButton.Click += new System.EventHandler(this.OutputBrowseButton_Click);
			// 
			// OutputGroupBox
			// 
			this.OutputGroupBox.Controls.Add(this.OutputTextBox);
			this.OutputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OutputGroupBox.Location = new System.Drawing.Point(3, 69);
			this.OutputGroupBox.Name = "OutputGroupBox";
			this.OutputGroupBox.Size = new System.Drawing.Size(360, 60);
			this.OutputGroupBox.TabIndex = 0;
			this.OutputGroupBox.TabStop = false;
			this.OutputGroupBox.Text = "Output symbols";
			// 
			// OutputTextBox
			// 
			this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputTextBox.Location = new System.Drawing.Point(6, 21);
			this.OutputTextBox.Name = "OutputTextBox";
			this.OutputTextBox.Size = new System.Drawing.Size(348, 20);
			this.OutputTextBox.TabIndex = 3;
			this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
			// 
			// InputBrowseButton
			// 
			this.InputBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.InputBrowseButton.Location = new System.Drawing.Point(369, 21);
			this.InputBrowseButton.Name = "InputBrowseButton";
			this.InputBrowseButton.Size = new System.Drawing.Size(86, 23);
			this.InputBrowseButton.TabIndex = 2;
			this.InputBrowseButton.Text = "Browse...";
			this.InputBrowseButton.UseVisualStyleBackColor = true;
			this.InputBrowseButton.Click += new System.EventHandler(this.InputBrowseButton_Click);
			// 
			// InputGroupBox
			// 
			this.InputGroupBox.Controls.Add(this.InputTextBox);
			this.InputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InputGroupBox.Location = new System.Drawing.Point(3, 3);
			this.InputGroupBox.Name = "InputGroupBox";
			this.InputGroupBox.Size = new System.Drawing.Size(360, 60);
			this.InputGroupBox.TabIndex = 0;
			this.InputGroupBox.TabStop = false;
			this.InputGroupBox.Text = "Input XML project";
			// 
			// InputTextBox
			// 
			this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.InputTextBox.Location = new System.Drawing.Point(6, 21);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(348, 20);
			this.InputTextBox.TabIndex = 1;
			this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
			// 
			// ControlsGroupBox
			// 
			this.ControlsGroupBox.Controls.Add(this.ExportingTblLytPanel);
			this.ControlsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ControlsGroupBox.Location = new System.Drawing.Point(467, 3);
			this.ControlsGroupBox.Name = "ControlsGroupBox";
			this.ControlsGroupBox.Size = new System.Drawing.Size(244, 132);
			this.ControlsGroupBox.TabIndex = 1;
			this.ControlsGroupBox.TabStop = false;
			this.ControlsGroupBox.Text = "Exporting";
			// 
			// ExportingTblLytPanel
			// 
			this.ExportingTblLytPanel.ColumnCount = 2;
			this.ExportingTblLytPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ExportingTblLytPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ExportingTblLytPanel.Controls.Add(this.NDSStandardProjectCheckBox, 0, 0);
			this.ExportingTblLytPanel.Controls.Add(this.ExportButton, 0, 2);
			this.ExportingTblLytPanel.Controls.Add(this.NDSProjectStandardLinkLabel, 0, 1);
			this.ExportingTblLytPanel.Controls.Add(this.SkipSwitchSymbolsCheckBox, 1, 0);
			this.ExportingTblLytPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ExportingTblLytPanel.Location = new System.Drawing.Point(3, 16);
			this.ExportingTblLytPanel.Name = "ExportingTblLytPanel";
			this.ExportingTblLytPanel.RowCount = 3;
			this.ExportingTblLytPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ExportingTblLytPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ExportingTblLytPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.ExportingTblLytPanel.Size = new System.Drawing.Size(238, 113);
			this.ExportingTblLytPanel.TabIndex = 0;
			// 
			// NDSStandardProjectCheckBox
			// 
			this.NDSStandardProjectCheckBox.AutoSize = true;
			this.NDSStandardProjectCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NDSStandardProjectCheckBox.Location = new System.Drawing.Point(3, 3);
			this.NDSStandardProjectCheckBox.Name = "NDSStandardProjectCheckBox";
			this.NDSStandardProjectCheckBox.Size = new System.Drawing.Size(113, 31);
			this.NDSStandardProjectCheckBox.TabIndex = 0;
			this.NDSStandardProjectCheckBox.Text = "NDS project standard";
			this.NDSStandardProjectCheckBox.UseVisualStyleBackColor = true;
			// 
			// ExportButton
			// 
			this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ExportButton.Location = new System.Drawing.Point(3, 82);
			this.ExportButton.Name = "ExportButton";
			this.ExportButton.Size = new System.Drawing.Size(113, 23);
			this.ExportButton.TabIndex = 3;
			this.ExportButton.Text = "Export";
			this.ExportButton.UseVisualStyleBackColor = true;
			this.ExportButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// NDSProjectStandardLinkLabel
			// 
			this.NDSProjectStandardLinkLabel.AutoSize = true;
			this.NDSProjectStandardLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NDSProjectStandardLinkLabel.Location = new System.Drawing.Point(3, 37);
			this.NDSProjectStandardLinkLabel.Name = "NDSProjectStandardLinkLabel";
			this.NDSProjectStandardLinkLabel.Size = new System.Drawing.Size(113, 37);
			this.NDSProjectStandardLinkLabel.TabIndex = 4;
			this.NDSProjectStandardLinkLabel.TabStop = true;
			this.NDSProjectStandardLinkLabel.Text = "(if the project was created using this tool)";
			this.NDSProjectStandardLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NDSProjectStandardLinkLabel_LinkClicked);
			// 
			// ProgressBarTblLytPanel
			// 
			this.ProgressBarTblLytPanel.ColumnCount = 1;
			this.ProgressBarTblLytPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ProgressBarTblLytPanel.Controls.Add(this.ProgressBar, 0, 1);
			this.ProgressBarTblLytPanel.Controls.Add(this.StatusLabel, 0, 0);
			this.ProgressBarTblLytPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProgressBarTblLytPanel.Location = new System.Drawing.Point(3, 147);
			this.ProgressBarTblLytPanel.Name = "ProgressBarTblLytPanel";
			this.ProgressBarTblLytPanel.RowCount = 2;
			this.ProgressBarTblLytPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ProgressBarTblLytPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.ProgressBarTblLytPanel.Size = new System.Drawing.Size(714, 57);
			this.ProgressBarTblLytPanel.TabIndex = 2;
			// 
			// ProgressBar
			// 
			this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProgressBar.Location = new System.Drawing.Point(3, 31);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(708, 23);
			this.ProgressBar.TabIndex = 0;
			// 
			// StatusLabel
			// 
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StatusLabel.Location = new System.Drawing.Point(3, 0);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(708, 28);
			this.StatusLabel.TabIndex = 1;
			// 
			// InputFileDialog
			// 
			this.InputFileDialog.FileName = "Choose an XML project";
			this.InputFileDialog.Filter = "XML Project Files (*.xml)|*.xml|All files (*.*)|*.*";
			// 
			// SymbolsFileDialog
			// 
			this.SymbolsFileDialog.FileName = "Choose a symbols file";
			// 
			// SkipSwitchSymbolsCheckBox
			// 
			this.SkipSwitchSymbolsCheckBox.AutoSize = true;
			this.SkipSwitchSymbolsCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SkipSwitchSymbolsCheckBox.Location = new System.Drawing.Point(122, 3);
			this.SkipSwitchSymbolsCheckBox.Name = "SkipSwitchSymbolsCheckBox";
			this.SkipSwitchSymbolsCheckBox.Size = new System.Drawing.Size(113, 31);
			this.SkipSwitchSymbolsCheckBox.TabIndex = 5;
			this.SkipSwitchSymbolsCheckBox.Text = "Skip switch statement labels";
			this.SkipSwitchSymbolsCheckBox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 207);
			this.Controls.Add(this.MainTblLytPanel);
			this.Location = new System.Drawing.Point(630, 246);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1920, 246);
			this.MinimumSize = new System.Drawing.Size(736, 246);
			this.Name = "MainForm";
			this.Text = "Nintendo DS Decompilation Project Maker";
			this.MainTblLytPanel.ResumeLayout(false);
			this.ControlsTblLytPanel.ResumeLayout(false);
			this.FileTblLytPanel.ResumeLayout(false);
			this.OutputGroupBox.ResumeLayout(false);
			this.OutputGroupBox.PerformLayout();
			this.InputGroupBox.ResumeLayout(false);
			this.InputGroupBox.PerformLayout();
			this.ControlsGroupBox.ResumeLayout(false);
			this.ExportingTblLytPanel.ResumeLayout(false);
			this.ExportingTblLytPanel.PerformLayout();
			this.ProgressBarTblLytPanel.ResumeLayout(false);
			this.ProgressBarTblLytPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel MainTblLytPanel;
		private System.Windows.Forms.TableLayoutPanel ControlsTblLytPanel;
		private System.Windows.Forms.Button InputBrowseButton;
		private System.Windows.Forms.TableLayoutPanel FileTblLytPanel;
		private System.Windows.Forms.GroupBox InputGroupBox;
		private System.Windows.Forms.Button OutputBrowseButton;
		private System.Windows.Forms.GroupBox OutputGroupBox;
		private System.Windows.Forms.GroupBox ControlsGroupBox;
		private System.Windows.Forms.TableLayoutPanel ExportingTblLytPanel;
		private System.Windows.Forms.Button ExportButton;
		private System.Windows.Forms.OpenFileDialog InputFileDialog;
		private System.Windows.Forms.TableLayoutPanel ProgressBarTblLytPanel;
		public System.Windows.Forms.ProgressBar ProgressBar;
		public System.Windows.Forms.Label StatusLabel;
		public System.Windows.Forms.TextBox InputTextBox;
		public System.Windows.Forms.TextBox OutputTextBox;
		public System.Windows.Forms.CheckBox NDSStandardProjectCheckBox;
		private System.Windows.Forms.OpenFileDialog SymbolsFileDialog;
		private System.Windows.Forms.LinkLabel NDSProjectStandardLinkLabel;
		private System.Windows.Forms.SaveFileDialog OutputFileDialog;
		public System.Windows.Forms.CheckBox SkipSwitchSymbolsCheckBox;
	}
}

