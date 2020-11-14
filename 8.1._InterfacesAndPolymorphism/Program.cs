using System;

namespace _8._1._InterfacesAndPolymorphism
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 8 - Interfaces And Polymorphism");
            /* 
             * Interfaces: 
             *      Similar to an apstract class. 
             *      Interfaces allow us to carea code organized by behavior. 
             *      C# includes intefaces as a formal construction. 
             *          They cannot be instanciated and thay have limitations 
             *          on what king of behavioral info they may contain. 
             *          
             *          C# Interface - 
             *          1.  Constants
             *          2.  Method Signatures
             *          3.  Static methods
             *          4.  Default methods. 
             *      
             */

            HouseCat suki = new HouseCat("Suki", 12);
            CatSitter annie = new CatSitter(suki);

            annie.FeedThePet();
        }
    }
    // 8.2.1.3. Default Methods
    //default methods - have a body and is a fully-formed method. It may be
    // extended by classes implementing the interface.  
    public interface IFeedable
    {
        void Eat();

        void Nap()
        {
            Console.WriteLine("Snoooozzze");
        }
    }
    /*The intended purpose of default methods is to allow programmers to add a 
     * method to an interface that has already been released, while not forcing
     * those already using the interface to add new code to their classes. */

    public class Cat : IFeedable
    {
        public void Eat()
        {
            Console.WriteLine("nom nom");
        }

        // ...rest of the class definition. 
    }

    //YOu may both extend a class and implement an interface at the same time.
    //Define HOuseCat to extend the class Cat as well as an interface IPetable that in not already inherited by Cat.

    public class HouseCat : Cat, IPetable
    {
        //NOTE: Order matters here.  The class being extended must come before
        //any interfaces being implemeted. 
    }

    /*Here is how we might modify our CatSitter class
     Interfaces define a type tht can be used when declaring fields and methods.
        Allows us to make our code more abstract.
        makes it more extensible and adaptable.
    
     Extinsible: It is easier for programmers for new capabilities to be added later. */
    public class CatSitter
    {
        public IFeedable Pet { get; set; }

        public CatSitter(IFeedable pet)
        {
            Pet = pet;
        }

        public void FeedTheCat()
        {
            // ...code to prepare the cat's meal.
            Pet.Eat();
        }
    }

    public class PetSitter
    {
        public IFeedable Pet { get; set; }

        public PetSitter(IFeedable pet)
        {
            Pet = pet; 
        }

        public void FeedThePet()
        {
            // code to prepare the pet's meal.
            Pet.Eat();
        }
    }

    public class CatSitter : PetSitter
    {
        public CatSitter(IFeedable pet) : base(pet)
        {
            Pet = pet; 
        }
        // other cat specific behavior. 
    }
}
