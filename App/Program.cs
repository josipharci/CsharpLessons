﻿namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // A drawn triangle

            /*
             Console.WriteLine("   /|");
             Console.WriteLine("  / |");
             Console.WriteLine(" /  |");
             Console.WriteLine("/___|");
            */

            // Variables

            /*
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Josip";
            characterAge = 23;
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            */

            // Data Types

            /*
            string phrase = "Academy";
            char grade = 'A';
            int age = 25;
            double gpa = 3.2;
            bool isMale = true;
            */

            // Working with Strings

            /*
            string phrase = "Josip Harci";
                        //   01234 678910
            string phraseTwo = "Josip Harci " + "is cool";

            Console.WriteLine("Josip Harci");
            Console.WriteLine("Josip\nHarci"); //  Division new line
            Console.WriteLine("Josip\"Harci");
            Console.WriteLine(phrase);
            Console.WriteLine(phraseTwo);
            Console.WriteLine(phrase.Length); // Number char
            Console.WriteLine(phraseTwo.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phraseTwo.Contains("Josip"));
            Console.WriteLine(phrase[6]);
            Console.WriteLine(phrase.IndexOf("Josip") ); //Start ID
            Console.WriteLine(phrase.IndexOf("s") );
            Console.WriteLine(phrase.IndexOf("f") ); // It's not in sequence
            Console.WriteLine(phrase.Substring(8,3) );
            */

            // Working with Numbers

            /*
            Console.WriteLine(50);
            Console.WriteLine(5 + 8);
            Console.WriteLine(5 * 8);
            Console.WriteLine(5 - 8);
            Console.WriteLine(5 / 8);
            Console.WriteLine(5 % 2); // Ostatak
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine((4 + 2) * 3);
            Console.WriteLine(5.0 + 8.1); // Isto
            Console.WriteLine(5 + 8.1); // Isto

            Console.WriteLine(5 / 2.0);

            int num = 6;
            num++;
            Console.WriteLine(num);

            int numTwo = 6;
            numTwo--;
            Console.WriteLine(numTwo);

            Console.WriteLine(Math.Abs(-40) );

            Console.WriteLine(Math.Pow(2 , 3));

            Console.WriteLine(Math.Sqrt(36));

            Console.WriteLine(Math.Min(36,100));

            Console.WriteLine(Math.Max(36,100));

            Console.WriteLine(Math.Round(2.3));
            */

            // Getting User Input

            /*
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            // Console.WriteLine("Hello " + name);

            Console.Write("Enter your age: ");
            String age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);

            
            */

            // Building a calculator

            /*
            Console.Write("Enter the first number: ");
            Double numOne = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            Double numTwo = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine(numOne + numTwo);
            */

            // Building a Mad Libs Game

            /*
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses are " + color);
            Console.WriteLine( pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);
            */

            // Arrays

            /*
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42};
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "John";

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1] );
            */

            //SayHi("Mike", 33);
            
            Console.ReadLine();

        }

        // Methods
        // Return Statement

        static void SayHi(string name,int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);

        }
    }
}