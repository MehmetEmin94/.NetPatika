using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value : ");
            int counter=int.Parse(Console.ReadLine());
           /* for (int i = 1; i < counter; i++)
            {
                if (i%2==1)
                {
                  Console.WriteLine(i);
                }
            }*/


            // int evenSum=0;
            // int oddSum=0;
            // for (int i = 1; i <= counter; i++)
            // {
            //     if (i%2==1)
            //     {
            //         oddSum+=i;
            //     }else{
            //         evenSum+=i;
            //     }
            // }
            // Console.WriteLine(oddSum);
            // Console.WriteLine(evenSum);
            for (int i = 1; i < counter; i++)
            {
                if (i==2)
                {
                    continue;
                }
                if (i==4)
                {Console.WriteLine(2*i);
                    break;
                }Console.WriteLine(i);
            }
        }
    }
}
