using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemsConvertor
{
    public class OctalConversions
    {
        public OctalConversions() { }

        public string OctalToBin(string oct)
        {
            string binaryNumber = "";
            foreach (char digit in oct)
            {
                int decimalDigit = int.Parse(digit.ToString());
                string binaryDigit = Convert.ToString(decimalDigit, 2).PadLeft(3, '0');
                binaryNumber += binaryDigit;
                
            }
            return binaryNumber.Substring(2);
        }


        public int OctalToDec(string oct)
        {
            int decimalNumber = Convert.ToInt32(oct, 8);
            return decimalNumber;
        }

        public string OctalToHex(string oct)
        {
            // Convert octal to decimal
            int decimalNumber = Convert.ToInt32(oct, 8);

            // Convert decimal to hexadecimal
            string hexNumber = decimalNumber.ToString("X");

            return hexNumber;
        }
    }
}
