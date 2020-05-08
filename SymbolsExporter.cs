using System;
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
			// string begins with a number
			name = Regex.Replace(name, @"^[0-9]", "_");

			// part of a namespace
			if (nameSpace.EndsWith("::"))
			{
				// string begins with a number
				nameSpace = Regex.Replace(nameSpace, @"^[0-9]", "_");
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

				if (overlay == string.Empty)
					overlay = "arm9";

				Console.WriteLine("overlay: {0:s}", overlay);
				Console.WriteLine("address: 0x{0:X}", address);

				// use regular expressions to replace illegal characters
				name = RegexReplace(name, nameSpace);

				// create list
				if (!Symbols.ContainsKey(overlay))
					Symbols[overlay] = new List<SymbolEntry>();

				// insert symbol (ordered by overlay)
				Symbols[overlay].Add(new SymbolEntry(name, address));
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

					if (overlay.StartsWith("arm9"))
						overlay = "arm9";
					else if (overlay.StartsWith("arm7"))
						overlay = "arm7";

					if (overlay != lastOverlay)
					{
						lines.Add("");
						lines.Add(string.Format("/* {0:s} */", overlay));
						lines.Add("");
					}

					lastOverlay = overlay;
				}

				foreach (var sym in symbols)
				{
					// append symbol and address
					lines.Add(string.Format("{0:s} = 0x{1:X8};", sym.name, sym.address));
				}
			}

			File.WriteAllLines(Util.SymbolsPath, lines);
		}
	}
}
