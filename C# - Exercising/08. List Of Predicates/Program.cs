using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            List<int> numbers = Enumerable.Range(1, range).ToList();

            int[] sequenceOfDividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Predicate<int> filter = num =>
            {
                for (int i = 0; i < sequenceOfDividers.Length; i++)
                {
                    if (num % sequenceOfDividers[i] != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            var filteredNumbers = numbers.Where(x => filter(x));

            Console.WriteLine(string.Join(" ", filteredNumbers));

            Console.ReadLine();
        }
    }
}