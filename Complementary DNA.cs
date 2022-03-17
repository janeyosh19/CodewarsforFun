using System;
using System.Collections.Generic;



public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
            List<string> newsymbols = new List<string>();
            string changesymbol;

            foreach (char symbol in dna)
            {
                if (symbol == 'A')
                {
                    changesymbol = char.ToString(symbol);
                    newsymbols.Add(changesymbol.Replace("A", "T"));

                }
                if (symbol == 'T')
                {
                    changesymbol = char.ToString(symbol);
                    newsymbols.Add(changesymbol.Replace('T', 'A'));

                }
                if (symbol == 'C')
                {
                    changesymbol = char.ToString(symbol);
                    newsymbols.Add(changesymbol.Replace('C', 'G'));

                }
                if (symbol == 'G')
                {
                    changesymbol = char.ToString(symbol);
                    newsymbols.Add(changesymbol.Replace('G', 'C'));

                }
            }


            string changesymbol1 = String.Join("", newsymbols);
               
            return changesymbol1;
        }
    }