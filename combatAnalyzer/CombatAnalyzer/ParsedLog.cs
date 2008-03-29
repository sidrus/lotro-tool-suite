using System;
using System.Collections.Generic;
using System.Text;

namespace CombatAnalyzer
{
    public class ParsedLog
    {
        private List<ParsedLogEntry> entries = new List<ParsedLogEntry>();
        public List<ParsedLogEntry> Entries
        {
            get { return entries; }
        }
    }
}
