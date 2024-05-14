using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace filehandlerprov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\22naadom\Desktop\cancer2.txt";
            string path = @"C:\\Users\\22naadom\\Desktop\\Media.txt";
            //File.Create(path);

            /*
            List<string> media = new List<string>();
            media.Add($"(bok, 1, 2, 3)");
            media.Add($"(film, a, b, c)");

            for (int i = 0; i < media.Count; i++)
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        if (media[i].Contains("(bok"))
                        {
                            sw.WriteLine(media[i]);
                        }
                    }
                }
                catch { }
            }*/

            string[] Text = File.ReadAllLines(path);
            foreach (string line in Text)
            {
                Console.WriteLine(line);
            }

            /*
            string[] lines = File.ReadAllLines(path);

            foreach (string value in lines)
            {
                Console.WriteLine(value);
            }*/
        }
    }
}
