using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Triangle Type Identifier ===");
            Console.WriteLine("Enter the three sides of the triangle:");
            
            // Get the three sides
            double side1 = GetSide("Side 1");
            double side2 = GetSide("Side 2");
            double side3 = GetSide("Side 3");
            
            // Check if the sides form a valid triangle
            if (IsValidTriangle(side1, side2, side3))
            {
                string triangleType = DetermineTriangleType(side1, side2, side3);
                Console.WriteLine($"\nSide 1: {side1}");
                Console.WriteLine($"Side 2: {side2}");
                Console.WriteLine($"Side 3: {side3}");
                Console.WriteLine($"Triangle Type: {triangleType}");
            }
            else
            {
                Console.WriteLine("\nError: The given sides do not form a valid triangle.");
                Console.WriteLine("The sum of any two sides must be greater than the third side.");
            }
        }
        
        static double GetSide(string sideName)
        {
            while (true)
            {
                Console.Write($"Enter {sideName}: ");
                string? input = Console.ReadLine();
                
                if (double.TryParse(input, out double side))
                {
                    if (side > 0)
                    {
                        return side;
                    }
                    else
                    {
                        Console.WriteLine("Error: Side length must be positive.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
            }
        }
        
        static bool IsValidTriangle(double a, double b, double c)
        {
            // Triangle inequality theorem: sum of any two sides must be greater than the third side
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
        
        static string DetermineTriangleType(double a, double b, double c)
        {
            // Check if all sides are equal (Equilateral)
            if (Math.Abs(a - b) < 0.001 && Math.Abs(b - c) < 0.001)
            {
                return "Equilateral";
            }
            // Check if two sides are equal (Isosceles)
            else if (Math.Abs(a - b) < 0.001 || Math.Abs(a - c) < 0.001 || Math.Abs(b - c) < 0.001)
            {
                return "Isosceles";
            }
            // No sides are equal (Scalene)
            else
            {
                return "Scalene";
            }
        }
    }
} 