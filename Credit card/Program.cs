using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_card
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            bool keepGoing = true;

            do
            {
                try
                {
                    Console.Write("\nInput your full name: ");
                    name = Console.ReadLine();


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

       

        }
    }
}
