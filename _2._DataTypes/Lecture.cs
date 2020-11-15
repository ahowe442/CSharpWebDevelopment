using System;

namespace _2._DataTypes
{

    class Lecture
    {
        static void Main(string[] args)
        {
            //Single Line Comment

            /* Thi
             *is a
             *block
             *comment*/

            Console.WriteLine("2.1.1. Static vs. Dynamic Typing");

            /* C# is a statically typed language.  When a variable or parameter is declared 
             * in a statically typed language, the data type for the value must be 
             * specified.  Once the decalration is made, the variable or parameter cannot refer to a
             * value of any other type.  */

            string myDogsName = "Milo";

            //Nope!
            // myDogsName = 42; //This is trying to store an int in a String, legal in
            //JavaScript, not in C#.

            Console.WriteLine("2.1.2 Built-In Types");
            // There are a bunch of built-in types: int, float, double, char, and bool - These are primatives
            // (and immutable).  There are also .NET call equivalents: Int32, Single, Double, Char, Boolean, String - These are classes.

            Console.WriteLine("2.1.2.3. Operations");
            // Note: Operators like + and * are type-dependent.  For example when + is used with Strings they concatenate,
            //when + is used with numbers they add the numbers.

            Console.WriteLine("Hello" + " class!"); // Concatenate
            Console.WriteLine(5 + 3);   // Addition

            // Note: You can mix and match number types, the output will be the more precise (in this case double)
            float a = 2;
            double b = 3;
            Console.WriteLine((a + b).GetType()); //Returns: System.Double

            Console.WriteLine("2.1.3. Reference and Value Types");
            //Note: All primatives are Value types. 

            Console.WriteLine("2.1.3.1. Class Types");
            Cat myCat = new Cat();  //Declare the variable myCat of type Cat, the "= new" instantiates an instance.

            Cat myNamedCat = new Cat("Garfield");  //Constructor that takes in a name

            int catAge = 11;        // Get's it's own memory with the value 11
            Cat sameCat = myCat;    // What's happening here? sameCat references the same memory as myCat

            Console.WriteLine(myCat.Equals(sameCat));  //What do you think the output will be???  My guess is True

            Console.WriteLine("2.1.3.2. Boxing/Unboxing");

            int primitiveIntVal = 5;    // Primitive
            Console.WriteLine("Primitive Int Val: " + primitiveIntVal);

            Int32 objectIntVal = primitiveIntVal;   // Boxing (into a class object provided a primitive)
            Console.WriteLine("Primitive Int Object: " + objectIntVal);

            int samePrimitiveIntVal = objectIntVal; //Unboxing (into a primitave provided a class object)
            Console.WriteLine("Primitive Int Val (Copy): " + samePrimitiveIntVal);

            // Note: Console is part of the System package, since we said "using System" above we don't have to do
            //System.Console.WriteLine("This is unnecessary because of our using above");

            //The following code below is from the csharp-web-dev-lsn1datatypes solution
            string input;
            Double fahrenheit;

            // 2.2.4. Input / Output and the COnsole Class
            Console.WriteLine("Temperture in F: "); //Output
            input = Console.ReadLine();             //Input a String
            fahrenheit = double.Parse(input);       //Convert to a double

            Console.WriteLine("You Input: " + fahrenheit);

            //2.3 Strings, Characters, and Arrays
            Console.WriteLine("2.3.1.2. Single vs. Double Quotation Marks");
            string stringVar = "Dog";   //Strings require double quotation marks
            char charVar = 'd';         //Characters use single quotation marks

            Console.WriteLine("2.3.1.3. String Manipulation");

            string str = "Rutabaga";

            Console.WriteLine(str.Substring(3, 1));     //Returns the character in the 3rd position, (a).
            Console.WriteLine(str.Substring(2, 3));     //Returns the character from the 2nd to the 4th position, (substring starting at index 2 and 3 characters long, (tab))
            Console.WriteLine(str.Length);              // Tells us the length of the string, (8)
            Console.WriteLine(str.IndexOf('a'));        // Returns the index for the first occurance of 'a', (3)
            Console.WriteLine(str.Split('a')[0] + ", " + str.Split('a')[1] + ", " + str.Split('a')[2]);  //Splits the string into sections as each delimeter and stores the sections as elements in an array, ({Rut, b, g})
            Console.WriteLine(str + str);               //Concatenate two strings together, (RutabageRutabaga).
            Console.WriteLine(str.Trim());              //Removes any whitespace at the beginning or end of the string,
            Console.WriteLine(str.ToUpper());           //Changes all aphabetic characters in the string to UPPERCASE
            Console.WriteLine(str.ToLower());           //Changes all aphabetic characters int he string to lowercase.

            Console.WriteLine("2.3.2. Arrays");

            int[] someInt = new int[10];                // Creates an array of size 10 that contains integers
            int[] someOtherInts = { 1, 2, 3, 4, 5, 8 }; // Creates an array of integers with 1,1,2,3,5,8 stored
            int anInt = someOtherInts[4];
            Console.WriteLine(anInt);                   // Should output 5, remember arrays are 0 based

            // As we’ve said several times now, every variable in C# refers to an object!!

            Console.WriteLine("2.4.2 Static Methods");
            // Refer to Cat.makeNoise() method

            // Notice that we didn't have to instantiate it first! 
            Cat.makeNoise(null);        // Outputs roar!
            Cat.makeNoise("purr");      // Outputs purr


            // 2.4.3. HelloMethods
            string message = Message.GetMessage("fr");  // Calling a static method using ClassName.MethodName(arguments)
            Console.WriteLine(message);

            // Won't work since the method is private!
            //string secretMessage = Message.GetPrivateMessage("Hello?");
        }
    }
}
