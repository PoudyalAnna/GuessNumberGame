using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoGuissing
{
    class Program
    {
        //creating mehond
       
        private static int Newnum(int min, int max)
        {

            Random random = new Random();
            return random.Next(min, max);
        }


        static void Main(string[] args)
        {
            // Guissing game with method...

            while (true)
            {
                int randno = Newnum(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Hay You! Give me a number(0 to quit):");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input < randno)
                    {
                        Console.WriteLine("Low, try again.");
                        ++count;
                        continue;
                    }
                    else if (input > randno)
                    {
                        Console.WriteLine("High, try again.");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!",
                                           randno);
                        Console.WriteLine("It took you {0} {1}.\n", count,
                                           count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }
        }
    }
}
