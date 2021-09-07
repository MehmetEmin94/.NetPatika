using System;
using System.Collections;
using System.Collections.Generic;

namespace collections_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
             List<int> list=new List<int>();
              for (int i = 0; i < 20; i++)
            {
                Console.Write("Enter a positive number : ");
                int num=int.Parse(Console.ReadLine());
                list.Add(num);
            }

             ArrayList list1=new ArrayList();
              ArrayList list2=new ArrayList();
            list.Sort();
            for (int i = 0; i < 3; i++)
            {
                list1.Add(list[i]);
            }
            

            list.Reverse();
            for (int i = 0; i < 3; i++)
            {
                list2.Add(list[i]);
            }

            int a=0;
            int b=0;

            foreach (int item in list1)
            {
                a+=item;
            }
            Console.WriteLine("Average of three smallest number : "+a/list1.Count);

            foreach (int item in list2)
            {
                b+=item;
            }
            Console.WriteLine("Average of three biggest number : "+b/list2.Count);

            System.Console.WriteLine("Sum of two average : "+(a/list1.Count+b/list2.Count));
        }
    }
}
