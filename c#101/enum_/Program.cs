using System;

namespace enum_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sunday);

            int degree=21;
            if (degree<=(int)Weather.Normal)
            {
                  Console.WriteLine("Wear jacket");
            }else if(degree>=(int)Weather.Normal)
            {
                 Console.WriteLine("Wear shorts");
            }
        }
    }

    enum Days
    {
        Monday,
        Tuesday,
        Thursday,
        Wednesday,
        Friday,
        Saturday,
        Sunday
    }

    enum Weather
    {
        Cold=6,
        Normal=20,
        Hot=27,
    }
}
