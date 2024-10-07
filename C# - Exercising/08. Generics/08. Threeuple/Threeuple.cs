using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Threeuple
{
    public class Threeuple<T, TT, TTT>
    {
        public Threeuple(T item1, TT item2, TTT item3)
        {
            Item1 = item1;

            Item2 = item2;

            Item3 = item3;
        }

        public T Item1 { get; set; }

        public TT Item2 { get; set; }

        public TTT Item3 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}