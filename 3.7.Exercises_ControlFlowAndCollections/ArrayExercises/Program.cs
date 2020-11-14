using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            //Creates and initializes an array with the following values in a single line:
            int[] ints = { 1, 1, 2, 3, 5, 8 };

            //Loops through the array and print out each value.
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }


            //Modiies the loop to only print the odd numbers from the array.
            foreach (int i in ints)
            {
                //Takes the integer and divides it by 2 (modulo), if the result equals zero then it prints the integer.
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
