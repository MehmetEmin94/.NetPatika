using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list=new ArrayList();
            list.Add("who");
            list.Add(2);
            list.Add('A');
            list.Add(true);

            Console.WriteLine(list[1]);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            string[] colors={"red","blue","violet"};
            List<int> nums=new List<int>(){1,2,5,7,4};
            list.AddRange(colors);
            list.AddRange(nums);



            //list.Sort();
            Console.WriteLine("\nBinary Search");
            Console.WriteLine(list.BinarySearch(7));

            list.Reverse();
            foreach (var item in list)
            {
               Console.WriteLine(item);
            }
            list.Clear();
        }
    }
}
