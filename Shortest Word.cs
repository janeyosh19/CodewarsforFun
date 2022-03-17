using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int FindShort(string s)
  {
    var words = s.Split(' ');
            List<int> listoflengths = new List<int>();

            foreach (string word in words)
            {
                int wordlength = word.Length;
                listoflengths.Add(wordlength);
               
                            
            }

            
            int shortestlength = listoflengths.Min();


            return shortestlength;
  }
}