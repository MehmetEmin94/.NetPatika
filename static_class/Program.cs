using System;

namespace static_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Employee : {0} ",Employee.EmployeeNum);

            Employee employee=new Employee("abc","def","klm");

            Console.WriteLine("Number of Employee : {0} ",Employee.EmployeeNum);

            Console.WriteLine(Transactions.Sub(100,200)); 
        }
    }
    static class Transactions
    {
        public static long Sum(int num1,int num2){
            return num1+num2;
        }
        public static long Sub(int num1,int num2){
            return num1-num2;  
        }
    }

    class Employee
    {
        private static int employeeNum;

        public static int EmployeeNum{get=>employeeNum;set=>employeeNum=value;}

        private string name;
        private string surname;
        private string department;

        static Employee(){
            employeeNum=0;
        }

        public Employee(string name,string surname,string department){
            this.name=name;
            this.surname=surname;
            this.department=department;
            employeeNum=+1;
        }

    }
}
