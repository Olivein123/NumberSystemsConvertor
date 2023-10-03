

using System.Security.Cryptography;

namespace NumberSystemsConvertor
{
    public class HexConversions
    {
        DecimalConversions helper = new DecimalConversions();
        public HexConversions(){}

        public string HexToBin(string hex)
        {
            //Convert hexadecimal to decimal
            int decimalNumber = Convert.ToInt32(hex, 16);

            //Convert decimal to binary
            string binaryNumber = Convert.ToString(decimalNumber, 2);

            return binaryNumber;
        }

        public int HexToDec(string hex)
        {
            int decimalNumber = Convert.ToInt32(hex, 16);
            return decimalNumber;
        }

        public string HexToOctal(string hex)
        {
            // Step 1: Convert hexadecimal to decimal
            int decimalNumber = Convert.ToInt32(hex, 16);

            // Step 2: Convert decimal to octal
            string octalNumber = helper.DecimalToOct(decimalNumber);

            return octalNumber;
        }
    }
}
