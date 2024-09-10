using System;

class Program
{

    static void Main(string[] args)
    {
        /*
         Task one: Output Statement
         */
        // Name and favorite color
        string name = "Emily";
        string favoriteColor = "Blue";

        // Current year
        const int currentYear = 2024;

        // Output
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Favorite Color: " + favoriteColor);
        Console.WriteLine("Current Year: " + currentYear);
        Console.ReadLine();


    }
}

class Task3
{
    public static void DisplayUserInfo()
    {
        /*
         Task three: Output Statement
         */
        // Variables
        int age = 25;
        decimal heightInMeters = 1.6256m;
        char favoriteLetter = 'E';
        bool likesProgramming = true;

        // Output
        Console.WriteLine("Task 3: Variables and User Input");
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height in meters: " + heightInMeters);
        Console.WriteLine("Favorite letter: " + favoriteLetter);
        Console.WriteLine("Likes programming: " + likesProgramming);
        Console.ReadLine();
    }
}

class CircleArea
{
    // Declare a constant for Pi
    private const double PI = 3.14159;

    public static void CalculateAndDisplayArea()
    {
        // Radius of the circle
        double radius = 5.0;

        // Calculate the area using the formula
        double area = PI * radius * radius;

        // Output
        Console.WriteLine("Task: Calculate the Area of a Circle");
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area of the circle: " + area);
    }
}

class DataTypes
{
    public static void DisplayData()
    {
        // Variables
        string firstName = "Emily";
        long cityPopulation = 42088;
        double temperatureCelsius = 23.5;
        bool isStudent = true;

        // Output
        Console.WriteLine("Task 5: Data Types");
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("City Population: " + cityPopulation);
        Console.WriteLine("Temperature in Celsius: " + temperatureCelsius);
        Console.WriteLine("Is Student: " + isStudent);
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Call methods from other classes
        CircleArea.CalculateAndDisplayArea();
    }
}
