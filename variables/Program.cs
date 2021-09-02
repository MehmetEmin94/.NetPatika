using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b=5;
            sbyte c=5;

            short s=5;
            ushort us=5;

            Int16 i16=2;
            int i=32;
            Int32 i32=32;
            Int64 i64=4;

            uint ui=256;
            long l=4;
            ulong ul=4;

            float f=5;
            double db=5;
            decimal dc=5;

            char ch='3';
            string str="kim";

            bool b1=true;
            bool b2=false;

            DateTime dateTime=DateTime.Now;
            Console.WriteLine(dateTime);

            object o1="ds";
            object o2=4;
            object o3=DateTime.Now;

            string str1=string.Empty;
            str1="sfvd";
            string str2="dv";
            string add=str1+str2;

            int i1=2;
            int i2=4;
            int i3=i1+i2;

            bool bl=10<2;

            string str20="20";
            int int20=20;
            string n=str20+int20.ToString();
            Console.WriteLine(n);

            int i21=int20+Convert.ToInt32(str20);
            System.Console.WriteLine(i21);

            int i22=int20+int.Parse(str20);

            string date_time=DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(date_time);

            string hour=DateTime.Now.ToString("HH :mm");
            System.Console.WriteLine(hour);

        }
    }
}
