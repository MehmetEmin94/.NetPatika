using System;
using System.Collections;

namespace phone_book
{
    public class PhoneBookManager : IPhoneBookService
    {
        PhoneBook phoneBook=new PhoneBook();
        public PhoneBookManager(){
        
        phoneBook.bookDefault();
        }
        
        public void delete()
        {
            Person p=null;
            Console.Write(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz :");
            string entry=Console.ReadLine().ToUpper();
            foreach(Person person in phoneBook.arrayList){

                if (person.Name.ToUpper().Equals(entry)||person.Surname.ToUpper().Equals(entry))
                {
                    p=person;
                    break;
                }
            }
            if (p==null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int select=int.Parse(Console.ReadLine());
                if (select==1)
                {
                    return;
                }else if(select==2){
                    delete();
                }else{
                return;
            }
            }else{
                Console.WriteLine(p.Name+" isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string select=Console.ReadLine().ToUpper();
                if (select.Equals("Y"))
                {
                    phoneBook.arrayList.Remove(p);
                }else if (select.Equals("N"))
                {
                    return;
                }else{
                delete();
            }
            }
            
        }

        public void list()
        {
            foreach (Person item in phoneBook.arrayList)
            {
                Console.WriteLine("Telefon Rehberi"+"\n***********************************\n");
                Console.WriteLine("Isim : "+item.Name+"\nSoyisim : "+item.Surname+"\nTelefon Numarasi : "+item.PhoneNumber);
            }
            
        }

        public void save()
        {
            Console.Write(" Lütfen isim giriniz             :");
            string name=Console.ReadLine();
            Console.Write(" Lütfen soyisim giriniz          :");
            string surname=Console.ReadLine();
            Console.Write(" Lütfen telefon numarası giriniz :");
            string num=Console.ReadLine();
            phoneBook.arrayList.Add(new Person(name,surname,num));
        }

        public void search()
        {
            Person p=null;
            Console.Write("**********************************************\nİsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için: (2)");
            int select=int.Parse(Console.ReadLine());
            if (select==1)
            {
                Console.Write(" Lütfen bulmak istediğiniz kişinin adını ya da soyadını giriniz :");
                string entry=Console.ReadLine().ToUpper();
                 foreach(Person person in phoneBook.arrayList){

                if (person.Name.ToUpper().Equals(entry)||person.Surname.ToUpper().Equals(entry))
                {
                    p=person;
                    break;
                }
                }
            }else if (select==2)
            {
                Console.Write(" Lütfen bulmak istediğiniz kişinin telefon numarasini giriniz :");
                string entry=Console.ReadLine();
                foreach(Person person in phoneBook.arrayList){

                if (person.PhoneNumber.Equals(entry))
                {
                    p=person;
                    break;
                }
                }
                
            }else{
                return;
            }
            Console.WriteLine("Isim : "+p.Name+"\nSoyisim : "+p.Surname+"\nTelefon Numarasi : "+p.PhoneNumber);
        }

        public void update()
        {
            Person p=null;
            Console.Write(" Lütfen guncellemek istediğiniz kişinin adını ya da soyadını giriniz :");
            string entry=Console.ReadLine().ToUpper();
            foreach(Person person in phoneBook.arrayList){

                if (person.Name.ToUpper().Equals(entry)||person.Surname.ToUpper().Equals(entry))
                {
                    p=person;
                    break;
                }
            }
            if (p==null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int select=int.Parse(Console.ReadLine());
                if (select==1)
                {
                    return;
                }else if(select==2){
                    delete();
                }else{
                return;
            }
            }else{
                 Console.WriteLine("Yeni numara : ");
                 string select=Console.ReadLine();
                 var index= phoneBook.arrayList.FindIndex(c=>c.PhoneNumber==p.PhoneNumber);
                 phoneBook.arrayList[index].PhoneNumber=select;
                
            }
        }
    }
}