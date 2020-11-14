using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
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
