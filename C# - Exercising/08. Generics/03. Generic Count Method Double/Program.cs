using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Generic_Count_Method_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());

                box.AddElement(element);
            }

            double valueForCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.CompareByValue(valueForCompare));

            Console.ReadLine();
        }
    }
}