using System;

namespace _2._3_ControlFlowAndCollections
{
    class Notes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.1 Conditionals");
            Console.WriteLine("3.1.1. if Statements");

            //if (condition)
            //{
            //    statement
            //    statement
            //}

            Console.WriteLine("3.1.2. if else Statements");

            //if (condition)
            //{
            //    statement
            //    statement
            //}
            //else (condition)
            //{
            //    statement
            //    statement
            //}

            Console.WriteLine("3.1.3. else if Statements");
            //An else if construction in C#
            Console.WriteLine("Enter a grade: ");
            string gradeString = Console.ReadLine();
            int grade = int.Parse(gradeString);
            if (grade < 60)
            {
                Console.WriteLine("F");
            }
            else if(grade < 70)
            {
                Console.WriteLine("D");
            }
            else if(grade < 80)
            {
                Console.WriteLine("C");
            }
            else if(grade < 90)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("A");
            }

            Console.WriteLine("3.1.4. switch Statements");
            //These are available in   C#.
            // These are not as powerful as "else if" statements because the "switch"
            //statement can only be compared for equality in a small number of cases.

            Console.WriteLine("Enter an Integer: ");
            string dayString = Console.ReadLine();
            int dayNum = int.Parse(dayString);

            string day;
            switch (dayNum)
            {
                case 0:
                    day = "Sunday";
                    break;
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thusday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                default:
                    // in this example, this block runs if none of the above blocks match
                    day = "Int does not correspond to a day of the week";
                    break;
            }
            Console.WriteLine(day);

            //Here’s how the above example looks using the else if construction:
            Console.WriteLine("Enter an integer: ");
            string dayString2 = Console.ReadLine();
            int dayNum2 = int.Parse(dayString);

            string day2;
            if (dayNum2 == 0)
            {
                day2 = "Sunday";
            }
            else if (dayNum2 == 1)
            {
                day2 = "Monday";
            }
            else if (dayNum2 == 2)
            {
                day2 = "Tuesday";
            }
            else if (dayNum2 == 3)
            {
                day2 = "Wednesday";
            }
            else if (dayNum2 == 4)
            {
                day2 = "Thursday";
            }
            else if (dayNum2 == 5)
            {
                day2 = "Friday";
            }
            else if (dayNum2 == 6)
            {
                day2 = "Saturday";
            }
            else
            {
                day2 = "Int does not correspond to a day of the week";
            }
            Console.WriteLine(day2);




        }
    }
}
