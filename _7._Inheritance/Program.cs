using System;

namespace _7._Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_2._7._Inheritance");
            /*Inheritance
             * Definition: 
             * Is a mechanism within objet-oriented programming that allows one 
             * class to be based on another class, thus recieveing it's 
             * properties. 
             */

            // Try out your skills with inheritance here!

            HouseCat garfield = new HouseCat("Garfield", 12.0);
            garfield.Eat();
            Console.WriteLine(garfield.Tired); //Prints True.

            //7.3.2 Base
            /*Base
             * Does not complile because the child class HouseCat does not have 
             * the same weight constructor the following will not compile
             */

            //HouseCat mittens = new HouseCat(8.4);

            HouseCat spike = new HouseCat("Spike");
            Console.WriteLine(spike.Weight); //Should print 13

            /*7.3.3 override
             * this modifies the behavior of the base class. 
             */

            Cat plainCat = new Cat(8.6);
            HouseCat cheshireCat = new HouseCat("Cheshire Cat", 26.0);

            Console.WriteLine(plainCat.Noise()); // prints "Meow!"
            Console.WriteLine(cheshireCat.Noise()); // prints "Hello, my name is Cheshire Cat!"

            /*7.4.1 Abstract Classes
             * Prevents objects of type Cat from being created while still 
             * enabling sharing of behavior among its subclasses. 
             */

            /*7.4.2 Abstract Methods
             * 
             * An abstract method is a method in an abstrict class that does 
             * not ahave a body. In other word, it soes notahve any associated
             * code, onlly a signature. 


            /*  7.5. Casting
             *
             */

            Cat suki = new HouseCat("Suki", 8); //HouseCat is a Cat.
            // Calls HouseCat's Noise() method
            suki.Noise();  // Hello, my name is Suki!

            // Results in a compiler error, since Cat
            // doesn't have such a method
            //suki.IsSatisfied();

            // As long as suki really is a HouseCat, this works
            (suki as HouseCat).IsSatisfied();
            /*The danger here is that if suki is in fact not a HouseCat 
             * (it was declared only as a Cat, after all) then we’ll 
             * experience a runtime exception. A runtime exception is an error 
             * that occurs upon running the program, and is not found by the 
             * compiler beforehand. These are dangerous, and situations where 
             * these exeptions might come up should be avoided. So you should 
             * only cast an object to another type when you are very sure that 
             * it’s safe to do so.*/


        }
    }
}
