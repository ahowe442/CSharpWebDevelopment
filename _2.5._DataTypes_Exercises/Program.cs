using System;

namespace _2._5._DataTypes_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2.5.1. Input/Output");
            Console.WriteLine("Write a new “Hello, World” program to prompt the user for their name and greet them by name." + "\n");

            Console.WriteLine("What is you name?");
            //This creates the variable that stores the user input. 
            string name = Console.ReadLine();
            // Use concatenation to print the greeting
            Console.WriteLine("\n" + "Hello " + name + "\n");

            Console.WriteLine("2.5.2. Numeric Types");
            Console.WriteLine("Write a program to calculate the area of a " +
                "rectangle and print the answer to the console. You should " +
                "prompt the user for the dimensions. What data types should the " +
                "dimensions be?" + "\n");

            //Prompts user for the length
            Console.WriteLine("Enter the rectangle length:");
            // Defines a variable to handle the user's response.
            string lengthInput = Console.ReadLine();
            // Converts from string to int. 
            int length = int.Parse(lengthInput);
            //Prompts user for the width
            Console.WriteLine("Enter the rectangle width:");
            // Defines a variable to handle the user's response.
            string widthInput = Console.ReadLine();
            // Converts from string to int.
            int width = int.Parse(widthInput);
            //uses the l and w values to calulate the area of rectangle.
            int area = (length * width);
            // Prints area
            Console.WriteLine("The area of your rectangle is " + area + "\n");

            Console.WriteLine("\n" + "2.5.3. More on Numeric Types");
            Console.WriteLine("Write a program that asks a user for the number " +
                "of miles they have driven and the amount of gas they’ve " +
                "consumed in gallons, and print their miles-per-gallon." + "\n");

            //Prompt user for number of miles driven.
            Console.WriteLine("number of miles driven");
            //Define a variable to collect the user response.
            string milesInput = Console.ReadLine();
            // Convert the user response from a string to int.
            int miles = int.Parse(milesInput);
            //Prompt user for number of gals of gas consumed
            Console.WriteLine("number of gals consumed:");
            //Define a variable to collect the user response.
            string galInput = Console.ReadLine();
            // Convert the user response from a string to int.
            int gals = int.Parse(galInput);
            //Define a variable that performs the calulation
            int mpg = (miles / gals);
            //Call the calc var and Print mpg calculation. 
            Console.WriteLine("The miles per gallon is: " + mpg + "\n");

            Console.WriteLine("2.5.4. Strings");
            Console.WriteLine("Directions:  The first sentence of Alice’s " +
                "Adventures in Wonderland is below. Store this sentence in a " +
                "string, and then prompt the user for a term to search for " +
                "within this string. Print whether or not the search term was " +
                "found. Make the search case-insensitive, so that searching for" +
                " “alice”, for example, prints true." + "\n");

            string passage = "Alice was beginning to get very tired of sitting" +
                " by her sister on the bank, and of having nothing to do: once" +
                " or twice she had peeped into the book her sister was reading," +
                " but it had no pictures or conversations in it, 'and what is" +
                " the use of a book,' thought Alice 'without pictures or" +
                " conversation?'";
            //Convert passage to lowercase so that differences in capitolization are accounted for.
            string lowerCasePassage = passage.ToLower();
            // Tests that lowerCasePassage returns passage in all lower case letters.
            //Console.WriteLine(lowerCasePassage);

            //Prompt for search team
            Console.WriteLine("Enter your passage serach term? ");
            // create a variable that houses the user search term input.
            string searchTermInput = Console.ReadLine();
            // Convert the search term to lower case to ensure there are not differences in capitolization.
            string lowerCaseSearchTerm = searchTermInput.ToLower();
            // return the first occurance of search term
            Console.WriteLine(lowerCasePassage.IndexOf(lowerCaseSearchTerm));
            // Print results of search as true or false. 
            if (lowerCasePassage.IndexOf(lowerCaseSearchTerm) == -1)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

            /*Extend the previous exercise. Assume the user enters a word 
             * that is in the sentence. Print out its index within the string 
             * and its length. Next, remove the word from the string and print 
             * the sentence again to confirm your code. Remember that strings 
             * are immutable, so you will need to reassign the old sentence 
             * variable or create a new one to store the updated phrase.*/

            if (lowerCasePassage.IndexOf(lowerCaseSearchTerm) == -1)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("index =" + lowerCasePassage.IndexOf(lowerCaseSearchTerm) + "\n" + "length = " + lowerCaseSearchTerm.Length);
            }
        }
    }
}
