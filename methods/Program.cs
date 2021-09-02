using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=3,b=6;
            Methods m=new Methods();
            
            m.WriteScreen(Convert.ToString(m.IncSum(ref a,ref b)));
            m.WriteScreen(Convert.ToString(Sum(a,b)));
        }

        static int Sum(int v1,int v2){
            return v1+v2;
        }
    }
    class Methods{
        public void WriteScreen(string data){
           Console.WriteLine(data);
        }

        public int IncSum(ref int v1,ref int v2){
            v1++;
            v2++;
            return v1+v2;
        }
    }
}
