using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time=DateTime.Now.Hour;

            if (time>=6&&time<11)
            {
                Console.WriteLine("Good morning");
            }
            else if(time<=18){
                Console.WriteLine("Good days");
            }else{
                Console.WriteLine("Good night");
            }

            string result=time<=18?"Good days":"Good night";
            Console.WriteLine(result);

            result= time>=6 &&time<11?"Good morning":time<=18?"Good days":"Good night";
            Console.WriteLine(result);
        }
    }
}
