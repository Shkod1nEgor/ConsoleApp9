using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Collection<T>
    {
        T[] data;
        public Collection()
        {
            data = new T[0];
        }
        public void Add(T item)
        {
            T[] newData = new T[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }
            newData[data.Length] = item;
            data = newData;
        }
        public void Remove(T item)
        {
            int index = -1;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            if (index > -1)
            {
                T[] newData = new T[data.Length - 1];
                for (int i = 0, j = 0; i < data.Length; i++)
                {
                    if (i == index) continue;
                    newData[j] = data[i];
                    j++;
                }
                data = newData;
            }
        }
        public T GetItem(int index)
        {
            if (index > -1 && index < data.Length)
            {
                return data[index];
            }
            else
                throw new IndexOutOfRangeException();
        }
        public int Count()
        {
            return data.Length;
        }
    }
}