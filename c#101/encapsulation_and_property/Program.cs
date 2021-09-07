using System;

namespace encapsulation_and_property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student(){Name="abc",Surname="def",No=15,ClassNo=3};
            student.StudentInfo();
            student.ClassUp();
            student.StudentInfo();
        }
    }

    class Student{
        private string name;
        private string surname;
        private int no;
        private int classNo;
        public string Name{
            get{return name;}
            set{name=value;}
        }
        public string Surname{get=>surname;set=>surname=value;}

        public int No{get=>no;set=>no=value;}
        public int ClassNo{
            get=>classNo;
            set{
             if(value<1)
             {
                System.Console.WriteLine("Class can be at least 1");
                classNo=1;
             }
             else
             classNo=value;
            }
        }

        public Student(string name,string surname,int no,int classNo){
            Name=name;
            Surname=surname;
            No=no;
            ClassNo=classNo;
        }
        public Student(){}

        public void StudentInfo(){
            Console.WriteLine("*** Student Info ***");
            Console.WriteLine("Name : "+this.Name);
            Console.WriteLine("Surname : "+this.Surname);
            Console.WriteLine("No : "+this.No);
            Console.WriteLine("Class : "+this.ClassNo);
        }
        public void ClassUp(){
            this.ClassNo=this.ClassNo+1;
        }
         public void ClassDown(){
            this.ClassNo=this.ClassNo-1;
        }

    }
}
