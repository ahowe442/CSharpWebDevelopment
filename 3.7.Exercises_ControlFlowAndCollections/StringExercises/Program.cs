using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");

            // Step 1. assigns the passage to the var str. 
            string str = "I would not, could not, in a box. I would not, " +
                "could not with a fox.I will not eat them in a house. I will " +
                "not eat them with a mouse.";


            //Step 2.  Use the Split method to divide the string at each space.
            //store the individual words in an array
            string[] wordStorage = str.Split(" ");

            
            //Step 3.  loop through and print each value in the array.

            foreach (string i in wordStorage)
            {
                Console.WriteLine(i);
            }

            //Step 4.  Repeat steps 2 and 3, but change the delimiter to split the
            //string into separate sentences.

            string[] wordStorage2 = str.Split(".");

            foreach (string i in wordStorage2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
