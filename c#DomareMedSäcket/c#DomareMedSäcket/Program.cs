using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace c_DomareMedSäcket//domare uppgiften
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arrayHandler arrayHandler = new arrayHandler();//skapa objekt
            //definera variabler
            string temp_str = "";
            string[] points = new string[7];
            Console.WriteLine("skriv in 7 domarens värde 0-10");

            //ta input 7 gånger för 7 domare
            for (int i = 0; i < 7; i++)
            {
                temp_str = Console.ReadLine();//spara input
                try
                {
                    if (int.Parse(temp_str) > 10 || int.Parse(temp_str) < 0)//kolla om input är i gränsen
                    {
                        //om inte i gränsen så skriva ut det och avsluta programmet
                        Console.WriteLine("Siffran är inte i gränsen");
                        System.Environment.Exit(0);
                    }
                }
                catch { }
                points[i] = temp_str;//om är i gränsen då spara i array
            }
            Console.WriteLine($"Medelvärdet av domarna: {arrayHandler.handler(points)}");//kalla klassen och skriva ut resultat
        }
    }
}
