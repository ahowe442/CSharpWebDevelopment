﻿using System;

namespace _4._7._ClassesAndObjects_Exercises
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TOD: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double qualityScore = (grade * courseCredits);

            Gpa = qualityScore / NumberOfCredits;
            NumberOfCredits = NumberOfCredits + 3;
        }

        //TOD: Complete the GetGradeLevel method here:
        // Determine the grade level of the student based on NumberOfCredits
        public string GetGradeLevel(int credits)
        {
            if (credits >= 0 && credits <= 29)
            {
                return "Freshman";
            }
            else if (credits >= 30 && credits <= 59)
            {
                return "Sophmore";
            }
            else if (credits >= 60 && credits <= 89)
            {
                return "Junior";
            }
            else if (credits >= 90)
            {
                return "Senior";
            }
            else
            {
                return "Grade Level TBD";
            }
        }
        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        public override string ToString()
        {
            return Name + "(\nName: " + Name + "\nCredits: " + NumberOfCredits + "\nGPA: " + Gpa + "\nStudent ID: " + StudentId + ")";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.


        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId);
        }



    }
}
