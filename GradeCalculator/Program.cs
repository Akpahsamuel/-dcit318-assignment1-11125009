using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Grade Calculator ===");
            Console.WriteLine("Enter a numerical grade between 0 and 100:");
            
         
            string? input = Console.ReadLine();
            
          
            if (double.TryParse(input, out double grade))
            {
              
                if (grade >= 0 && grade <= 100)
                {
                    string letterGrade = GetLetterGrade(grade);
                    Console.WriteLine($"\nNumerical Grade: {grade}");
                    Console.WriteLine($"Letter Grade: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
        }
        
        static string GetLetterGrade(double grade)
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }
    }
} 