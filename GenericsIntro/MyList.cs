using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<Type> //Generic Class
    {
        Type[] items;
        //constructer
        public MyList()
        {
            items = new Type[0];
        }

        public void Add(Type item)
        {
            Type[] tempArray = items;
            items = new Type[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int length
        {
            get { return items.Length; }
        }
        public Type[] Items
        {
            get { return items; }

        }
        public void ShowInfos()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(i+" "+items[i]);
            }
        }

    }
}
