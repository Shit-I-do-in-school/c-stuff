using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filhantering
{
    internal class NuhuhGetter
    {
        private string path;

        public NuhuhGetter(string path)
        {
            this.path = path;
        }

        public string Fetch()
        {
            string text = "";

            try
            {
                text = File.ReadAllText(path);
            }
            catch { }
            
            return text;
        }

        public void addLine(string line)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(line);
                }
            }
            catch {}
        }
    }
}
