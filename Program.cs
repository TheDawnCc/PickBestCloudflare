using PSHostsFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickBestCloudflare
{
    internal class Program
    {
        const string urlPath = "urls.txt";
        
        static void Main(string[] args)
        {
            var urls = File.ReadAllLines(urlPath);

            foreach (var url in urls)
            {
                var record = HostsFile.Get(url);
                Console.WriteLine(record);
            }
        }
    }
}
