using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filhantering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NuhuhGetter getter = new NuhuhGetter("C:/Users/22naadom/Desktop/myText.txt");

            for (int i = 0; i < 1000; i++)
            {
                getter.addLine("\nretard");
            }
            
            Console.WriteLine(getter.Fetch());
        }
    }
}
