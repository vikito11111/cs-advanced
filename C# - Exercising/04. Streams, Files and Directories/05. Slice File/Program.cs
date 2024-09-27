using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.Slice_File
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = 4;

            var totalSize = new FileInfo(@"D:\SoftUni\SoftUni - Coding\C# Advanced\04. Streams, Files and Directories\Lab\05. Slice File\sliceMe.txt").Length;

            var sizePerFile = (int)Math.Ceiling(totalSize / (double)parts);

            using (FileStream fileReader = new FileStream(@"D:\SoftUni\SoftUni - Coding\C# Advanced\04. Streams, Files and Directories\Lab\05. Slice File\sliceMe.txt", FileMode.Open))
            {
                for (int i = 1; i <= parts; i++)
                {
                    var buffer = new byte[sizePerFile];

                    var readBytes = fileReader.Read(buffer, 0, sizePerFile);

                    using (FileStream fileWriter = new FileStream($"D:\\SoftUni\\SoftUni - Coding\\C# Advanced\\04. Streams, Files and Directories\\Lab\\05. Slice File\\file-{i}.txt", FileMode.OpenOrCreate))
                    {
                        fileWriter.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}