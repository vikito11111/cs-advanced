using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Simple_Calculator
{
    public class CalculatorMethods : ICalculatorMethods
    {
        public int CalculateFirstIteration(string[] input, int sum, int i)
        {
            var operation = input[1];

            if (operation.Equals("+"))
            {
                var calculating = int.Parse(input[i - 1]) + int.Parse(input[i + 1]);
                sum += calculating;
            }
            else if (operation.Equals("-"))
            {
                var calculating = int.Parse(input[i - 1]) - int.Parse(input[i + 1]);
                sum += calculating;
            }

            return sum;
        }

        public int Calculate(string[] input, int sum, int i)
        {
            var operation = input[i];

            if (operation.Equals("+"))
            {
                sum += int.Parse(input[i + 1]);
            }
            else if (operation.Equals("-"))
            {
                sum -= int.Parse(input[i + 1]);
            }

            return sum;
        }
    }
}