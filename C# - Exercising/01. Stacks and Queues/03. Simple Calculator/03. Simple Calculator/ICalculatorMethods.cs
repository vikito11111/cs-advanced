using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Simple_Calculator
{
    internal interface ICalculatorMethods
    {
        public int CalculateFirstIteration(string[] input, int sum, int i);

        public int Calculate(string[] input, int sum, int i);
    }
}