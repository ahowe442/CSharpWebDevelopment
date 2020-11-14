using System;
namespace _2._5._2_ClassesAndObjects_Part2_Notes
{
    //We have two class in the FinalFields project.  (Final Fields and FortyTwo)
    public class FinalFields
    {
        public readonly int intValue = 42;
        public readonly double doubleVaule;
        public readonly FortyTwo objectVaule = new FortyTwo();
        public FinalFields()
        {
        }
    }

    public class FortyTwo
    {
        public int intValue = 42;
    }
}
