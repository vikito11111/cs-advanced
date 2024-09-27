using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"D:\SoftUni\SoftUni - Coding\C# Advanced\04. Streams, Files and Directories\Lab\01. Odd Lines\input.txt"))
            {
                var counter = 0;

                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();

                    if (counter % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }

                    counter++;
                }
            }

            Console.ReadLine();
        }
    }
}