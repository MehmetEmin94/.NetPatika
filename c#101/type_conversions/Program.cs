using System;

namespace type_conversions
{
    class Program
    {
        static void Main(string[] args)
        {

            byte a=1;
            sbyte b=5;
            short c=6;

            int i=a+b+c;
            Console.WriteLine("integer : "+i);

            long l=i+a;
            Console.WriteLine("long : "+l);

            float f=l+a;
            Console.WriteLine("long : "+f);



            string str="kim";
            char ch='k';
            object obj=str+ch+'i';
            Console.WriteLine("string : "+obj);

            int x=4;
            byte y=(byte)x;

            float w=10.3f;
            byte v=(byte) w;
            Console.WriteLine(y+v);

            int xx=6;
            string ss=xx.ToString();
            Console.WriteLine(" > "+ss);

            string s1="15",s2="35";
            int k=Convert.ToInt32(s1+s2);
            Console.WriteLine(k);

            parseMethod();
        }

        public static void parseMethod(){
            string m="19";
            string m1="10.5";
            int rak=Int32.Parse(m);
            double d1=double.Parse(m1);
            Console.WriteLine(rak);
            Console.WriteLine(d1);
        }
    }
}
