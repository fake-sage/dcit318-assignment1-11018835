using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a task:");
        Console.WriteLine("1. Grade Calculator");
        Console.WriteLine("2. Ticket Price Calculator");
        Console.Write("Enter choice (1 or 2): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                GradeCalculator();
                break;
            case "2":
                TicketPriceCalculator();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void GradeCalculator()
    {
        Console.Write("Enter your numerical grade (0-100): ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade >= 90)
                Console.WriteLine("Grade: A");
            else if (grade >= 80)
                Console.WriteLine("Grade: B");
            else if (grade >= 70)
                Console.WriteLine("Grade: C");
            else if (grade >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }

    static void TicketPriceCalculator()
    {
        Console.Write("Enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            int price = (age <= 12 || age >= 65) ? 7 : 10;
            Console.WriteLine($"Ticket Price: GHC{price}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
