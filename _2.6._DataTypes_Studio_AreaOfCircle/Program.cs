using System;

namespace _2._6._DataTypes_Studio_AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2.6.1 Studio: Area of a Circle");
            //Write a program that prompts the user for the radius of a circle.
            //Calculate the area of the user’s circle and print the result.

            Console.WriteLine("Input the radius (in miles) of the circle:");
            string radiusInput = Console.ReadLine();
            double radius = double.Parse(radiusInput);

            Circle.Area(radius);

            Console.WriteLine("2.6.2 Studio: More Calculations" + "\n");

            Circle.Circumference(radius);
            Circle.Diameter(radius);

            Console.WriteLine("2.6.3 Studio: Road trip");
            //Ask the user for the miles per gallon of their car.
            Console.WriteLine("Mile per gallon?:");
            string mpgInput = Console.ReadLine();
            //convert the iput string to a double.
            double mpg = double.Parse(mpgInput);


            Circle.CircleGallons(radius, mpg);


            Console.WriteLine("2.6.4 Studio: Bonus Missions");

            //TODO
            /*1.  Think about how we could make this program more modular by 
             * breaking out some of the code into a separate class. 
             * For example, we could pull out the circle information into a 
             * Circle class and leave the user questions and console messages 
             * in Program. Take a look at for a refresher on using another 
             * class file.
             * 
             * 2.  Extend your program further by using a while or do-while 
             * loop, so that when the user enters a negative number they are 
             * re-prompted for a radius.
             * 
             * 3.  Add additional validation to your program. If the user enters
             * a non-numeric character or a empty string? Print an error message
             * and quit. You’ll need to peek ahead to learn about conditional
             * syntax in C#. */
        }
    }
}
