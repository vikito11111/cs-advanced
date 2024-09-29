using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Func<int, int> add = x => x += 1;

            Func<int, int> substract = x => x -= 1;

            Func<int, int> multiply = x => x *= 2;

            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    numbers = numbers.Select(add).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(substract).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiply).ToArray();
                }
                else if (command == "print")
                {
                    print(numbers);
                }
            }

            Console.ReadLine();
        }
    }
}