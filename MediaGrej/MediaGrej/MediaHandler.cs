using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace MediaGrej
{
    public abstract class MediaHandler
    {

        public List<string> media = new List<string>();
        public string FilePath = @"C:\\Users\\22naadom\\Desktop\\Media.txt";

        public abstract void AddToList(string name, string maker, int lenght);
        public abstract void Save();
        public abstract void Load();
    }

    public class Bok : MediaHandler
    {
        public override void AddToList(string name, string maker, int lenght)
        {
            media.Add($"(bok, {name}, {maker}, {lenght})");
        }

        public override void Save()
        {
            for (int i = 0; i < media.Count; i++)
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(FilePath))
                    {
                        if (media[i].Contains("(bok"))
                        {
                            sw.WriteLine(media[i]);
                        }
                    }
                }
                catch { }
            }
        }

        public override void Load()
        {
            string[] Text = File.ReadAllLines(FilePath);
            foreach (string line in Text)
            {
                media.Add(line);
            }
        }
    }
    public class Film : MediaHandler
    {
        public override void AddToList(string name, string maker, int lenght)
        {
            media.Add($"(film, {name}, {maker}, {lenght})");
        }

        public override void Save()
        {
            for (int i = 0; i < media.Count; i++)
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(FilePath))
                    {
                        if (media[i].Contains("(film"))
                        {
                            sw.WriteLine(media[i]);
                        }
                    }
                }
                catch { }
            }
        }

        public override void Load()
        {
            string[] Text = File.ReadAllLines(FilePath);
            foreach (string line in Text)
            {
                media.Add(line);
            }
        }
    }
}
