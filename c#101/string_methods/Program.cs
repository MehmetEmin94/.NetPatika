using System;

namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable="Ali ata bak";
            string variable2="Ali ata ";
            //length
            Console.WriteLine(variable.Length);

            //toupper tolower
            Console.WriteLine(variable.ToLower());
            Console.WriteLine(variable.ToUpper());

            //concat
            Console.WriteLine(String.Concat(variable," merhaba"));

            //Compare, Compareto
            Console.WriteLine(variable.CompareTo(variable2));
            Console.WriteLine(String.Compare(variable,variable2,true));
            Console.WriteLine(String.Compare(variable,variable2,false));

             //startswith,endswith,Contains
            Console.WriteLine(variable.Contains(variable2));
            Console.WriteLine(variable.EndsWith("bak"));
            Console.WriteLine(variable.StartsWith("bak"));

            //indexof
            Console.WriteLine(variable.IndexOf("ata"));
            Console.WriteLine(variable.LastIndexOf("i"));
            
            
            //insert
            Console.WriteLine(variable.Insert(0,"merhaba, "));
            
            //Padleft, padright
            Console.WriteLine(variable+variable2.PadLeft(30));
            Console.WriteLine(variable+variable2.PadLeft(30,'@'));
            Console.WriteLine(variable.PadRight(50)+variable2);
            Console.WriteLine(variable.PadRight(50,'@')+variable2);

            //Remove
             Console.WriteLine(variable.Remove(10));
             Console.WriteLine(variable.Remove(5,3));

             //replace
             Console.WriteLine(variable.Replace("Ali","Veli"));
             Console.WriteLine(variable.Replace(" ","**"));

             //split
             Console.WriteLine(variable.Split(' ')[1]);

             //Substring
             Console.WriteLine(variable.Substring(4));
             Console.WriteLine(variable.Substring(4,6));
        }
    }
}
