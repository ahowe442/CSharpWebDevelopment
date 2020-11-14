using System;

namespace _2._5._2_ClassesAndObjects_Part2_Notes
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes and Objects, Part 2");
            Console.WriteLine("\n");
            Console.WriteLine("5.1 Customizing Fields");
            Console.WriteLine("\n");
            /*
            Readonly Fields - Cannont be change once they are initalized. (readonly int, readonly double)
                            - We cannont assign a new object a readonly reference field.
             */
            FinalFields demo = new FinalFields();

            // this would result in a complier error becasue IntValue has already been initialized.
            //demo.intValue = 6;

            // This isn't allower since we didn't initialize DoubleValue in the class declaration.
            //demo.doubleVaule = 42.0;

            //This would result in a complier error.
            //demo.doubleVaule = 6.0;

            //This would result in a compiler error, since we're trying to give objectValue a different object value.
            //demo.objectValue = new FortyTwo();

            /*However, this is allowed since we're changing a field inside 
             * the final object, and not changing which object objectValue 
             * refers to.*/
            Console.WriteLine("This is the result of before (demo.objectValue.intValue = 6;) : " + demo.intValue);
            demo.objectVaule.intValue = 6;
            Console.WriteLine("This is the result of after (demo.objectValue.intValue = 6;) : " + demo.intValue);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("5.1.2. Static fields");

            /*
            Static Fields - Staic Fields are shared by all instances of the class.

            See Temperture Project -->
            // If ht estatic field is public we can do this.
            Console.WriteLine("Absolute zero in F is: " + Temperture.AbsoluteZeroFahrenheit);

             */
            Console.WriteLine("5.1.3. Constant fields");

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("5.2 Instance and Static Methods");
            
            Console.WriteLine("\n" +
                "Quick Method Review: " +
                "\n" +
                "\n1.  A method belongs to a class and performs and action. \n" +
                "\n2.  Methods cannot stant on their own - they must be part of a class. \n" +
                "\n3.  To call a method on an object, use dot notation.\n");
            //objectName.MethodName(arguments);
            Console.WriteLine("5.2.2 Instance Methods");
            Console.WriteLine("\n" +
                "\n4.  Access modifiers apply to methods. " +
                "\n \t a.  private methods are those that are NOT useful " +
                "\noutside of the class but contribute internally to helping " +
                "\nthe class behave as desired or expected. " +
                "\n \t b.  public methods contain code that other classes need to " +
                "\nuse when they inplement the class containing those methods. " +
                "\nMake methods public only when you expect other classes to use " +
                "\nthem, and when you are committed to maintining those methods " +
                "\nfor other programs. ");

            //Instance Methods define the behaviors that are unique to each class.
            // Instance Methods depend on the data stored in tan individual
            //object.  If two objects call the dame method, the results will
            //vary when the objects contain different data.

            Console.WriteLine("5.2.2 Static Methods");
            Console.WriteLine("\n" +
                "\nStatic methods belong to the class as a whole and not to any specific instances of the class. " +
                "\n \t sometimes they are called \"class methods\". ");

            Console.WriteLine("5.2.4. Accessing Static vs. Instance Fields");
            //Static methods cannot call instance methods.
            //Static methods can be called from anywhere(depending on their
            //access modifier), they also do not require us to create an object
            //for a particular class.


            Console.WriteLine("5.3 Special Methods");
            Console.WriteLine("5.3.1. ToString");
            Console.WriteLine("5.3.1. Equals");
            Console.WriteLine("\n" +
                "\nAlways use Equals() to compare objects." +
                "\n");

        }
    }
}

