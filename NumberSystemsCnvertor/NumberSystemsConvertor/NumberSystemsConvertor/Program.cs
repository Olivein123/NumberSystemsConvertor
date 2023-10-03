
using NumberSystemsConvertor;

//Complete
Binary_Conversions binaryConvertor = new Binary_Conversions();

//Complete
DecimalConversions decimalConvertor = new DecimalConversions();

//Complate
OctalConversions octalConvertor = new OctalConversions();

//Complete
HexConversions hexConvertor = new HexConversions();

bool flag = true;
string firstChoice = "";
string secondChoice = "";
string result = "";


do
{
    Console.WriteLine("Please choose a number system");
    Console.WriteLine("1: Binary \n2: Decimal \n3: Hexadecimal \n4: Octal");
    int choice1 = Convert.ToInt32(Console.ReadLine());

    switch (choice1)
    {
        case 1:
            Console.WriteLine("You chose Binary.");
            firstChoice = "Binary";
            break;
        case 2:
            Console.WriteLine("You chose Decimal.");
            firstChoice = "Decimal";
            break;
        case 3:
            Console.WriteLine("You chose Hexadecimal.");
            firstChoice = "Hexadecimal";
            break;
        case 4:
            Console.WriteLine("You chose Octal.");
            firstChoice = "Octal";
            break;
    }

    Console.WriteLine("Please choose a number system to convert to ");
    Console.WriteLine("1: Binary \n2: Decimal \n3: Hexadecimal \n4: Octal");
    int choice2 = Convert.ToInt32(Console.ReadLine());

    switch (choice2)
    {
        case 1:
            Console.WriteLine("You chose Binary.");
            secondChoice = "Binary";
            break;
        case 2:
            Console.WriteLine("You chose Decimal.");
            secondChoice = "Decimal";
            break;
        case 3:
            Console.WriteLine("You chose Hexadecimal.");
            secondChoice = "Hexadecimal";
            break;
        case 4:
            Console.WriteLine("You chose Octal.");
            secondChoice = "Octal";
            break;
    }

    Console.WriteLine("Please enter " + firstChoice + " number to convert to " + secondChoice);
    var input = Console.ReadLine();
    

    switch (choice1)
    {                                                                                    
        //binary conversions                                                                                                      */
        case 1:
            if (choice2 == 1)
            {
                Console.WriteLine("Cannot convert same type");
                break;
            }
            else if (choice2 == 2)
            {
                //binary to decimal
                binaryConvertor.BinaryToDec(input);
                break;
            }
            else if (choice2 == 3)
            {
                //binary to hex
                binaryConvertor.BinaryToHex(input);
                break;
            }
            else
            {
                //binary to octal
                binaryConvertor.BinaryToOct(input);
                break;
            }
        //decimal conversions
        case 2:
            if (choice2 == 1)
            {
                //decimal to binary
                decimalConvertor.DecimalToBin(Convert.ToInt32(input));
                break;
            }
            else if (choice2 == 2)
            {
                Console.WriteLine("Cannot convert same type");
                break;
            }
            else if (choice2 == 3)
            {
                //decimal to hex
                decimalConvertor.DecimalToHex(Convert.ToInt32(input));
                break;
            }
            else
            {
                //decimal to oct
                decimalConvertor.DecimalToOct(Convert.ToInt32(input));
                break;
            }

            break;
    }

    Console.WriteLine("The " + firstChoice + " representation of the " + secondChoice + " number " + input + " is: " + result);
    break;

} while (flag == true);



