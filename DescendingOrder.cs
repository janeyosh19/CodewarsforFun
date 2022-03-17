using System;
using System.Collections.Generic;



public static class Kata
{
  public static int DescendingOrder(int num)
  {
     List<string> numbers = new List<string>();

            foreach(char numb in num.ToString())
            {
                numbers.Add(numb.ToString());
                

            }

            numbers.Sort();
            numbers.Reverse();

            int result = int.Parse(string.Join("", numbers));
            return result;
    
  }
}