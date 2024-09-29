﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int numberToDivide = int.Parse(Console.ReadLine());

            Predicate<int> filter = num => num % numberToDivide != 0;

            List<int> filterednumber = numbers.FindAll(filter);

            Console.WriteLine(string.Join(" ", filterednumber.ToArray().Reverse()));

            Console.ReadLine();
        }
    }
}