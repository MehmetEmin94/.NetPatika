﻿using System;
namespace todo_app
{
    public class ConsoleApp{
        
        public void Run(){
            while(true){
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)\n" +
                                  "*******************************************\n" +
                                  "(1) Board Listelemek/n" +
                                  "(2) Board'a Kart Eklemek\n" +
                                  "(3) Board'dan Kart Silmek\n" +
                                  "(4) Kart Taşımak\n" +
                                  "(5) Cikis");
                int select = int.Parse(Console.ReadLine());
                
                if (select == 5)
                {
                    return false;
                }

                switch (select)
                {
                    case 1 :
                        break;
                    case 2 :
                        break;
                    case 3 :
                        break;
                    case 4 :
                        break;
                    default:
                        Console.WriteLine("Lutfen gecerli deger giriniz !!")
                }

                

            }
        }
    }
}