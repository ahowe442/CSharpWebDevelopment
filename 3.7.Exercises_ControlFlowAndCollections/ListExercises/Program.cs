using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");

            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            //1. Write a static method to find the sum of all the even numbers in a List.

            static int GetSumOfEvenNums(List<int> myList)
            {
                int sum = 0;
                for (int i = 0; i < myList.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum = myList[i];
                        sum = sum + myList[i];
                    }
                    else
                    {
                        
                    }

                }
                Console.WriteLine(sum);
                return sum;
            }

            GetSumOfEvenNums(myList);

            //2. Within Main, create a list with at least 10 integers and call your method on the list.
            List<int> tenIntegers = new List<int>();
            tenIntegers.Add(1);
            tenIntegers.Add(3);
            tenIntegers.Add(4);
            tenIntegers.Add(10);
            tenIntegers.Add(34);
            tenIntegers.Add(55);
            tenIntegers.Add(12);
            tenIntegers.Add(38);
            tenIntegers.Add(45);
            tenIntegers.Add(101);

            GetSumOfEvenNums(tenIntegers);
            //3. Write a static method to print out each word in a list that has exactly 5 letters.

            List<string> words = new List<string>();
            words.Add("Pepsi");
            words.Add("Ella");
            words.Add("Earth");
            words.Add("I");
            words.Add("Is");
            words.Add("Put");
            words.Add("aarrgh");

            static void printFiveLetterWords(List<string> words)
            {
                foreach(string word in words)
                {
                    if (word.Length == 5)
                    {
                        Console.WriteLine(word);
                    }
                    else
                    {
                        continue;
                    }
      
                }
            }

            printFiveLetterWords(words);

            //4.  Modify your code to prompt the user to enter the word length for the search.

            static void printNumLetterWords(List<string> words)
            {
                Console.WriteLine("Enter and integer between 1 - 6: ");
                string userInput = Console.ReadLine();
                int input = int.Parse(userInput);

                foreach (string word in words)
                {
                    if (word.Length == input)
                    {
                        Console.WriteLine(word);
                    }
                    else
                    {
                        continue;
                    }

                }
            }

            printNumLetterWords(words);

        }
    }


}
