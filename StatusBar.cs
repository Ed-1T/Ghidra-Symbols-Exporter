﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace GhidraSymbolsExporter
{
	public static class Status
	{
		private static string InputPath => Util.Main.InputTextBox.Text;
		private static string OutputPath => Util.Main.OutputTextBox.Text;

		// path validity
		private static bool ValidInput;
		private static bool ValidOutput;

		// visual feedback (flashing text)
		private static Timer VisualFeedbackTimer;
		private static bool VisualFeedbackState;
		private static int VisualFeedbackCount;

		public static void SetStatusText(string text)
		{
			Util.Main.StatusLabel.Text = text;
			Util.Main.StatusLabel.Update();
		}
		private static void CheckPathStatus()
		{
			ValidInput = false;
			ValidOutput = true;

			// check if input path is valid
			ValidInput = File.Exists(InputPath);

			if (OutputPath.Length == 0)
				ValidOutput = false;
		}
		public static void UpdatePathStatusText()
		{
			CheckPathStatus();

			if (ValidInput && ValidOutput)
			{
				SetStatusText("Ready, click Export to begin");
				UpdatePath();
			}
			else if (ValidInput && !ValidOutput)
				SetStatusText("Please choose an output file");
			else if (!ValidInput && ValidOutput)
				SetStatusText("Please choose an input XML project");
			else
				SetStatusText("Please choose an input XML project and an output file");
		}
		public static bool CanExport()
		{
			CheckPathStatus();
			return ValidInput && ValidOutput;
		}
		public static void UpdatePath()
		{
			try
			{
				Util.XMLPath = InputPath;
				Util.SymbolsPath = OutputPath;
				Util.InputPath = Path.GetDirectoryName(Util.XMLPath);
				Util.OutputPath = Path.GetDirectoryName(Util.SymbolsPath);
			}
			catch (Exception)
			{
				// catch null string exception from GetDirectoryName
			}
		}

		// text visual feedback
		public static void InitVisualFeedback()
		{
			VisualFeedbackTimer = new Timer();
			VisualFeedbackTimer.Interval = 100;
			VisualFeedbackTimer.Tick += VisualFeedbackTimer_Tick;
			StopVisualFeedback();
		}
		public static void StartVisualFeedback()
		{
			Util.Main.StatusLabel.ForeColor = Color.FromArgb(255, 0, 0);
			VisualFeedbackCount = 0;
			VisualFeedbackState = true;
			VisualFeedbackTimer.Start();
		}
		public static void StopVisualFeedback()
		{
			Util.Main.StatusLabel.ForeColor = Color.FromArgb(0, 0, 0);
			VisualFeedbackCount = 0;
			VisualFeedbackState = true;
			VisualFeedbackTimer.Stop();
		}
		public static void VisualFeedbackTimer_Tick(object sender, EventArgs e)
		{
			Util.Main.StatusLabel.ForeColor = VisualFeedbackState ? Color.Black : Color.Red;

			VisualFeedbackState = !VisualFeedbackState;

			if (VisualFeedbackCount > 9)
				VisualFeedbackTimer.Stop();

			VisualFeedbackCount++;
		}

		// progress bar
		public static void InitProgress()
		{
			Util.Main.ProgressBar.Value = 0;
			Util.Main.ProgressBar.Maximum = 100;
		}
		public static void DivideProgress(int max)
		{
			Util.Main.ProgressBar.Maximum = max;
		}
		public static void IncrementProgress()
		{
			Util.Main.ProgressBar.Value++;
		}
		public static void FillProgress()
		{
			Util.Main.ProgressBar.Value = Util.Main.ProgressBar.Maximum;
		}
	}
}
