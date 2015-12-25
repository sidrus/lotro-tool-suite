using System;
using System.Collections.Generic;
using System.Text;

namespace CombatAnalyzer
{
    public class ParsedLogEntry
    {
        // Values
        private string actor = "";
        private string tgt = "";
        private string skill = "";
        private string dmgType = "";
        private int dmgAmt = 0;

        // Placemarks
        internal int actorIdx;
        internal int tgtIdx;
        internal int skillIdx;
        internal int dmgTypeIdx;
        internal int dmgAmtIdx;

        public string Actor
        {
            get { return actor; }
            set { actor = value; }
        }
        public string Target
        {
            get { return tgt; }
            set { tgt = value; }
        }
        public string Skill
        {
            get { return skill; }
            set { skill = value; }
        }
        public string DamageType
        {
            get { return dmgType; }
            set { dmgType = value; }
        }
        public int DamageAmount
        {
            get { return dmgAmt; }
            set { dmgAmt = value; }
        }
    }
}
