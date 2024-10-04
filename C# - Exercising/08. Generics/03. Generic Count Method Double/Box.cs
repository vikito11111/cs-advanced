using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Generic_Count_Method_Double
{
    public class Box<T>
        where T: IComparable
    {
        public List<T> List { get; set; }

        public Box()
        {
            List = new List<T>();
        }

        public void AddElement(T element)
        {
            List.Add(element);
        }

        public int CompareByValue(T value)
        {
            int count = 0;

            foreach (var element in List)
            {
                if (element.CompareTo(value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}