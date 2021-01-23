using System;
using System.Collections.Generic;
using System.Text;
 
namespace GenericsIntro
{
    class MyList<T>
    {
        T[] Items;

        //constructor

        public MyList()
        {
                Items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = Items;
            Items = new T[Items.Length +1];
            for (int i = 0; i <tempArray.Length; i++)
            {
                Items[i] = tempArray[i];
            }

            Items[Items.Length - 1] = item;

        }
    }
}
