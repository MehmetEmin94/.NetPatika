using System;

namespace handling_error
{
    class Program
    {
        static void Main(string[] args)
        {
           /* try{
                Console.Write("Enter a number : ");
                int num=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num+" entered");
            }catch(Exception e){
                Console.WriteLine("Error : "+e.Message.ToString());
            }finally{
                Console.WriteLine("Operation completed .");
            }*/

            try
            {
               // int num=int.Parse(null);
               //int a=int.Parse("test");
               int num=int.Parse("2377238843843743734");
            }
            catch (ArgumentNullException ae)
            {
               Console.WriteLine("empty value > "+ae);
            }
            catch(FormatException fe){
                System.Console.WriteLine("data type is not suitable > "+fe);
            }
            catch(OverflowException oe){
                System.Console.WriteLine("Not in range > "+oe);
            }
        }
    }
}
