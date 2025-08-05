using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a task:");
        Console.WriteLine("1. Grade Calculator");
        Console.WriteLine("2. Ticket Price Calculator");
        Console.WriteLine("3. Triangle Type Identifier");
        Console.Write("Enter choice (1, 2, or 3): ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                GradeCalculator();
                break;
            case "2":
                TicketPriceCalculator();
                break;
            case "3":
                TriangleTypeIdentifier();
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

    static void TriangleTypeIdentifier()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        Console.Write("Side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Triangle Type: Equilateral");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("Triangle Type: Isosceles");
        }
        else
        {
            Console.WriteLine("Triangle Type: Scalene");
        }
    }
}
