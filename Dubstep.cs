using System;
using System.Linq;
using System.Collections.Generic;

public class Dubstep
    {
        public static string SongDecoder(string input)
        { 
          
             
            
           
            var LeftOver = input.Split("WUB").ToList();
            bool LeftOverSpace = false;
            List<string> LeftOverWithoutSpace = new List <string>();
            foreach (string s in LeftOver)
            {
                LeftOverSpace = !String.IsNullOrWhiteSpace(s);
                if (LeftOverSpace == true)
                {
                    LeftOverWithoutSpace.Add(s);
                }

            }

            string Output = String.Join(" ", LeftOverWithoutSpace);

          return Output;


        }
    }