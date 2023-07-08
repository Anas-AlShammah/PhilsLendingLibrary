using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> items;
        public Backpack() { 
            items= new List<T>();
        }
        public int Count => items.Count;
        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();

        }

        public void Pack(T item)
        {
            items.Add(item);
        }

        public T Unpack(int index)
        {
            var item = items[index];
            items.RemoveAt(index);
            return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
