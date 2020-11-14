namespace _2._7._Inheritance
{
    public class Cat
    {
        //... code for the cat class.
        /*
            * AKA: Superclass, Baseclass, or the parent class of HouseCat. 
            */

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

        //public abstract string Noise1();
    }
    
}

