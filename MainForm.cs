using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace GhidraSymbolsExporter
{
	public partial class MainForm : Form
	{
		public SymbolsExporter Exporter;

		public MainForm()
		{
			InitializeComponent();

			Util.Main = this;
			Util.XMLPath = "";
			Util.SymbolsPath = "";

			Status.InitVisualFeedback();
			Status.UpdatePathStatusText();

			Exporter = new SymbolsExporter();
		}

		private void InputBrowseButton_Click(object sender, EventArgs e)
		{
			Status.StopVisualFeedback();
			if (Util.InputPath != string.Empty)
				InputFileDialog.InitialDirectory = Util.InputPath;
			if (InputFileDialog.ShowDialog() == DialogResult.OK)
			{
				InputTextBox.Text = InputFileDialog.FileName;
				Status.UpdatePath();
			}
		}
		private void OutputBrowseButton_Click(object sender, EventArgs e)
		{
			Status.StopVisualFeedback();
			if (Util.OutputPath != string.Empty)
				OutputFileDialog.InitialDirectory = Util.OutputPath;
			if (OutputFileDialog.ShowDialog() == DialogResult.OK)
			{
				OutputTextBox.Text = OutputFileDialog.FileName;
				Status.UpdatePath();
			}
		}

		private void GenerateButton_Click(object sender, EventArgs e)
		{
			Status.StopVisualFeedback();
			if (Status.CanExport())
			{
				Util.UpdateSettings();

				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();

				try
				{
					// create directory if it doesn't exist
					Directory.CreateDirectory(Util.OutputPath);

					Exporter.LoadXmlDocument();
					Exporter.ParseSymbols();
					Exporter.ExportSymbolsFile();

					stopwatch.Stop();
					long elapsedTime = stopwatch.ElapsedMilliseconds;
					Status.SetStatusText(string.Format("Done! [{0:d} ms]", elapsedTime));
				}
				catch (Exception ex)
				{
					Status.SetStatusText(ex.Message);
					Status.StartVisualFeedback();
				}
			}
			else
			{
				Status.StartVisualFeedback();
			}
		}

		private void InputTextBox_TextChanged(object sender, EventArgs e)
		{
			Status.UpdatePathStatusText();
		}
		private void OutputTextBox_TextChanged(object sender, EventArgs e)
		{
			Status.UpdatePathStatusText();
		}

		private void NDSProjectStandardLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/Ed-1T/NDS-Decompilation-Project-Maker");
		}
	}
}
