using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string num="999";

            bool res=int.TryParse(num,out int outNum);
            if (res)
            {
                Console.WriteLine("Success");
                Console.WriteLine(outNum);
            }else
            {
                Console.WriteLine("Not Success");
                
            }
            Methods m=new Methods();
            m.Sum(4,5,out int resSum);
            Console.WriteLine(resSum);


            int k=999;
            m.WriteScreen(k);
            m.WriteScreen(k,1);
        }
    }
    class Methods{
        public void Sum(int a,int b,out int resSum){
            resSum=a+b;
        }
        public void WriteScreen(string data){
             Console.WriteLine(data);
        }
        public void WriteScreen(int data){
             Console.WriteLine(data);
        }
        public void WriteScreen(int data1,int data2){
             Console.WriteLine(data1+data2);
        }
    }
}
