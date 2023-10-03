
using NumberSystemsConvertor;
using System;

//Complete
Binary_Conversions binaryConvertor = new Binary_Conversions();

//Complete
DecimalConversions decimalConvertor = new DecimalConversions();

//Complate
OctalConversions octalConvertor = new OctalConversions();

//Complete
HexConversions hexConvertor = new HexConversions();

int flag = 1;
string firstChoice = "";
string secondChoice = "";
string result = "";


do
{   
    Console.WriteLine("Please choose a number system");
    Console.WriteLine("1: Binary \n2: Decimal \n3: Hexadecimal \n4: Octal");
    int choice1 = Convert.ToInt32(Console.ReadLine());

    try
    {
        switch (choice1)
        {
            case 1:
                Console.WriteLine("You chose Binary.\n");
                firstChoice = "Binary";
                break;
            case 2:
                Console.WriteLine("You chose Decimal.\n");
                firstChoice = "Decimal";
                break;
            case 3:
                Console.WriteLine("You chose Hexadecimal.\n");
                firstChoice = "Hexadecimal";
                break;
            case 4:
                Console.WriteLine("You chose Octal.\n");
                firstChoice = "Octal";
                break;
            default:
                Console.WriteLine("Invalid input\n");
                flag = 0;
                break;
        }

        if(flag == 0)
        {
            break;
        }

        Console.WriteLine("Please choose a number system to convert to ");
        Console.WriteLine("1: Binary \n2: Decimal \n3: Hexadecimal \n4: Octal");
        int choice2 = Convert.ToInt32(Console.ReadLine());

        switch (choice2)
        {
            case 1:
                if(choice1 == 1)
                {
                    Console.WriteLine("Cannot convert same type\n");
                    flag = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("You chose Binary.\n");
                    secondChoice = "Binary";
                    break;
                }
                            
            case 2:
                if (choice1 == 2)
                {
                    Console.WriteLine("Cannot convert same type\n");
                    flag = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("You chose Decimal.\n");
                    secondChoice = "Decimal";
                    break;
                }
       
            case 3:
                if (choice1 == 3)
                {
                    Console.WriteLine("Cannot convert same type\n");
                    flag = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("You chose Hexadecimal.\n");
                    secondChoice = "Hexadecimal";
                    break;
                }
                    
            case 4:
                if (choice1 == 4)
                {
                    Console.WriteLine("Cannot convert same type\n");
                    flag = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("You chose Octal.\n");
                    secondChoice = "Octal";
                    break;
                }
                  
            default:
                Console.WriteLine("Input error\n");
                flag = 0;
                break;
        }

        if (flag == 0)
        {
            break;
        }

        Console.WriteLine("Please enter " + firstChoice + " number to convert to " + secondChoice + "\n");
        try
        {
            var input = Console.ReadLine();




            switch (choice1)
            {
                //binary conversions                                                                                                      */
                case 1:
                    if (choice2 == 1)
                    {
                        Console.WriteLine("Cannot convert same type\n");
                        break;
                    }
                    else if (choice2 == 2)
                    {
                        //binary to decimal
                        result = Convert.ToString(binaryConvertor.BinaryToDec(input));
                        break;
                    }
                    else if (choice2 == 3)
                    {
                        //binary to hex
                        result = binaryConvertor.BinaryToHex(input);
                        break;
                    }
                    else
                    {
                        //binary to octal
                        result = binaryConvertor.BinaryToOct(input);
                        break;
                    }

                //decimal conversions
                case 2:
                    if (choice2 == 1)
                    {
                        //decimal to binary
                        result = decimalConvertor.DecimalToBin(Convert.ToInt32(input));
                        break;
                    }
                    else if (choice2 == 2)
                    {
                        Console.WriteLine("Cannot convert same type\n");
                        break;
                    }
                    else if (choice2 == 3)
                    {
                        //decimal to hex
                        result = decimalConvertor.DecimalToHex(Convert.ToInt32(input));
                        break;
                    }
                    else
                    {
                        //decimal to oct
                        result = decimalConvertor.DecimalToOct(Convert.ToInt32(input));
                        break;
                    }

                //hexadecimal conversions
                case 3:
                    if (choice2 == 1)
                    {
                        //hexadecimal to binary
                        result = hexConvertor.HexToBin(input);
                        break;
                    }
                    else if (choice2 == 2)
                    {
                        //hex to dec 
                        result = Convert.ToString(hexConvertor.HexToDec(input));
                        break;
                    }
                    else if (choice2 == 3)
                    {
                        //same conversion
                        Console.WriteLine("Cannot convert same type\n");
                        break;
                    }
                    else
                    {
                        //hexadecimal to oct
                        result = decimalConvertor.DecimalToOct(Convert.ToInt32(input));
                        break;
                    }

                //octal conversions
                case 4:
                    if (choice2 == 1)
                    {
                        //octal to binary
                        result = octalConvertor.OctalToBin(input);
                        break;
                    }
                    else if (choice2 == 2)
                    {
                        //octal to dec 
                        result = Convert.ToString(octalConvertor.OctalToDec(input));
                        break;
                    }
                    else if (choice2 == 3)
                    {
                        //octal to hex
                        result = octalConvertor.OctalToHex(input);
                        break;
                    }
                    else
                    {
                        //same conversion
                        Console.WriteLine("Cannot convert same type\n");
                        break;
                    }
                default:
                    Console.WriteLine("Input error\n");
                    flag = 0;
                    break;
            }

            Console.WriteLine("The " + secondChoice + " representation of the " + firstChoice + " number " + input + " is: " + result + "\n");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Convert again? \nY \nN");
        string choice3 = Console.ReadLine();

        if (choice3 == "Y" || choice3 == "yes" || choice3 == "Yes" || choice3 == "y")
        {
            flag = 1;
        }
        else
        {
            flag = 0;
        }
        

    }
    catch (Exception ex) { Console.WriteLine(ex.Message); }
    
} while (flag != 0 );



