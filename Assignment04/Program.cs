using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            Console.Write("Enter as number : ");

            int.TryParse(Console.ReadLine(), out int num);

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + 1 );
            }

            #endregion

            #region Q2 - Write a program that allows the user to insert an integer thenprint a multiplication table up to 12.



            #endregion
        }
    }
}
