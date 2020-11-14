using System;
namespace _2._5._2_ClassesAndObjects_Part2_Notes
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; }
        public Course()
        {
        }
        //Practice Visual Studio Generator Shortcut
        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Topic == course.Topic &&
                   System.Collections.Generic.EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Topic, Instructor);
        }
    }
}
