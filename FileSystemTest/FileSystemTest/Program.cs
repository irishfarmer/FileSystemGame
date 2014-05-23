using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileSystemTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int fileCount = 0;
            var d = new DirectoryInfo(@"c:\");
            foreach (var file in d.GetDirectories())
            {
                Console.WriteLine("Root directory: " + file.Name);
                var dn = new DirectoryInfo(d.Name + file.Name);
                foreach (var newfile in dn.GetDirectories())
                    Console.WriteLine("\t" + newfile.Name);
            }
            foreach (FileInfo fi in d.GetFiles())
                Console.WriteLine(fi.Name);
            Console.ReadKey();
        }
    }
}
