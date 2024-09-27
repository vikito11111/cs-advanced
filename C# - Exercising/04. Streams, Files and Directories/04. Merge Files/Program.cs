using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sw = new StreamWriter(@"D:\SoftUni\SoftUni - Coding\C# Advanced\04. Streams, Files and Directories\Lab\04. Merge Files\FileThree.txt"))
            {
                using (var sr1 = new StreamReader(@"D:\SoftUni\SoftUni - Coding\C# Advanced\04. Streams, Files and Directories\Lab\04. Merge Files\FileOne.txt"))
                {
                    using (var sr2 = new StreamReader(@"D:\SoftUni\SoftUni - Coding\C# Advanced\04. Streams, Files and Directories\Lab\04. Merge Files\FileTwo.txt"))
                    {
                        ReadFromFileAndWriteInFile(sw, sr1);

                        ReadFromFileAndWriteInFile(sw, sr2);
                    }
                }
            }
        }

        private static void ReadFromFileAndWriteInFile(StreamWriter sw, StreamReader sr)
        {
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();

                sw.WriteLine(line);
            }
        }
    }
}