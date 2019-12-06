using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");


            int width, height, length, dimensions;
            decimal quote;


            Console.WriteLine("What is the weight of the package?");
            int weight = Convert.ToInt32(Console.ReadLine());


            if (weight > 50)
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");


            else
            {
                Console.WriteLine("What is the width of the package?");
                width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the height of the package?");
                height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the length of the package?");
                length = Convert.ToInt32(Console.ReadLine());

                dimensions = width + height + length;

                if (dimensions > 50)
                    Console.WriteLine("Package too big to be shipped via Package Express.");

            else
                {
                    quote = ((dimensions * weight) / 100m);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                    Console.WriteLine("Thank You");

                }

               
                Console.ReadLine();
            }

        }


    }
}