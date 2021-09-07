using System;

namespace interfaces_
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus=new Focus();
            Console.WriteLine(focus.WhichBrand().ToString());
            Console.WriteLine(focus.WheelNum());
            Console.WriteLine(focus.StandartColor().ToString());

            Civic civic=new Civic();
            Console.WriteLine(civic.WhichBrand().ToString());
            Console.WriteLine(civic.WheelNum());
            Console.WriteLine(civic.StandartColor().ToString());


            Corolla corolla=new Corolla();
            Console.WriteLine(corolla.WhichBrand().ToString());
            Console.WriteLine(corolla.WheelNum());
            Console.WriteLine(corolla.StandartColor().ToString());
        }
    }
}
