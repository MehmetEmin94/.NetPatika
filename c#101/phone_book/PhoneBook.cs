using System.Collections;
using System.Collections.Generic;

namespace phone_book
{
    public class PhoneBook{
        // public Dictionary<string,string> dictionary=new Dictionary<string,string>();
        public List<Person> arrayList=new List<Person>();

        public void bookDefault(){
            // Person p=new Person("kim","kimkim","123456");
            // Person p1=new Person("kim","kimkim","123456");
            // Person p2=new Person("kim","kimkim","123456");
            // Person p3=new Person("kim","kimkim","123456");
            //  Person p4=new Person("kim","kimkim","123456");
           
            arrayList.Add(new Person("abc","kimkim","123456"));
            arrayList.Add(new Person("abc","aabb","456789"));
            arrayList.Add(new Person("def","ccdd","789123"));
            arrayList.Add(new Person("klm","kkll","369258"));
            arrayList.Add(new Person("xyz","yyzz","741258"));
        }
        
      
    }
}