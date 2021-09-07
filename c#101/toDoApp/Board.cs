using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoApp
{
    public class Board
    {
        private TeamMember teamMember = new TeamMember();
        
        private List<Card> todo = new List<Card>();
        private List<Card> inProgress=new List<Card>();
        private List<Card> done = new List<Card>();



        //********************************************************************************************************************



        public void addCard()
        {
            Console.Write("Başlık Giriniz                                  :");
            string header = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  :");
            string content = Console.ReadLine();
            Size size1=Size.XS;
            int a = 0;
            while (a==0)
            {
                Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
                int size = int.Parse(Console.ReadLine());
                if (size <= 5 && size >= 1)
                {
                    size1= size == 1 ? Size.XS :
                size == 2 ? Size.S :
                size == 3 ? Size.M :
                size == 4 ? Size.L : Size.XL;
                    a++;
                } 
                
            }
            
            Console.Write("Kişi Seçiniz                                    :");
            int person = int.Parse(Console.ReadLine());
            if (teamMember.Team.ContainsKey(person))
            {
                todo.Add(new Card(header,content,person,size1));
            }
            else
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
            }
            
            
        }




        //********************************************************************************************************************





        private void toDo()
        {
            Console.WriteLine("TODO Line\n"+
                              "************************");
            foreach (var i in todo)
            { 
                Console.WriteLine("Başlık      :"+i.Header+ "\nİçerik      :"+i.Content
                                + "\nAtanan Kişi :"+teamMember.Team.GetValueOrDefault(i.PersonId)+"\nBüyüklük    :"+i.Sz+"\n\n");
            }
        }
        private void inProgressLine()
        {
            Console.WriteLine("IN PROGRESS Line\n" +
                              "************************");
            foreach (var i in inProgress)
            {
                Console.WriteLine("Başlık      :" + i.Header + "\nİçerik      :" + i.Content
                                  + "\nAtanan Kişi :" + teamMember.Team.GetValueOrDefault(i.PersonId) + "\nBüyüklük    :" + i.Sz + "\n\n");
            }
        }
        private void doneLine()
        {
            Console.WriteLine("DONE Line\n" +
                              "************************");
            foreach (var i in done)
            {
                Console.WriteLine("Başlık      :" + i.Header + "\nİçerik      :" + i.Content
                                  + "\nAtanan Kişi :" + teamMember.Team.GetValueOrDefault(i.PersonId) + "\nBüyüklük    :" + i.Sz + "\n\n");
            }
        }


        //********************************************************************************************************************



        public void listBoard()
        {
            toDo();
            Console.WriteLine("\n\n");
            inProgressLine();
            Console.WriteLine("\n\n");
            doneLine();
        }


        //********************************************************************************************************************




        public void deleteCard(string input)
        {

            
                if (find(todo, input) == 0 && find(inProgress, input) == 0 &&
                    find(done, input) == 0)
                {
                    int s = 0;
                    int k = 0;
                    while (k==0)
                    {
                        Console.WriteLine(
                            "Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n" +
                            "* Silmeyi sonlandırmak için : (1)\n" +
                            "* Yeniden denemek için : (2)");
                        
                            s = int.Parse(Console.ReadLine());

                        if (s == 2 || s == 1) 
                        {
                            k++;
                        }else{Console.WriteLine("Gecerli islem seciniz !");}
                        
                    }

                    if (s == 2)
                        {
                            Console.WriteLine("* Silme islemi basarili ");
                            deleteCard(input);
                        }
                    
                }
                else
                {
                    if (find(todo,input)!=0)
                    {
                        todo.RemoveAt(todo.IndexOf(todo[find(todo, input)-1]));
                    }
                    else if (find(inProgress, input) != 0)
                    {
                        inProgress.RemoveAt(inProgress.IndexOf(inProgress[find(inProgress, input)-1]));
                    }
                    else if (find(done, input) != 0)
                    {
                        done.RemoveAt(done.IndexOf(done[find(done, input)-1]));
                    }
            }
            
        }


        //********************************************************************************************************************





        public int find(List<Card> list, string input)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (input.Equals(list[i].Header.ToLowerInvariant()))
                {
                    return i+1;
                }
            }
            return 0;
        }


        //********************************************************************************************************************




        public void moveCard(string input)
        {
            Card copyCard = null;
            if (find(todo, input) != 0)
            {
                copyCard = whichList(todo, input, "todo");
                deleteCard(input);
            }else if (find(inProgress, input) != 0)
            {
                copyCard = whichList(inProgress, input, "inProgress");
                deleteCard(input);
            }
            else if (find(done, input) != 0)
            {
                copyCard = whichList(done, input, "done");
                deleteCard(input);
            }

            Console.WriteLine("\n\nLütfen taşımak istediğiniz Line'ı seçiniz:\n" +
                      "(1) TODO\n" +
                      "(2) IN PROGRESS\n" +
                      "(3) DONE");

            int select = int.Parse(Console.ReadLine());

            if (select == 1)
            {
                todo.Add(copyCard);
            }
            else if (select == 2)
            {
                inProgress.Add(copyCard);
            }
            else if (select == 3)
            {
                done.Add(copyCard);
            }
            else
            {
                Console.WriteLine("Hatalı bir seçim yaptınız!");

            }

        }

        //********************************************************************************************************************




        public Card whichList(List<Card> list,string input,string listName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Header.Equals(input))
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:\n" +
                                      "**************************************\n" +
                                      "Başlık      :" + list[i].Header +
                                      "\nİçerik      :" + list[i].Content +
                                      "\nAtanan Kişi :" + teamMember.Team.GetValueOrDefault(list[i].PersonId) +
                                      "\nBüyüklük    :" + list[i].Sz +
                                      "\nLine        :" + listName);
                    return list[i];
                }
            }
            return null;
        }



    }
}
