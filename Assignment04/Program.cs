using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter a number : ");

            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine(i + 1 );
            //}

            #endregion

            #region Q2 - Write a program that allows the user to insert an integer thenprint a multiplication table up to 12.

            //Console.Write("Enter a number : ");

            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{num} * {i} = {num * i}");
            //}

            #endregion

            #region Q3 - Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("Enter a number : ");

            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //}

            #endregion

            #region Q4 - Write a program that takes two integers then prints the power.

            Console.Write("Enter number : ");

            int.TryParse(Console.ReadLine(), out int num);

            Console.Write("Enter Power : ");

            int.TryParse(Console.ReadLine(), out int power);

            double result = Math.Pow(num , power);

            Console.Clear();

            Console.WriteLine(result);

            #endregion
        }
    }
}
