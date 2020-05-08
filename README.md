# Ghidra-Symbols-Exporter
A tool to export symbols from a Ghidra XML project

# Usage
- Select an input XML project
- Select an output symbols file
- Click **Export**

# Settings
- **NDS project standard**: Outputs comments that mark the start of an overlay area, used in conjunction with the [**NDS Decompilation Project Maker**](https://github.com/Ed-1T/NDS-Decompilation-Project-Maker)
- **Skip switch statement labels**: switch cases are marked as symbols and most of the times they're unwanted, enable the checkbox to disable them from being written
