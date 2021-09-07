using System.Collections;
using System;

namespace phone_book
{
    public class Menu{
       

        public void run(){
            PhoneBookManager phoneBookManager=new PhoneBookManager();
            while(true){
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(0) Cikis");
                Console.Write("Enter : ");
                int enter=int.Parse(Console.ReadLine());
                if (enter==0)
                {
                    break;
                }
                if (enter!=0&&enter!=1&&enter!=2&&enter!=3&&enter!=4&&enter!=5)
                {
                    System.Console.WriteLine("Lutfen gecerli deger giriniz !!");
                    run();
                }
                switch (enter)
                {
                    case 1:
                    phoneBookManager.save();
                    break;
                    case 2:
                    phoneBookManager.delete();
                    break;
                    case 3:
                    phoneBookManager.update();
                    break;
                    case 4:
                    phoneBookManager.list();
                    break;
                    case 5:
                     phoneBookManager.search();
                    break;
                }

                
            }
        }
    }
}