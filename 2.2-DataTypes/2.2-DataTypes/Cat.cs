using System;

namespace _2._2_DataTypes
{
    public class Cat
    {
        string name;

        public Cat()
        {
            name = "cat";
        }

        public Cat(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name; 
        }
        public void setName(string name)
        {
            this.name = name; 
        }

        //2.4.2 Static Methods
        public static void makeNoise(String noise)
        {
            if(noise == null) {
                Console.WriteLine("Roar!");
            }
            else
            {
                Console.WriteLine(noise);
            }
        }
    }
}