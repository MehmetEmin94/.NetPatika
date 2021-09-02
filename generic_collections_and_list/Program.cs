using System;
using System.Collections.Generic;

namespace generic_collections_and_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList=new List<int>();

            numList.Add(23);
            numList.Add(3);
            numList.Add(12);
            numList.Add(5);
            numList.Add(36);
            numList.Add(15);

            List<string> colorList=new List<string>();
            colorList.Add("red");
            colorList.Add("blue");
            colorList.Add("orange");
            colorList.Add("yellow");
            colorList.Add("green");
            
            Console.WriteLine(colorList.Count);
            Console.WriteLine(numList.Count);

            foreach (var item in numList)
            {
                Console.WriteLine(item);
            }
             foreach (var item in colorList)
            {
                Console.WriteLine(item);
            }

            numList.ForEach(num=>Console.WriteLine(num));
            numList.ForEach(color=>Console.WriteLine(color));

            numList.Remove(4);
            colorList.Remove("green");

            numList.RemoveAt(0);
            colorList.RemoveAt(1);




            if (numList.Contains(12))
            {
                Console.WriteLine("*** found ***");
            }


            Console.WriteLine(colorList.BinarySearch("yellow"));


            string[] anuimals={"cat","dog","bird"};

            List<string> animalList=new List<string>(anuimals);

            animalList.Clear();



            List<User> users=new List<User>();
            User user=new User();
            user.name="who";
            user.surname="whos";
            user.age=22;
            User user1=new User();
            user1.name="the";
            user1.surname="these";
            user1.age=75;

            users.Add(user);
            users.Add(user1);


            List<User> userlist=new List<User>();
            userlist.Add(new User(){name="aa",surname="ab",age=11});


            foreach (var item in users)
            {
                Console.WriteLine("name : "+item.name);
            }

            userlist.Clear();
        }

        public class User{
            public string name { get; set; }
            public string surname { get; set; }
            public int age { get; set; }
        }
    }
}
