using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace assignment6
{
    internal class Program
    {
        #region sum
        public static int sum(int x, int y)
        {
            x = 5;
            y = 6; ;
            int z = x + y;
            return z;
        }
        #endregion
        #region sum2
        public static int sum2(ref int x, ref int y)
        {
            x = 5;
            y = 6; ;
            int z = x + y;
            return z;
        } 
        #endregion
        public static void arr( int[ ]numbers )
        {
            numbers[0] = 40;
            numbers = new int[3];
            numbers[0] = 60 ;

        }
        public static void arr2( ref int[] numbers)
        {
            numbers[0] = 40;
            numbers = new int[3];
            numbers[0] = 60;

        }
        static void Main(string[] args)
        {
            #region q1
            //Explain the difference between passing (Value type parameters)
            //by value and by reference then write a suitable c# example.
            //answer : passing value type by value : take a copy from the variables so any changes happen inside the method not affect the original variables
            // passing value type by reference : take the reference (the address) of the variable value so any change will affect the orginal variable value
            //int a = 2;
            //int b = 3;
            //int result = sum( a, b);
            //Console.WriteLine(result); //11
            //Console.WriteLine(a); // 2
            //Console.WriteLine(b); // 3
            //int a2 = 2;
            //int b2 = 3;
            //int result2 = sum2(ref a2,ref b2);
            //Console.WriteLine(result); //11
            //Console.WriteLine(a2); // 5
            //Console.WriteLine(b2); // 6
            #endregion
            #region q2 
            //Explain the difference between passing (Reference type
            //parameters) by value and by reference then write a suitable c#
            //example.
            //answer passing reference by value : take a copy of the reference of the original object so any change happen in the method affect the original 
            //but if you reasssign the the refrence in the method to another object only it will point it so after that changes will not affect the caller
            ////answer passing reference by reference : take the reference it self of the original object so any change happen in the method affect the original 
            //and if you reasssign the the refrence in the method to another object both it and the caller will point to that object so any changes happen after that will affect the caller 
            int[] seq = [10, 20, 30];
            arr( seq);
            Console.WriteLine(seq[0]);
            int[] seq2 = [10, 20, 30];
            arr2( ref seq2);
            Console.WriteLine(seq2[0]);


            #endregion
        }
    }
}
