namespace _7._Inheritance
{
    public class HouseCat : Cat
    {
        //... code for the housecat...
        /*
         * AKA: subclass, derived class or child class of Cat. 
         */

        public string Name { get; set; }
        public string Species { get; } = "Felis catus";


        public HouseCat(string name, double weight) : base(weight)
        {
            Name = name;
        }

        public HouseCat(string name)
        {
            Name = name;
        }

        public HouseCat(double weight) : base(weight)
        {
            //this is all there is to this constructor.
        }

        // On this line, write a constructor that uses the no-arg constructor in the Cat class.

        public bool IsSatisfied()
        {
            return !Hungry && !Tired;
        }

        public override string Noise()
        {
            if (IsSatisfied())
            {
                return "Hello, my name is " + Name + "!";
            }
            else
            {
                return base.Noise(); //Prints "Meow!"
            }

        }

        public string Purr()
        {
            return "I'm a housecat";
        }


    }
}
