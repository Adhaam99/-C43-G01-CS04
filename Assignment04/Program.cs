using System.Numerics;
using System.Text;
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

            //Console.Write("Enter number : ");

            //int.TryParse(Console.ReadLine(), out int num);

            //Console.Write("Enter Power : ");

            //int.TryParse(Console.ReadLine(), out int power);

            //double result = Math.Pow(num , power);

            //Console.Clear();

            //Console.WriteLine(result);

            #endregion

            #region Q5 - Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int[] Marks = new int[5];

            //Console.WriteLine("Enter Marks");

            //for (int i = 0; i < Marks.Length; )
            //{
            //    bool markParse = int.TryParse( Console.ReadLine(), out Marks[i]);

            //    if (markParse)
            //        ++i;
            //}

            //Console.WriteLine($"Total : {Marks.Sum()}");
            //Console.WriteLine($"Average : {Marks.Sum()/Marks.Length}");
            //Console.WriteLine($"Percentage : {Marks.Sum()/Marks.Length}%");

            #endregion

            #region Q6 - Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a word : ");

            //string myString = Console.ReadLine() ?? " ";

            //StringBuilder rString = new StringBuilder();

            //for ( int i = myString.Length - 1 ; i >= 0; i-- )
            //{
            //    rString.Append( myString[i] );
            //}

            //Console.WriteLine( rString );

            #endregion

            #region Q7 - Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Enter number : ");

            //int.TryParse(Console.ReadLine(), out int num);

            //Console.WriteLine( ~num );

            #endregion

            #region Q8 - Write a program in C# Sharp to find prime numbers within a range of numbers.

            Console.Write("Start number : ");

            int.TryParse(Console.ReadLine(), out int num01);

            Console.Write("End number : ");

            int.TryParse(Console.ReadLine(), out int num02);

            for (int i = num01; i < num02; i++)
            {
                if (checkPrimeNumber(i))
                    Console.WriteLine(i);
            }

            #endregion
        }

        static bool checkPrimeNumber (int num)
        {
            if (num <= 1)
                return false;
            for (int i = 2 ; i <= Math.Sqrt(num) ; i++)
            {
                if ( num % i ==0 )
                {
                    return false;
                }
            }

            return true;
        }
    }
}
