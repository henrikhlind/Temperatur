using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturIfElseWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gyldig = false;

            while (!gyldig)
            {
                Console.Write("Skriv inn en temperatur: ");
                string inn = Console.ReadLine();

                if (int.TryParse(inn, out int temp))
                {
                    switch (temp)
                    {
                        case int n when n > 0:
                            Console.WriteLine("Det er plussgrader");
                            break;
                        case int n when n < 0:
                            Console.WriteLine("Det er minusgrader");
                            break;
                        default:
                            Console.WriteLine("Det er null grader");
                            break;
                    }
                    gyldig = true;
                }
                else
                {
                    Console.WriteLine("Tallet er ikke en temperatur. Prøv på nytt.");
                }
            }

            Console.ReadKey();
        }
    }
}