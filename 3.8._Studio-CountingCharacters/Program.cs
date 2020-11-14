using System;
using System.Collections.Generic;
using System.Linq;
namespace _3._8._Studio_CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt for input
            //Parse input and store in a userInput variable

            //Sample Input
            string myString = "Lorem ipsum dolor sit amet, consectetur " +
                "adipiscing elit. Nunc accumsan sem ut ligula scelerisque " +
                "sollicitudin. Ut at sagittis augue. Praesent quis rhoncus " +
                "justo. Aliquam erat volutpat. Donec sit amet suscipit metus, " +
                "non lobortis massa. Vestibulum augue ex, dapibus ac suscipit" +
                " vel, volutpat eget massa. Donec nec velit non ligula" +
                " efficitur luctus.";
            
            //Converts string to a character array
            char[] charactersInString = myString.ToCharArray();


            //Creates dictionary to store char keys and count values.
            var dictionary = new Dictionary<char, int>();

            //loops through each character in myString
            foreach (var character in myString.ToUpper())
            {
                //If the dictionary contains the key then increment the count only. 
                if (dictionary.ContainsKey(character))
                {
                    dictionary[character]++;
                }
                else
                {
                    //If the dictionary doesn't then add both the char and begin the count at 1. 
                    dictionary.Add(character, 1);
                }
            }
            //Loop through the dictionary and print each kvp. 
            foreach(KeyValuePair<char, int> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            
        }
        }
    }
