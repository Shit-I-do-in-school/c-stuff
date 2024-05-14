using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPT_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange antalet tärningar: ");
            int antalTarningar = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange antalet treor som önskas: ");
            int antalTreor = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange antalet fyror som önskas: ");
            int antalFyror = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange antalet försök att simulera: ");
            int antalForsok = int.Parse(Console.ReadLine());

            Simulering simulering = new Simulering();
            double sannolikhet = simulering.BeraknaSannolikhet(antalTarningar, antalTreor, antalFyror, antalForsok);
            Console.WriteLine($"Sannolikheten för att få minst {antalTreor} treor och minst {antalFyror} fyror när man kastar {antalTarningar} tärningar är: {sannolikhet:P2}");
        }
    }

    class Tarning
    {
        private Random rng = new Random();

        public int Kasta()
        {
            return rng.Next(1, 7);
        }
    }

    class Simulering
    {
        public double BeraknaSannolikhet(int antalTarningar, int onskadeTreor, int onskadeFyror, int antalForsok)
        {
            Tarning tarning = new Tarning();
            int lyckadeForsok = 0;

            for (int i = 0; i < antalForsok; i++)
            {
                int treor = 0;
                int fyror = 0;

                for (int j = 0; j < antalTarningar; j++)
                {
                    int result = tarning.Kasta();
                    if (result == 3) treor++;
                    if (result == 4) fyror++;
                }

                if (treor >= onskadeTreor && fyror >= onskadeFyror)
                {
                    lyckadeForsok++;
                }
            }

            return (double)lyckadeForsok / antalForsok;
        }
    }
}