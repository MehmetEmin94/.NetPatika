using System;
using System.Collections.Generic;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // article - 1
            /*Console.Write("Enter a how many number you will enter : ");
            int howMany=int.Parse(Console.ReadLine());
            List<int> list=new List<int>();
            for (int i = 0; i < howMany; i++)
            {
                 Console.Write("Enter a positive number : ");
                 int positiveNum=int.Parse(Console.ReadLine());
                 if (positiveNum%2==0)
                 {
                     list.Add(positiveNum);
                 }
            }
            foreach (var item in list)
            Console.Write(item+" ");*/

            // article - 2
            /*Console.WriteLine("Enter two positive number in turns : ");
            Console.Write("First number : ");
            int n=int.Parse(Console.ReadLine());
            Console.Write("Second number : ");
            int m=int.Parse(Console.ReadLine());
            List<int> list=new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a positive number : ");
                 int positiveNum=int.Parse(Console.ReadLine());
                 if (positiveNum%m==0||positiveNum==m)
                 {
                     list.Add(positiveNum);
                 }
            } 
            foreach (var item in list)
            Console.Write(item+" ");*/

            // article - 3
           /* Console.Write("Enter a how many word you will enter : ");
            int howMany=int.Parse(Console.ReadLine());
            List<string> list=new List<string>();
            for (int i = 0; i < howMany; i++)
            {
                Console.Write("Enter a word : ");
                 string word=Console.ReadLine();
                 list.Add(word);
            }
            list.Reverse();
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }*/


            // article - 4
            Console.Write("Enter a sentence : ");
            string sentence=Console.ReadLine();
            int k=1;
            int h=0;
            foreach (var item in sentence)
            {
                if (item.ToString().Equals(" "))
                {
                    k++;
                }
                if (!item.ToString().Equals(" "))
                {
                    h++;
                }
            }
            Console.WriteLine("Letters : "+h);
            Console.WriteLine("Words : "+k);
        }
    }
}
