using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> cities = new List<string>();
            //cities.Add("Toronto");

            MyList<string> myList = new MyList<string>();
            myList.Add("Elixus");
            Console.WriteLine(myList.length);
            myList.Add("Denisel");
            Console.WriteLine(myList.length);

            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----");
            myList.ShowInfos();
        }
    }
}
