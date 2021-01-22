using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //contructor class ilk çalıştığında devreye girer
        public MyList()
        {
            items = new T[0];   // 0 elemanlı bir dizi 
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1]; //dizinin eleman sayısını 1 arttır. new yazıldığı için önce elemanlar uçar. new den once elemanları gecici diziye kayıt ediyoruz. 
            for (int i = 0; i < tempArray.Length; i++) // gecici dizideki elemanları geri kayıt et
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;// son elemanı kayıt et
        }

        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
