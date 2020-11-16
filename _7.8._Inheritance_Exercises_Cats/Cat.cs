﻿namespace _7._8._Inheritance_Exercises_Cats
{
    public class Cat
    {
        public bool Tired { get; set; } = false;
        public bool Hungry { get; set; } = false;
        public double Weight { get; set; }
        public string Family { get; } = "Felidae";

        public Cat(double weight)
        {
            Weight = weight;
        }

        public Cat()
        {
            Weight = 13.0;
        }

        // On this line, add a no-argument constructor



        public void Sleep()
        {
            Tired = false;
            Hungry = true;
        }

        public void Eat()
        {
            if (!Hungry)
            {
                Tired = true;
            }

            Hungry = false;
        }

        public virtual string Noise()
        {
            return "Meow!";
        }

    }
}
