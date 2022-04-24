using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp2
{
    public struct Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }


        //defined constructor

        public Student (string fName, string lName, int grade)
        {
            FirstName = fName;
            LastName = lName;
            Grade = grade;
        }

        public void ShowStudent()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Grade}");
        } 
    }
}
