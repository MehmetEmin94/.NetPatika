using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num=int.Parse(Console.ReadLine());
            int counter=1;
            int sum=0;
            while(counter<=num){
                sum+=counter;
                counter++;
            }
            Console.WriteLine(sum/num);


            char character='a';
            while(character<'z'){
                Console.WriteLine(character);
                character++;
            }


            string[] cars={"bmw","ford","toyota"};
            foreach (var i in cars)
            {
                 Console.WriteLine(i);
            }
        }
    }
}
