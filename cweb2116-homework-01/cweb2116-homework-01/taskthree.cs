using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMenu
{
    class taskthree
    {
        public taskthree()
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
}
