using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=4;
            int y=5;

            y=y+2;
           Console.WriteLine(y);

            y+=1;
            Console.WriteLine(y);

            y/=2;
            Console.WriteLine(y);

            x=y*=x;
            Console.WriteLine(x);
            
            bool isSuccess=true;
            bool isCompleted=false;

            if (isCompleted&&isSuccess)
            {
                Console.WriteLine("Perfect");
            }
            if (isSuccess||isCompleted)
            {
                Console.WriteLine("great");
            }
            if (isSuccess&&!isCompleted)
            {
                Console.WriteLine("fine");
            }

            int a=3;
            int b=4;
            bool sonuc=a<b;

            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            
            int sonuc2=a*b;
            Console.WriteLine(sonuc2);
            sonuc2=a+b++;
           Console.WriteLine(sonuc2);
            int sonuc1=20%a;
            Console.WriteLine(sonuc1);

        }
    }
}
