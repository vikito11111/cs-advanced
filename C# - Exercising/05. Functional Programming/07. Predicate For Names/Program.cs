using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
               .Split()
               .ToList();

            Predicate<string> filterNames = x => x.Length <= lenght;

            string[] filteredNames = names.FindAll(filterNames)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, filteredNames));

            Console.ReadLine();
        }
    }
}