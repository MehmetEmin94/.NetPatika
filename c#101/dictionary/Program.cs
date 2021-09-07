using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> users=new Dictionary<int, string>();
            users.Add(10,"who");
            users.Add(11,"you");
            users.Add(12,"them");

            Console.WriteLine(users[12]);
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(users.Count);

            Console.WriteLine(users.ContainsKey(10));

            Console.WriteLine(users.ContainsValue("you"));

            users.Remove(11);
            foreach (var item in users)
            {
                Console.WriteLine(item.Value);
            }

            foreach (var item in users.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in users.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
