using System;
using System.Linq;


namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
         string multiply = string.Concat(Enumerable.Repeat(s, n));

            return multiply;
    
    }
  }
}