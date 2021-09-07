namespace phone_book
{
    public class Person{
         private string name ;
        private string surname;
        private string phoneNumber;
        public Person(string Name,string Surname,string PhoneNumber){
            this.name=Name;
            this.surname=Surname;
            this.phoneNumber=PhoneNumber;
        }

        public string Name{get=>name;set=>name=value;}
        public string Surname{get=>surname;set=>surname=value;}
        public string PhoneNumber{get=>phoneNumber;set=>phoneNumber=value;}
    }
}