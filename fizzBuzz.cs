using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class fizzBuzz
    {
        public static void Run()
        {
            /*for (int i = 1; i <= n; i++)
            {
                switch (i % 3)
                {
                    case 0 when i % 5 == 0:
                        Console.WriteLine("FizzBuzz");
                        continue;
                    case 0:
                        Console.WriteLine("Fizz");
                        continue;
                    default:
                    {
                        if (i % 5 == 0)
                        {
                            Console.WriteLine("Buzz");
                            continue;
                        }

                        break;
                    }
                }

                Console.WriteLine(i);
            }*/
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }

                Console.WriteLine(i);

            }
        }
    }
}
