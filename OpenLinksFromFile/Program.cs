using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenLinksFromFile {
    class Program {
        static void Main(string[] args) {
            var sr = new StreamReader(@"c:\temp\xafissues.txt");
            var txt = sr.ReadToEnd();
            var list = txt.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach(var link in list) {
                if(string.IsNullOrEmpty(link)) {
                    continue;
                }
                System.Diagnostics.Process.Start(link);
                Thread.Sleep(300);
            }

        }
    }
}
