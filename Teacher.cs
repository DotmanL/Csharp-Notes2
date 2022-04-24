using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp2
{
    /// <summary>
    /// Example class to show inheritance from the base class of Person
    /// All properites and methods of the Person class now belongs to the Teacher class also
    /// </summary>
    public class Teacher : IPerson
    {

        //Commented out to implement the properties and method with the IPerson interface
        //public string Subject { get; set; }
        //public override string GetDetails() => $"{FullName} of age {Age} Subject={Subject}";

        public string Subject { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public string GetDetails() => $"{FullName} of age {Age}";
        public string GetDetails(double height) => $"{FullName} of age {Age} Subject={Subject}";
    }
}
