using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using Antlr.Runtime;

namespace CombatAnalyzer
{
    public partial class frmMain : Form
    {
        //private ParsedLog l;
        private ICharStream afs;

        public frmMain()
        {
            InitializeComponent();
        }

        /*
        private void analyzeTargets()
        {
            Hashtable targetGroups = new Hashtable();
            foreach (ParsedLogEntry ple in l.Entries)
            {
                if (!targetGroups.ContainsKey(ple.Target))
                {
                    targetGroups.Add(ple.Target, new List<ParsedLogEntry>());
                }

                List<ParsedLogEntry> group = targetGroups[ple.Target] as List<ParsedLogEntry>;
                group.Add(ple);
            }

            foreach (DictionaryEntry de in targetGroups)
            {
                string target = de.Key.ToString();
                List<ParsedLogEntry> entries = de.Value as List<ParsedLogEntry>;

                int minDmg = Int32.MaxValue;
                int maxDmg = Int32.MinValue;
                int totDmg = 0;
                int avgDmg = 0;

                // Calculate numbers
                foreach (ParsedLogEntry ple in entries)
                {
                    if (ple.DamageAmount < minDmg) minDmg = ple.DamageAmount;
                    if (ple.DamageAmount > maxDmg) maxDmg = ple.DamageAmount;
                    totDmg += ple.DamageAmount;
                }
                avgDmg = totDmg / entries.Count;

                ListViewItem i = new ListViewItem(target);
                i.SubItems.Add(avgDmg.ToString());
                i.SubItems.Add(maxDmg.ToString());
                i.SubItems.Add(minDmg.ToString());
                listView1.Items.Add(i);
            }
        }
        private void analyzeSkills()
        {
            Hashtable skillGroups = new Hashtable();
            foreach (ParsedLogEntry ple in l.Entries)
            {
                if (!skillGroups.ContainsKey(ple.Skill))
                {
                    skillGroups.Add(ple.Skill, new List<ParsedLogEntry>());
                }

                List<ParsedLogEntry> group = skillGroups[ple.Skill] as List<ParsedLogEntry>;
                group.Add(ple);
            }

            foreach (DictionaryEntry de in skillGroups)
            {
                string skill = de.Key.ToString();
                List<ParsedLogEntry> entries = de.Value as List<ParsedLogEntry>;

                int minDmg = Int32.MaxValue;
                int maxDmg = Int32.MinValue;
                int totDmg = 0;
                int avgDmg = 0;

                // Calculate numbers
                foreach (ParsedLogEntry ple in entries)
                {
                    if (ple.DamageAmount < minDmg) minDmg = ple.DamageAmount;
                    if (ple.DamageAmount > maxDmg) maxDmg = ple.DamageAmount;
                    totDmg += ple.DamageAmount;
                }
                avgDmg = totDmg / entries.Count;

                if (skill == "") skill = "AUTO ATTACK";

                ListViewItem i = new ListViewItem(skill);
                i.SubItems.Add(avgDmg.ToString());
                i.SubItems.Add(maxDmg.ToString());
                i.SubItems.Add(minDmg.ToString());
                listView2.Items.Add(i);
            }
        }
        private void analyzeDmgType()
        {
            Hashtable dmgTypeGroups = new Hashtable();
            foreach (ParsedLogEntry ple in l.Entries)
            {
                if (!dmgTypeGroups.ContainsKey(ple.DamageType))
                {
                    dmgTypeGroups.Add(ple.DamageType, new List<ParsedLogEntry>());
                }

                List<ParsedLogEntry> group = dmgTypeGroups[ple.DamageType] as List<ParsedLogEntry>;
                group.Add(ple);
            }

            foreach (DictionaryEntry de in dmgTypeGroups)
            {
                string dmgType = de.Key.ToString();
                List<ParsedLogEntry> entries = de.Value as List<ParsedLogEntry>;

                int minDmg = Int32.MaxValue;
                int maxDmg = Int32.MinValue;
                int totDmg = 0;
                int avgDmg = 0;

                // Calculate numbers
                foreach (ParsedLogEntry ple in entries)
                {
                    if (ple.DamageAmount < minDmg) minDmg = ple.DamageAmount;
                    if (ple.DamageAmount > maxDmg) maxDmg = ple.DamageAmount;
                    totDmg += ple.DamageAmount;
                }
                avgDmg = totDmg / entries.Count;

                ListViewItem i = new ListViewItem(dmgType);
                i.SubItems.Add(avgDmg.ToString());
                i.SubItems.Add(maxDmg.ToString());
                i.SubItems.Add(minDmg.ToString());
                listView3.Items.Add(i);
            }
        }
        */

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView lst = sender as ListView;
            ListViewItemComparer c = lst.ListViewItemSorter as ListViewItemComparer;
            if(c!=null)            
                lst.ListViewItemSorter = new ListViewItemComparer(e.Column, !c.Ascending);
            else
                lst.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    afs = new ANTLRFileStream(dlg.FileName);
                    CombatAnalyzerLexer lxr = new CombatAnalyzerLexer(afs);
                    CommonTokenStream ts = new CommonTokenStream(lxr);
                    CombatAnalyzerParser parser = new CombatAnalyzerParser(ts);

                    parser.chatLine();
                }
                catch (NoViableAltException nve)
                {
                    MessageBox.Show(nve.Message + "\n" + nve.grammarDecisionDescription);
                }
            }
        }
    }
}