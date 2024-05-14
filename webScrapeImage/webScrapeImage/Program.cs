using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;

namespace webScrapeImage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grabber Grabber = new Grabber();
            Grabber.Grab();
            Grabber.Extractor();

            Grabber.Save();
        }
    }
}
