using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_card
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] backwards = s.ToCharArray();
            Array.Reverse(backwards);
            return new string(backwards);
        }

        static void Main(string[] args)
        {
            string name, backwards, input;
            decimal numbers, i;
            bool keepGoing = true;

            decimal[] correctQuantity = new decimal[12];

            Console.Write("\nInput your full name: ");
            name = Console.ReadLine();
            backwards = ReverseString(name);
            Console.Write("Reverse name: {0}", backwards);

            do
            {
                try
                {

                    Console.Write("\nInput the number of the credit card: ");
                    input = Console.ReadLine();
                    numbers = decimal.Parse(input);
                    char[] quantity = input.ToCharArray();

                    if (quantity.Length == correctQuantity.Length)
                    {
                        Console.Write("OK");

                    }
                    else
                    {
                        Console.Write("\nQuantity of numbers incorrect.");

                    }
                    
                }
                catch (FormatException ex)
                {
                    Console.Write(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            } while (keepGoing);

            Console.ReadKey();

        }
    }
}
