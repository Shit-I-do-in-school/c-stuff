using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryGoodAPP//convert c to f
{
    internal class Program
    {
        static void Main(string[] args)//här körs koden
        {
            Console.WriteLine("Skriv temperatur i celcius: ");//skriv ut i kosolen
            double cInput = double.Parse(Console.ReadLine());//ta in värden från konsolen

            calculate convertor = new calculate();//skapa objekten calculator med cInput som värde
            double farenhite = convertor.bigBrainStuff(cInput);//använd calculator för att omvandla c till f och spara till farenhite
            Console.WriteLine($"farenheit är {farenhite}");//skriva ut farenhite

        }
    }
}
