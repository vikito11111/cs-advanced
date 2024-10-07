using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Threeuple
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

            string town = string.Join(" ", inputPersonInfo.Skip(3));

            Threeuple<string, string, string> personInfo = new Threeuple<string, string, string>(fullName, address, town);


            string[] inputBeerInfo = Console.ReadLine()
            .Split(' ')
            .ToArray();

            string name = inputBeerInfo[0];

            int litersOfBeer = int.Parse(inputBeerInfo[1]);

            //bool isDrunk = inputBeerInfo[2] == "drunk" ? true : false;

            bool drunkCheck = false;

            if (inputBeerInfo[2] == "drunk")
            {
                drunkCheck = true;
            }

            Threeuple<string, int, bool> beerInfo = new Threeuple<string, int, bool>(name, litersOfBeer, drunkCheck);


            string[] bankInfoInput = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string personName = bankInfoInput[0];

            double bankBalance = double.Parse(bankInfoInput[1]);

            string bankName = bankInfoInput[2];

            Threeuple<string, double, string> bankInfo = new Threeuple<string, double, string>(personName, bankBalance, bankName);

            Console.WriteLine(personInfo);

            Console.WriteLine(beerInfo);

            Console.WriteLine(bankInfo);

            Console.ReadLine();
        }
    }
}