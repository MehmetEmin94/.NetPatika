using System;
using System.Collections;

namespace collections_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence :");
            string sentence=Console.ReadLine();

            ArrayList list=new ArrayList();
            for(int i=0;i<sentence.Length;i++)
            {
                if(sentence[i]=='a'||sentence[i]=='i'||sentence[i]=='e'||sentence[i]=='o'||sentence[i]=='u')
                list.Add(sentence[i]);
            }
            list.Sort();
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
           
        }
    }
}
