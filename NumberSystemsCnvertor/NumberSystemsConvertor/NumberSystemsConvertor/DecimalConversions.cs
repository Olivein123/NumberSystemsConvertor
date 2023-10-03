using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemsConvertor
{
    public class DecimalConversions
    {
        public DecimalConversions() { } 

        public string DecimalToOct(int dec)
        {
            int quotient;
            int i = 1;
            string octalNumber = "";
            int[] octal = new int[100];

            quotient = dec;

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

        public string DecimalToBin(int dec)
        {
            int quotient;
            int i = 1;
            string binaryNumber = "";
            int[] binary = new int[1000];

            quotient = dec;

            while (quotient != 0)
            {
                binary[i++] = quotient % 2;
                quotient = quotient / 2;
            }

            for (int j = i - 1; j > 0; j--)
            {
                binaryNumber += binary[j];
            }

            return binaryNumber;
        }

        public string DecimalToHex(int dec)
        {
            string hexNumber = dec.ToString("X");
            return hexNumber;
        }
    }
}
