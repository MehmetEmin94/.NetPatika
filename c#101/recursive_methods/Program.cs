using System;

namespace recursive_methods
{
    class Program
    {
        static void Main(string[] args)
        {//Recursive
           Islemler ins=new Islemler();
            Console.WriteLine(ins.Expo(3,3));


            //extensions
            string ifade="kim kim kim";
            bool res=ifade.CheckSpaces();
            Console.WriteLine(res);
            if (res)
            { 
                Console.WriteLine(ifade.RemoveSpaces());
            }

            Console.WriteLine(ifade.UpperCase());
            Console.WriteLine(ifade.LowerCase());
            int[] arr={10,2,3,5,9,4,22};
            arr.SortArray();
            arr.WriteScreen();

            int a=7;
            Console.WriteLine(a.IsEven());
           
           Console.WriteLine(ifade.GetFirstChar());
        }
    }

    public static class Extensions{

        public static string GetFirstChar(this string param){
            return param.Substring(0,1);
        }
        public static bool IsEven(this int param){
            return param%2==0;
        }

        public static void WriteScreen(this int[] param){
            foreach (var item in param)
            Console.WriteLine(item+" ");
        }
        public static int[] SortArray(this int[] param){
            
            Array.Sort(param);
            return param;
        }

        public static string LowerCase(this string param){
            
            
            return param.ToLower();
        }

        public static string UpperCase(this string param){
            
            
            return param.ToUpper();
        }
        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        }
         public static string RemoveSpaces(this string param){
            string[] arr=param.Split("");
            return string.Join("",arr);
        }
    }
    public class Islemler{
       
        public int Expo(int sayi,int us){ 
            if (us<2)
        {
            return sayi;
        }
            return Expo(sayi,us-1)*sayi;
        }
    }
}
