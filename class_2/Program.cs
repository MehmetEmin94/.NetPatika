using System;

namespace access_modifiers
{
     class Program
    {
        static void Main(string[] args)
        {
            Worker worker=new Worker();
            worker.Name="abc";
            worker.Surname="def";
            worker.No=123;
            worker.Department="klm";
            worker.WorkerInformation();
        }
    }

    class Worker{
        public string Name;

        public string Surname;

        public int No;

        public string Department;

        public Worker()
        {
            
        }
        public Worker(string Name,string Surname,int No,string Department){
            this.Name=Name;
            this.Surname=Surname;
            this.No=No;
            this.Department=Department;
        }

        public void WorkerInformation(){
            System.Console.WriteLine(Name+" "+Surname+" "+No+" "+Department);
        }
    }
}
