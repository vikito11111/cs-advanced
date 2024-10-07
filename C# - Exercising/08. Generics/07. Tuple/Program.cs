using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputPersonInfo = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string fullName = inputPersonInfo[0] + " " + inputPersonInfo[1];

            string address = inputPersonInfo[2];

            Tuple<string, string> personInfo = new Tuple<string, string>(fullName, address);


            string[] inputBeerInfo = Console.ReadLine()
            .Split(' ')
            .ToArray();

            string name = inputBeerInfo[0];

            int litersOfBeer = int.Parse(inputBeerInfo[1]);

            Tuple<string, int> personBeer = new Tuple<string, int>(name, litersOfBeer);

        
            string[] inputNumberInfo = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int myInt = int.Parse(inputNumberInfo[0]);

            double myDouble = double.Parse(inputNumberInfo[1]);

            Tuple<int, double> numbersInfo = new Tuple<int, double>(myInt, myDouble);

            Console.WriteLine(personInfo.ToString());

            Console.WriteLine(personBeer.ToString());

            Console.WriteLine(numbersInfo.ToString());

            Console.ReadLine();
        }
    }
}