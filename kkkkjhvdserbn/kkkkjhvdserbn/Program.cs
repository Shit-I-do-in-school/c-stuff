using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kkkkjhvdserbn//konsonant grejen uppgift 4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter convertor = new Converter();//skapa objekt
            string inString = Console.ReadLine();//ta in string
            string newString = convertor.convert(inString);//omvandla stringet
            Console.WriteLine(newString);//skriva ut string
        }
    }
}
