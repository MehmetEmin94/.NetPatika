using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting
            int[] numArr={24,12,4,88,3,11};
            Array.Sort(numArr);

            //Clear
            Array.Clear(numArr,2,1);

            //Reverse
            Array.Reverse(numArr);

            //IndexOf
            Array.IndexOf(numArr,23);

            //Resize
            Array.Resize<int>(ref numArr,9)
        }
    }
}
