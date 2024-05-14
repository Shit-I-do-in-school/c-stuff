using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySMartCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool state = true;
            while (state) {
                doSmartCalculations smrt = new doSmartCalculations();
                Console.WriteLine("Tryck A för plusa");
                Console.WriteLine("Tryck B för minusa");
                Console.WriteLine("Tryck C för gångra");
                Console.WriteLine("Tryck D för dela");
                Console.WriteLine("Tryck E för att avsluta");
                string input = Console.ReadLine().ToLower();
                if (input == "e")
                {
                    state = false;
                }
                else {

                    Console.WriteLine("Tal1: ");
                    double tal1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Tal2: ");
                    double tal2 = double.Parse(Console.ReadLine());

                    if (input == "a")
                    {
                        Console.WriteLine("Summan av +: " + smrt.plusa(tal1, tal2));
                    }
                    else if (input == "b")
                    {
                        Console.WriteLine("Summan av -: " + smrt.minusa(tal1, tal2));
                    }
                    else if (input == "c")
                    {
                        Console.WriteLine("Produkt av *: " + smrt.gångra(tal1, tal2));
                    }
                    else if (input == "d")
                    {
                        Console.WriteLine("Produkt av /: " + smrt.dela(tal1, tal2));
                    }
                }
            }
        }
    }
}
