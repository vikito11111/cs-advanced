using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sw = new StreamWriter(@"D:\SoftUni\SoftUni - Coding\C# Advanced\04. Streams, Files and Directories\Lab\02. Line Numbers\Output.txt"))
            {
                using (var sr = new StreamReader(@"D:\SoftUni\SoftUni - Coding\C# Advanced\04. Streams, Files and Directories\Lab\02. Line Numbers\Input.txt"))
                {
                    var counter = 1;

                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();

                        sw.WriteLine($"{counter}.  {line}");

                        counter++;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}