using System;
using System.Linq;

public class Kata
{
  public static bool ValidatePin(string pin)
  { 
          int length = pin.Length;  
            bool pinIsANumber = int.TryParse(pin, out int pinNumber);
             bool pinIsDigit = pin.All(Char.IsDigit);
            bool itistrue = false;
            
            
            if(pinIsANumber == true && pinIsDigit)
            {
                if (length == 4)
                {
                    itistrue = true;
                }
                if (length == 6)
                {
                    itistrue = true;
                }

            }
           
            return itistrue;
  }
}