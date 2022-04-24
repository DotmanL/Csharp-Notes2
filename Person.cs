using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp2
{
    //Example to illustrate inheritance
    public class Person : IPerson
    {

        //Commented out to implement the properties and method with the IPerson interface

        //public string FullName {  get; set; }
        //public int Age { get; set; }


        ////public string GetDetails() => $"{FullName} of age {Age}";
        ////Overriding method -- added virtual keyword
        //public virtual string GetDetails() => $"{FullName} of age {Age}";


        ////overloading method
        //public string GetDetails(double height) => $"{FullName} of age {Age}";

        //Interface Members implemented
        public string FullName { get; set; }
        public int Age { get; set; }

        public string GetDetails() => $"{FullName} of age {Age}";
        public string GetDetails(double height) => $"{FullName} of age {Age}";
    }
}
