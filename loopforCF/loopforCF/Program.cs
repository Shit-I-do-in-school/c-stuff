using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopforCF//this code prints c,f and then make array and then average them
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate convertor = new calculate();//skapa objekt
            //definera variabler
            int c = -20;
            double f = convertor.bigBrainStuff(c);//f är c omvandlat till farenhite
            int[] c_array = new int[7];//7 är längd på array
            double[] f_array = new double[7];

            while (c < 50)//skriva ut tills c är 40
            {
                //skriva ut värdena
                Console.WriteLine($"celsius är {c}");
                Console.WriteLine($"farenheit är {f}");
                //lägg värdena i arrays
                c_array[c/10+2] = c;
                f_array[c /10+2] = f;
                //öka värdena
                c = c + 10;
                f = convertor.bigBrainStuff(c);
            }

            
            foreach (int item in c_array)//skriva ut c
            {
                Console.WriteLine($"C från array: {item}");
            }
            foreach (double item in f_array)//skriva ut f
            {
                Console.WriteLine($"F från array: {item}");
            }
            //summera c och f arrays för att sen få medelvärdet
            int c_sum = c_array.Sum();
            double f_sum = f_array.Sum();
            //få medelvärdet och skriva ut
            Console.WriteLine($"Medelvärdet av C: {c_sum/c_array.Length}");
            Console.WriteLine($"Medelvärdet av F: {f_sum/f_array.Length}");
        }
    }
}
