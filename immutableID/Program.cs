
using System;
namespace Immutable
{
    class Student
    {
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }
            public static void Main()
            {
                // create student object using constructor with ID only
                Student student1 = new Student(101, "", "");
                student1.FirstName = "Harry";
                student1.LastName = "Potter";

                // create student object using parameterized constructor
                Student student2 = new Student(102, "Ron", "Weasley");

                // print out student information
                Console.WriteLine("Student 1: ID={0}, Name={1} {2}", student1.Id, student1.FirstName, student1.LastName);
                Console.WriteLine("Student 2: ID={0}, Name={1} {2}", student2.Id, student2.FirstName, student2.LastName);
            }
    }
}