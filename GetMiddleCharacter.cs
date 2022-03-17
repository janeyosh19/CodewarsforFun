public class Kata
{
  public static string GetMiddle(string s)
  {
      int length = s.Length;
            int remainder = length % 2;
            string middleletters = "";
            if (remainder == 0)
            {
                 middleletters = s.Substring((length/2)-1 , 2);

            }
            else
            {
                    middleletters = s.Substring((length / 2), 1);
            }
               

            return middleletters;
  }
}