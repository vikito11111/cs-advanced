using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Generic_Swap_Method_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                box.AddElement(input);
            }

            string[] indexInput = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int index1 = int.Parse(indexInput[0]);

            int index2 = int.Parse(indexInput[1]);

            box.Swap(index1, index2);

            Console.WriteLine(box.ToString());

            Console.ReadLine();
        }
    }
}