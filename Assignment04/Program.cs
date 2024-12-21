using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
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

            //double result = Math.Pow(num, power);

            int Result = 1;

            for (int i = 0; i < power; i++)
            {
                Result = Result * num;
            }

            Console.Clear();

            Console.WriteLine(Result);

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

            //Console.Write("Start number : ");

            //int.TryParse(Console.ReadLine(), out int num01);

            //Console.Write("End number : ");

            //int.TryParse(Console.ReadLine(), out int num02);

            //for (int i = num01; i < num02; i++)
            //{


            //    bool flag = true;

            //    if ( i <= 1)
            //        flag = false;
            //    for (int j = 2 ; j <= Math.Sqrt(i); j++)
            //    {
            //        if ( i % j == 0)
            //            flag = false;
            //    }

            //    if ( flag )
            //        Console.WriteLine(i);
            //}

            #endregion

            #region Q9 - Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter a number to convert : ");

            //int.TryParse(Console.ReadLine(), out int num);

            //StringBuilder binary = new StringBuilder();

            //if (num == 0)
            //{
            //    Console.WriteLine("0000");
            //}
            //else
            //{
            //    while (num > 0)
            //    {
            //        binary.Append(num % 2);
            //        num /= 2;
            //    }
            //}

            //Console.WriteLine(binary);


            #endregion

            #region Q10 - Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line

            //int[,] points = new int[3, 2];

            //for (int i = 0; i < points.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter point {i + 1}");

            //    for (int j = 0; j < points.GetLength(1); )
            //    {
            //        bool numParse = int.TryParse(Console.ReadLine(), out points[i, j]);

            //        if (numParse)
            //            ++j;
            //    }
            //}

            //if (points[0,0] == points[1,0] && points[0, 0] == points[2, 0] && points[0, 1] == points[1, 1] && points[0, 1] == points[2, 1]  )
            //{
            //    Console.WriteLine("Three points is in the same straight line");
            //}
            //else
            //{
            //    Console.WriteLine("Three points isn't in the same straight line");
            //}

            #endregion

            #region Q11 - Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n* n.

            //Console.Write("Enter a number : ");

            //int.TryParse(Console.ReadLine(), out int num);

            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Q12 - Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] arr = { 1, 2, 3, 4, 5, };

            //double arrSum = arr.Sum();

            //Console.WriteLine($"Sum is : {arrSum}");

            #endregion

            #region Q13 - Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] arr01 = { 1, 2, 3, 4, 5, };
            //int[] arr02 = { 10, 20, 30, 40, 50 };

            //int[] mergedArray = new int[arr01.Length * 2];

            //int i = 0 , j = 0 , k = 0;

            //while ( i < arr01.Length && j < arr02.Length)
            //{
            //    if ( arr01[i] < arr02[j] )
            //        mergedArray[k++] = arr01[i++];
            //    else
            //        mergedArray[k++] = arr02[j++];
            //}

            //while (j < arr02.Length)
            //    mergedArray[k++] ^= arr02[j++];

            //foreach (int item in mergedArray )
            //    Console.WriteLine( item  );

            #endregion

            #region Q14 - Write a program in C# Sharp to count the frequency of each element of an array

            //int[] arr01 = { 1, 2, 1, 2, 3, 4, 4 };
            //bool[] used = new bool[arr01.Length];

            //for (int i = 0; i < arr01.Length; i++)
            //{

            //    if (used[i])
            //        continue;

            //    int count = 0;

            //    for (int j = 0; j < arr01.Length; j++)

            //    {

            //        if (arr01[i] == arr01[j])
            //        {
            //            count++;

            //            used[j] = true;

            //        }
            //    }

            //    Console.WriteLine($"Item {arr01[i]} Repeated {count} times");
            //}


            #endregion

            #region Q15 - Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] arr = { 1, 2, 3, 4, 5, };

            //int max = arr[0];
            //int min = arr[0];

            //for (int i = 0; i < arr.Length; i++)
            //{

            //    if (arr[i] > max)
            //        max = arr[i];

            //    if (arr[i] < min)
            //        min = arr[i];

            //}

            //Console.WriteLine(max);
            //Console.WriteLine(min);

            #endregion

            #region Q16 - Write a program in C# Sharp to find the second largest element in an array.

            //int[] arr = { 1, 2, 3, 4, 5, };

            //int max = int.MinValue;
            //int secondMax = int.MinValue;

            //for (int i = 0; i < arr.Length; i++)
            //{

            //    if (arr[i] > max)
            //    {
            //        secondMax = max;
            //        max = arr[i];
            //    }
            //    else if (arr[i] > secondMax && arr[i] != max)
            //    {
            //        secondMax = arr[i];
            //    }

            //}

            //Console.WriteLine($"Second largest element is {secondMax}");

            #endregion

            #region Q17 - Consider an Array of Integer values with size N, having values as in this Example



            #endregion

            #region Q18 - Given a list of space separated words, reverse the order of the words.

            //Console.Write("Enter a string : ");

            //string myString = Console.ReadLine() ?? " ";

            //string[] arrOfString = myString.Split(" ");

            //StringBuilder newString = new StringBuilder();

            //for (int i = arrOfString.Length - 1; i >= 0; i--)
            //{
            //    newString.AppendFormat(" {0}", arrOfString[i]);
            //}

            //Console.Write(newString.ToString().TrimStart());

            #endregion

            #region Q19 - Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of firstarray on second array and print second array.


            //int[] arr01 = new int[3];
            //int[] arr02 = new int[3];

            //for (int i = 0; i < arr01.Length; i++)
            //{
            //    Console.Write($"Enter element {i + 1 } : ");
            //    int.TryParse( Console.ReadLine() , out arr01[i] );
            //}

            //Console.WriteLine("===============================");

            //for (int i = 0; i < arr02.Length; i++)
            //{
            //    arr02[i] = arr01[i];
            //    Console.WriteLine( arr02[i] );
            //}

            #endregion

            #region Q20 - Write a Program to Print One Dimensional Array in Reverse Order

            //int[] arr01 = new int[3];

            //for (int i = 0; i < arr01.Length; i++)
            //{
            //    Console.Write($"Enter element {i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out arr01[i]);
            //}

            //Console.WriteLine("===============================");

            //for (int i = arr01.Length - 1; i >= 0; i--)
            //{

            //    Console.WriteLine(arr01[i]);

            //}

            #endregion

        }


    }
}
