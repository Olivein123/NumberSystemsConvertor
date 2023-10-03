using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NumberSystemsConvertor
{
    public class Binary_Conversions
    {
        public Binary_Conversions()
        {

        }

        public string BinaryToOct(string bin)
        {
            //Convert bin to dec
            int decimalNum = Convert.ToInt32(bin, 2);

            //Convert dec to oct
            int quotient;
            int i = 1;
            string octalNumber = "";
            int[] octal = new int[100];

            quotient = decimalNum;

            while (quotient != 0)
            {
                octal[i++] = quotient % 8;
                quotient = quotient / 8;
            }

            for (int j = i - 1; j > 0; j--)
            {
                octalNumber += octal[j];
            }
            return octalNumber;
        }

        public int BinaryToDec(string bin) { 

            //Convert binary to dec
            int decimalNum = Convert.ToInt32(bin, 2);
            return decimalNum;
        }

        public string BinaryToHex(string bin)
        {
            //Convert binary to hex
            string hexNum = Convert.ToString(Convert.ToInt32(bin, 2), 16);

            return hexNum;
        }

    }
}
