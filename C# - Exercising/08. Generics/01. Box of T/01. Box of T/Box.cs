using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Box_of_T
{
    public class Box<T>
    {
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        private int Count 
        {
            get
            {
                return list.Count;
            }
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove()
        {
            if (Count <= 0)
            {
                throw new Exception("Cannot remove an element in an empty Box!");
            }
            else
            {
                T elementToRemove = list.Last();

                list.Remove(elementToRemove);

                return elementToRemove;
            }
        }
    }
}