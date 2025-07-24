using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace assignment6
{
    internal class Program
    {
        public static int sum ( int x , int y)
        {
            x = 5;
            y = 6; ;
            int z = x + y ;
            return z;
        }
        public static int sum2(ref int x,ref int y)
        {
            x = 5;
            y = 6; ;
            int z = x + y;
            return z;
        }
        static void Main(string[] args)
        {
            #region q1
            //Explain the difference between passing (Value type parameters)
            //by value and by reference then write a suitable c# example.
            //answer : passing value type by value : take a copy from the variables so any changes happen inside the method not affect the original variables
            // passing value type by reference : take the reference (the address) of the variable value so any change will affect the orginal variable value
            int a = 2;
            int b = 3;
            int result = sum( a, b);
            Console.WriteLine(result); //11
            Console.WriteLine(a); // 2
            Console.WriteLine(b); // 3
            int a2 = 2;
            int b2 = 3;
            int result2 = sum2(ref a2,ref b2);
            Console.WriteLine(result); //11
            Console.WriteLine(a2); // 5
            Console.WriteLine(b2); // 6
            #endregion
        }
    }
}
