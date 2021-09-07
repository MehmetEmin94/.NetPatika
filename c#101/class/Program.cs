using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors=new string[5];

            string[] animals={"horse","cat","dog"};

            int[] arr;
            arr=new int[5];

            colors[0]="blue";
            arr[3]=10;
            Console.WriteLine(animals[0]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(colors[0]);
            
            
            Console.WriteLine("Enter array length : ");
            int arrLength=int.Parse(Console.ReadLine());
            int[] array=new int[arrLength];
             for(int i=0;i<arrLength;i++){
                 Console.WriteLine("Enter {0}. number : ",i+1);
                 array[i]=int.Parse(Console.ReadLine());
             }
             int sum=0;
             foreach (var item in array)
             {
                 sum+=item;  
             }Console.WriteLine("Sum of number array : "+sum);
             Console.WriteLine("Avarage : "+sum/arrLength);

        }
    }
}
