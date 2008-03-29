using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CombatAnalyzer
{
    public static class Parser
    {
        static Parser()
        {
        }

        public static ParsedLog ParseLog(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException();

            StreamReader r = new StreamReader(path);
            ParsedLog pl = new ParsedLog();
            string data = r.ReadLine();
            while (!String.IsNullOrEmpty(data))
            {
                if (data.EndsWith(".")) data = data.Remove(data.LastIndexOf("."));

                string[] tokens = TokenizeLine(data.ToUpper());

                ParsedLogEntry ple = new ParsedLogEntry();
                DetermineActors(tokens, ref ple);
                DetermineDamage(tokens, ref ple);
                pl.Entries.Add(ple);

                data = r.ReadLine();
            }

            // clean the log of bad entries
            pl.Entries.RemoveAll(new Predicate<ParsedLogEntry>(isBadEntry));
            return pl;
        }

        private static bool isBadEntry(ParsedLogEntry item)
        {

            return (String.IsNullOrEmpty(item.Actor));
        }
        private static string[] TokenizeLine(string data)
        {
            return data.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        }
        private static void DetermineActors(string[] tokens, ref ParsedLogEntry log)
        {
            // some known non-processed lines
            if (tokens[0] == "###") return;
            if (tokens[0] == "LOGGING") return;
            if (tokens[0] == "YOUR") return;


            if (tokens[0] == "YOU")
            {
                // check for some other odd-ball sentences
                if (tokens[1] == "ARE") return;
                if (tokens[1] == "REFLECT") return;

                // YOU are the actor
                log.Actor = tokens[0];
                log.actorIdx = 0;

                // Find the target's name
                for (int x = 2; x < tokens.Length; x++)
                {
                    // "for" or "with" start the dmg amount section
                    if (tokens[x] == "FOR" || tokens[x] == "WITH")
                    {
                        for (int y = 2; y < x; y++)
                        {
                            if (log.Target.Length > 0) log.Target += " ";
                            log.Target += tokens[y];
                        }

                        // stop looping
                        break;
                    }
                }
            }
            else
            {
                for (int x = 1; x < tokens.Length; x++)
                {
                    if (tokens[x] == "WOUNDS")
                    {
                        // target name starts after the verb
                        log.tgtIdx = x + 1;

                        // actor's full name is index 0..x-1
                        for (int y = 0; y < x; y++)
                        {
                            if (log.Actor.Length > 0) log.Actor += " ";
                            log.Actor += tokens[y];
                        }

                        // stop searching
                        break;
                    }
                }

                // should be "YOU"
                log.Target = tokens[log.tgtIdx];
            }
        }
        private static void DetermineDamage(string[] tokens, ref ParsedLogEntry log)
        {
            for (int x = 0; x < tokens.Length; x++)
            {
                if (tokens[x] == "WITH")
                {
                    ParseWithDmgStmt(tokens, x + 1, ref log);
                }
                if (tokens[x] == "FOR")
                {
                    ParseForDmgStmt(tokens, x + 1, ref log);
                    break;
                }
            }
        }
        private static void ParseWithDmgStmt(string[] tokens, int startIndex, ref ParsedLogEntry log)
        {
            // Find the "for" part
            int forIdx = 0;
            for (int x = startIndex; x < tokens.Length; x++)
            {
                if (tokens[x] == "FOR") forIdx = x;
            }

            // Skill name = forIdx - startIndex
            log.skillIdx = startIndex;
            for (int sn = startIndex; sn < forIdx; sn++)
            {
                if (log.Skill.Length > 0) log.Skill += " ";
                log.Skill += tokens[sn];
            }

            
        }
        private static void ParseForDmgStmt(string[] tokens, int startIndex, ref ParsedLogEntry log)
        {
            log.dmgAmtIdx = startIndex;
            log.DamageAmount = Int32.Parse(tokens[startIndex].Replace(",", ""));

            for (int x = startIndex + 3; x < tokens.Length; x++)
            {
                if(log.DamageType.Length>0) log.DamageType += " ";
                log.DamageType += tokens[x];
            }            
        }
    }
}
