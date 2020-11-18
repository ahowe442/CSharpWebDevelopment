using System;

namespace _7._8._Inheritance_Exercises_Cats
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            // Try out your skills with inheritance here!

            var garfield = new HouseCat("Garfield", 16.5);
            garfield.Eat();
            Console.WriteLine(garfield.Tired);

            HouseCat spike = new HouseCat("Spike");
            Console.WriteLine(spike.Weight);

            Cat plainCat = new Cat(8.6);
            HouseCat cheshireCat = new HouseCat("Cheshire Cat", 26);
            Console.WriteLine(plainCat.Noise());
            Console.WriteLine(cheshireCat.Noise());

            Cat suki = new HouseCat("Suki", 8.0);
            Console.WriteLine(suki.Noise());
            Console.WriteLine((suki as HouseCat).IsSatisfied());

        }
    }
}
