using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace webScrapeImage
{
    internal class Grabber
    {
        string textFromWebpage;
        string filePath = @"C:\Users\22naadom\Desktop\webScrape.txt";
        string URL = "https://shit-i-do-in-school.github.io/noway.github.io/";
        string pattern = @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";

        List<string> images = new List<string>();

        public void Grab()
        {
            try
            {
                // skapar objekt av klassen webClient
                WebClient client = new WebClient();
                // ladda ner texten från en webbsida
                textFromWebpage = client.DownloadString(URL);
                
            }
            catch { }
        }

        public void Extractor()
        {
            string[] lines = textFromWebpage.Split('\n');
            foreach (string row in lines)
            {
                if (row.Contains(".png") || row.Contains(".jpg") || row.Contains(".gif") || row.Contains(".mp4") || row.Contains(".mp3"))
                {
                    Match match = Regex.Match(row, pattern, RegexOptions.IgnoreCase);
                    if (match.Success)
                    {
                        images.Add(match.Groups[2].Value);
                    }
                }
            }
        }

        public void Save()
        {
            try
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    foreach (string item in images)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch { }
        }


    }
}
