using System;

namespace _4._7._ClassesAndObjects_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Student abby = new Student("Abby");
            Console.WriteLine("Abby's Grade (Before) " + abby.ToString());
            abby.AddGrade(3, 4.0);
            Console.WriteLine("Abby's Grade (After) " + abby.ToString());
            abby.AddGrade(3, 4.0);
            Console.WriteLine("Abby's Grade (After) " + abby.ToString());

        }
    }
}
