using System;

namespace _2._5.Exercises_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.WriteLine("2.5.2. Numeric Types");
            Console.WriteLine("Calculate the area of a rectangle");

            Console.WriteLine("What is the length of the rectangle?");
            string userInput = Console.ReadLine();
            int length = int.Parse(userInput);

            Console.WriteLine("What is the height of the rectangle?");
            string userInput2 = Console.ReadLine();
            int height = int.Parse(userInput2);
            Console.WriteLine("The area of your rectangle is: " + (height * length));

            Console.WriteLine("2.5.3. More on Numeric Types");
            Console.WriteLine("Gas Milage Exercise");

            Console.WriteLine("How many miles did you travel?");
            string userInput3 = Console.ReadLine();
            double miles = double.Parse(userInput3);
            Console.WriteLine("How many gallons of gas did you consume?");
            string userInput4 = Console.ReadLine();
            double gallons = double.Parse(userInput4);

            Console.WriteLine("Your gas milage is: " + (miles / gallons) + " miles per gallon");

            Console.WriteLine("2.5.4. Strings");
            Console.WriteLine("GWord Search Exercise");
            string text = "Alice was beginning to get very tired of sitting by " +
                "her sister on the bank, and of having nothing to do: once or " +
                "twice she had peeped into the book her sister was reading, but " +
                "it had no pictures or conversations in it, 'and what is the use " +
                "of a book,' thought Alice 'without pictures or conversation?'";

            //Makes the passage all lowercase
            string loweredText = text.ToLower();
            //Asks and collects user input and stores it in userInput5
            Console.WriteLine("What is your search term?");
            string userInput5 = Console.ReadLine();

            //Creates and stores a new variable for user input in the lower case format.
            string searchTerm = userInput5.ToLower();
            // If the search term is not in the passage return false.
            // If the search term is in the passage return true.  
            Console.WriteLine(text.IndexOf(searchTerm));



        }
    }
}
