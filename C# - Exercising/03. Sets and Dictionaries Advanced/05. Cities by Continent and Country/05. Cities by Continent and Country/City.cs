using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Cities_by_Continent_and_Country
{
    internal class City
    {
        public string Name { get; set; }

        public long Population { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}