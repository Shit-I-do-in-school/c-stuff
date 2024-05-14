using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace c_DomareMedSäcket
{
    internal class arrayHandler
    {
        public double handler(string[] myArray)
        {
            double[] temp = new double[5];//definera array
            Array.Sort(myArray);//sortera array från input
            try
            {
                for (int i = 1; i < 6; i++)//i börjar på 1 för att skippa första siffra, slutar på 6 för att skippa sista siffra
                {
                    temp[i - 1] = double.Parse(myArray[i]);//omvandla till double och spara till array "temp"
                }
            }
            catch
            {
                //om man skrev något annat än tal då avlutas programmet
                Console.WriteLine("Du skrev inte ett tal");
                System.Environment.Exit(0);
            }
            double average = temp.Sum() / temp.Length;//få medelvärdet av array "temp" och spara i average
            average = Math.Round(average, 2);//avrunda till närmaste 2 decimalers
            return average;
        }
    }
}
