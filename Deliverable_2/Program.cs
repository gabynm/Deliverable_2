/*
 * Author: Gabriela Mejias
 * Date: 1/24/2023
 * Descrpition: This C# console calculates letter grades
 */
using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter a numerical grade: ");
                decimal grade = decimal.Parse(Console.ReadLine());
                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your letter grade is: " + letter);
                }
                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your letter grade is: " + letter);
                }
                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your letter grade is: " + letter);
                }
                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your letter grade is: " + letter);
                }
                else if (grade < 60 && grade >= 0)
                {
                    letter = "F";
                    Console.WriteLine("Your letter grade is: " + letter);
                }
            } 
            catch 
            {
                Console.WriteLine("Please enter a numeric value greater than 0");
            }


        }
    }
}