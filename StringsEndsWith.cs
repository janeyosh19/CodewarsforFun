using System;
public class Kata
{
  public static bool Solution(string str, string ending)
  {
    bool str1 = false;
            bool endingempty = string.IsNullOrEmpty(ending);
            if (endingempty == true)
            {
                ending = str;
            }

            string str2 = str.Substring(Math.Max(0, str.Length - 1));
            string ending1 = ending.Substring(ending.Length - 1);

            if (str1 = str.Contains(ending) == true && str2 == ending1)
            {
                str1 = true;
            }

            return str1;
  }
