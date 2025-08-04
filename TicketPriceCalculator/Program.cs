using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ticket Price Calculator ===");
            Console.WriteLine("Enter your age:");
            
            // Get user input
            string? input = Console.ReadLine();
            
            // Validate input and convert to number
            if (int.TryParse(input, out int age))
            {
                // Check if age is valid
                if (age >= 0 && age <= 120)
                {
                    double ticketPrice = CalculateTicketPrice(age);
                    Console.WriteLine($"\nAge: {age}");
                    Console.WriteLine($"Ticket Price: GHC{ticketPrice:F2}");
                    
                    // Display discount information if applicable
                    if (age <= 12)
                    {
                        Console.WriteLine("Discount: Child discount applied (GHC7 instead of GHC10)");
                    }
                    else if (age >= 65)
                    {
                        Console.WriteLine("Discount: Senior citizen discount applied (GHC7 instead of GHC10)");
                    }
                    else
                    {
                        Console.WriteLine("Standard adult price (GHC10)");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid age between 0 and 120.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }
        }
        
        static double CalculateTicketPrice(int age)
        {
            // Senior citizens (65 and above) and children (12 and below) get discount
            if (age >= 65 || age <= 12)
            {
                return 7.0; // Discounted price
            }
            else
            {
                return 10.0; // Regular price
            }
        }
    }
} 