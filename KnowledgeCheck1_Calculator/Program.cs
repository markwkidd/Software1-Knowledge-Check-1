using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();
            int inNumber1 = 0;
            int inNumber2 = 0;

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    if (ReadIntegers(out inNumber1, out inNumber2))
                    {
                        Console.Write($"{inNumber1} + {inNumber2} = ");
                        Console.Write(calculator.Add(inNumber1, inNumber2));
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    if (ReadIntegers(out inNumber1, out inNumber2))
                    {
                        Console.Write($"{inNumber1} - {inNumber2} = ");
                        Console.Write(calculator.Subtract(inNumber1, inNumber2));
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    if (ReadIntegers(out inNumber1, out inNumber2))
                    {
                        Console.Write($"{inNumber1} - {inNumber2} = ");
                        Console.Write(calculator.Multiply(inNumber1, inNumber2));
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide"); // the division logic uses doubles to store the numbers. should we tell the user?
                    var divideNumber1 = Console.ReadLine();
                    var divideNumber2 = Console.ReadLine();

                    if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                    {
                        Console.Write($"{divideNumber1} / {divideNumber2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int"); // should this be corrected to say double?
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }

        private static bool ReadIntegers(out int in1, out int in2)
        {
            in1 = 0;
            in2 = 0;

            if (!int.TryParse(Console.ReadLine().Trim(), out in1) || !int.TryParse(Console.ReadLine().Trim(), out in2))
            {
                Console.WriteLine("One or more of the numbers is not an int");
                return false; // error state
            }
            else
            {
                return true;
            }
        }
    }
}