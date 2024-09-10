using System;

namespace TaskMenu
{
    class taskfour

    {

        /*
        Task four: Constants
        */
        
        // Declare a constant for Pi
        private const double PI = 3.14159;

        public taskfour()
        {
            // Radius of the circle
            double radius = 5.0;

            // Calculate the area using the formula
            double area = PI * radius * radius;

            // Output
            Console.WriteLine("Task: Calculate the Area of a Circle");
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area of the circle: " + area);
            Console.ReadLine();
        }
    }
}