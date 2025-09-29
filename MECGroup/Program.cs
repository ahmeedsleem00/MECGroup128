
using System;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {

        //Q1.Write a program that reads the user’s name and age, then prints a greeting message.


        //Console.WriteLine("Enter your name");

        //string name = Console.ReadLine();

        //Console.WriteLine("Enter your age");

        //int age = int.Parse(Console.ReadLine());

        //Console.WriteLine($"your name  : {name} , your age : {age}");


        //Q2.Print the multiplication table(1 to 10) for a number entered by the user.

        //int n = int.Parse(Console.ReadLine());

        //for(int i =1; i <= 15; i++)
        //{
        //    Console.WriteLine($"{n} x {i} = {n * i}");
        //}

        //Q3.Given an array { 55, 70, 90, 40}, print the average, highest, and lowest grade.

        //int[] grades; // CLR Allocate 4  Bytes in STACK for reference

        //int[] grades = { 55, 70, 90, 40 }; // CLR Allocate 16 Bytes in HEAP for 4 integers

        //Console.WriteLine($"Average : {grades.Average()}");
        //Console.WriteLine($"Highest : {grades.Max()}");
        //Console.WriteLine($"Min : {grades.Min()}");

        //Q4.Check if a word entered by the user is a palindrome. level


        //string word = Console.ReadLine();
        //string reversed = new string(word.Reverse().ToArray());

        //Console.WriteLine(word == reversed ? "palindrome" : "Not palindrome");
        ////word.Length;
        ///

        //Q5.Use StringBuilder to create multi - line text for employee details.

        //var Hambola = new StringBuilder();

        //Hambola.Append("Name : ahmed");
        ////Hambola.Replace("Name","O");
        //Hambola.Insert(0, "Your");
        //Console.WriteLine(Hambola.ToString());

        //Q6.Calculate the factorial of a number using a loop.

        //int n = 5, fact = 1;

        //for(int i = 1; i <= n; i++)
        //{
        //    fact *= i;
        //}
        //Console.WriteLine(fact);

        //Q8.Read an integer and print whether it is even or odd using the ternary operator.


        //int x = int.Parse(Console.ReadLine());

        ////Console.WriteLine(x % 2==0 ? "Even":"Odd");

        //if (x % 2 == 0)
        //{
        //    Console.WriteLine("Even");
        //}
        //else
        //{
        //    Console.WriteLine("Odd");
        //}

        //Q9.Demonstrate the use of ++x and x++.

        //int i = 5;

        //Console.WriteLine(++i); //6
        //Console.WriteLine(i++); //6 then x=7
        //Console.WriteLine(i); //7

        //Q10.Create a 2D array(3x3) filled with numbers 1–9 and print it.

        //1 2 3
        //4 5 6
        //7 8 9
        //int[,] arr = new int[3, 3];

        //int val = 1;

        //for(int i =0;i < 3; i++)
        //{
        //    for(int j =0; j < 3; j++)
        //    {
        //        arr[i,j] = val++;

        //        Console.WriteLine(arr[i, j] + "  ");

        //    }
        //    Console.WriteLine();
        //}

        //Q12.Ask for a password until the user enters "1234".

        //string pwd;


        //do
        //{
        //    pwd = Console.ReadLine();
        //} while (pwd != "1234");
        //Console.WriteLine("Welcome User");

        //Q13.Sort an array { 5, 3, 8, 1}
        //and print it in ascending and descending order.

        //int[] arr = { 5, 3, 8, 1 };

        ////Array.Sort(arr); // Ascending
        //Array.Reverse(arr); // Descending
        //Console.WriteLine(string.Join(" ISLAM " ,arr));

        //Q15.Demonstrate shallow copy vs deep copy of an array.

        //arr = { 5, 3, 8, 1 };
        //arr2 = arr => arr; // shallow copy

        //int[] arr = { 1,2,3 };
        //int[] shallow = arr; // shallow copy, same reference

        //arr[0] = 100;

        //Console.WriteLine(shallow[0]); 

        //int[] arr = { 456, 2, 3 };
        //int[] deep = (int[])arr.Clone(); // deep copy, different reference
        //arr[0] = 100;
        //Console.WriteLine(deep[0]);


        Console.WriteLine("Hello, MEC");
        Console.WriteLine("Hello, Team Lead");



    }


}

