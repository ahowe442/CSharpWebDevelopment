using System;

namespace _2._6._DataTypes_Studio_AreaOfCircle
{
    public class Circle
    {

        public const double pi = 3.14;

        public static void Area(double radius)
        {

            double area = (pi * radius * radius);
            Console.WriteLine("the area of the circle is equal to: " + area + "\n");
        }

        public static void Circumference(double radius)
        {
            double circumference = (2 * pi * radius);

            Console.WriteLine("the circumference of the circle is equal to: " + circumference);

        }

        public static void Diameter(double radius)
        {
            double diameter = (2 * radius);
            Console.WriteLine("the diameter of the circle is equal to: " + diameter + "\n");
        }

        public static void CircleGallons(double radius, double mpg)
        {
            double circumference = (2 * pi * radius);
            double mpgCircle = (mpg * circumference);
            Console.WriteLine("Gallons of gas they used to go around this circle is: " + mpgCircle);
        }
    }
}
