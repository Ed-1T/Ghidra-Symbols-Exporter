﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace GhidraSymbolsExporter
{
	public struct SymbolEntry
	{
		public string name;
		public uint address;

		public SymbolEntry(string name, uint address)
		{
			this.name = name;
			this.address = address;
		}
	}

	public class SymbolsExporter
	{
		public XDocument Document { get; private set; }
		public Dictionary<string, List<SymbolEntry>> Symbols;

		// main functions
		public void LoadXmlDocument()
		{
			Document = XDocument.Load(Util.XMLPath);
			Symbols = new Dictionary<string, List<SymbolEntry>>();
		}

		private string RegexReplace(string name, string nameSpace)
		{
			if (name == string.Empty)
				return "";

			// string begins with a number
			if (name.First() >= '0' && name.First() <= '9')
				name = name.Insert(0, "_");

			// part of a namespace
			if (nameSpace.EndsWith("::"))
			{
				// string begins with a number
				if (nameSpace.First() >= '0' && nameSpace.First() <= '9')
					nameSpace = nameSpace.Insert(0, "_");

				name = nameSpace + name;
			}

			name = name.Replace("::", "__"); // scope resolution operator (namespaces)
			name = name.Replace(".", "_");  // eg. "operator.new"
			name = Regex.Replace(name, @"[{}()-.,:;\/\\€!\""£$%&=? 'ì^èé+*ù§à°òç@#\[<>\]]", "");

			return name;
		}

		public void ParseSymbols()
		{ 
			var prg = Document.Element("PROGRAM");
			var symTbl = prg.Element("SYMBOL_TABLE");
			var symArr = symTbl.Elements("SYMBOL").ToArray();

			int invalidSymbolID = 0;

			foreach (var symbol in symArr)
			{
				var sAddress = symbol.Attribute("ADDRESS").Value;
				var nameSpace = symbol.Attribute("NAMESPACE").Value;
				var name = symbol.Attribute("NAME").Value;

				string overlay = "";
				int idx = sAddress.IndexOf("ram:");

				// address is inside an overlay, extract name and address,
				// insert the name and the address in a SharedAddresses dictionary
				if (idx > 0)
				{
					// extract memory section (overlay)
					overlay = sAddress.Substring(0, idx - 2);

					// extract address
					int start = idx + 4;
					int length = sAddress.Length - start;
					sAddress = sAddress.Substring(start, length);

					Console.WriteLine("where: {0:d}", idx);
				}

				uint address = uint.Parse(sAddress, System.Globalization.NumberStyles.HexNumber);

				uint min = 0x1000000;
				uint max = 0x3000000;

				// (arm7 can have access to shared wram)
				if (overlay.StartsWith("arm7"))
					max = 0x4000000;

				if (address < min || address >= max)
				{
					Console.WriteLine("symbol {0:s} skipped (invalid address 0x{1:X8})", name, address);
					continue;
				}

				if (overlay == string.Empty)
					overlay = "arm9";

				// use regular expressions to replace illegal characters
				name = RegexReplace(name, nameSpace);

				if (name == string.Empty)
					name = string.Format("invalid_symbol_name_{0:d}", ++invalidSymbolID);

				// create list
				if (!Symbols.ContainsKey(overlay))
					Symbols[overlay] = new List<SymbolEntry>();

				// insert symbol (ordered by overlay)
				Symbols[overlay].Add(new SymbolEntry(name, address));

				Console.WriteLine("overlay: {0:s}", overlay);
				Console.WriteLine("address: 0x{0:X}", address);
				Console.WriteLine("name: '{0:s}'", name);
			}
		}

		public void ExportSymbolsFile()
		{
			File.Delete(Util.SymbolsPath);
			List<string> lines = new List<string>();

			string lastOverlay = "";

			foreach(var s in Symbols)
			{
				string overlay = s.Key;
				var symbols = s.Value;

				if(Util.NDSProjectStandard)
				{
					overlay = overlay.Replace(".bss", "");

					// arm9 section
					if (overlay.StartsWith("arm9") && !overlay.StartsWith("arm9_ov"))
						overlay = "arm9";
					// arm7 section
					else if (overlay.StartsWith("arm7") && !overlay.StartsWith("arm7_ov"))
						overlay = "arm7";

					if (overlay != lastOverlay)
					{
						lines.Add("");
						lines.Add(string.Format("/* {0:s} */", overlay));
						lines.Add("");
					}

					lastOverlay = overlay;
				}

				Status.InitProgress();
				Status.DivideProgress(symbols.Count);

				int i = 0;

				foreach (var sym in symbols)
				{
					Status.SetStatusText(string.Format("Writing symbols in overlay: {0:s} [{1:d}/{2:d}]", lastOverlay, ++i, symbols.Count));

					if (Util.SkipSwitchSymbols && sym.name.StartsWith("switchD"))
						continue;

					// append symbol and address
					lines.Add(string.Format("{0:s} = 0x{1:X8};", sym.name, sym.address));

					Status.IncrementProgress();
				}

				Status.FillProgress();
			}

			File.WriteAllLines(Util.SymbolsPath, lines);
		}
	}
}
