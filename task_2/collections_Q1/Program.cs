using System;
using System.Collections;
using System.Collections.Generic;

namespace collections_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1=new ArrayList();
            ArrayList list2=new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Enter a positive number : ");
                int num=int.Parse(Console.ReadLine());
                if (num<=0)
                {
                    Console.WriteLine("Out of place.Enter again : ");
                    num=int.Parse(Console.ReadLine());
                }
                if(isPrime(num)){
                    list2.Add(num);
                }else
                {
                    list1.Add(num);
                }
               
            }
            list1.Sort();
            Console.WriteLine("\nNon prime numbers : ");
            foreach (var item in list1)
            {
               Console.Write(item+" "); 
            }
            Console.WriteLine("\n\nprime numbers : ");
            list2.Sort();
            foreach (var item in list2)
            {
               Console.Write(item+" "); 
            }
            int x=list1.Count;
            int y=list2.Count;
            Console.WriteLine("\n\nelement number of list-1 : ");
            Console.Write(x);
            Console.WriteLine("\n\nelement number of list-2 : ");
            Console.Write(y);


            int a=0;
            int b=0;
            foreach (int item in list1)
            {
                a=a+item;
            }
            Console.WriteLine("\n\naverage of list-1 : ");
            Console.Write(a/x);
            foreach (int item in list2)
            {
                b=b+item;
            } 
            Console.WriteLine("\n\naverage of list-2 : ");
            Console.Write(b/x);
        }
         static bool isPrime(int n)
    {
        
        if (n == 1)
            return false;
  
        
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
               {
                    return false;
               }
               }
        return true;
    }
    }
}
