using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Tuple
{
    public class Tuple<T, K>
    {
        public Tuple(T item1, K item2)
        {
            Item1 = item1;

            Item2 = item2;
        }

        public T Item1 { get; set; }

        public K Item2 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}