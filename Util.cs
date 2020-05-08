using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace GhidraSymbolsExporter
{
	public static class Util
	{
		public static MainForm Main;

		// paths
		public static string XMLPath
		{
			get => Properties.Settings.Default.xmlPath;
			set
			{
				Properties.Settings.Default.xmlPath = value;
				Properties.Settings.Default.Save();
			}
		}
		public static string SymbolsPath
		{
			get => Properties.Settings.Default.symbolsPath;
			set
			{
				Properties.Settings.Default.symbolsPath = value;
				Properties.Settings.Default.Save();
			}
		}
		public static string InputPath
		{
			get => Properties.Settings.Default.inputPath;
			set
			{
				Properties.Settings.Default.inputPath = value;
				Properties.Settings.Default.Save();
			}
		}
		public static string OutputPath
		{
			get => Properties.Settings.Default.outputPath;
			set
			{
				Properties.Settings.Default.outputPath = value;
				Properties.Settings.Default.Save();
			}
		}

		// settings
		public static bool NDSProjectStandard;
		public static bool SkipSwitchSymbols;

		public static void UpdateSettings()
		{
			NDSProjectStandard = Main.NDSStandardProjectCheckBox.Checked;
			SkipSwitchSymbols = Main.SkipSwitchSymbolsCheckBox.Checked;
		}
	}
}
