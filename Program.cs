using System;

namespace LearningCsharp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Structure is value type data type, we use struct to create structures,
            //structures are used to represent a key word
            //we use struct because thy are faster than classes,
            // generally structs are great for game programming.
            // They are not the best for transporting data, structures can have methods, fields, indexers
            // properties, operator methods and events. They can have defined constructors and not destructors
            //Structures can implement one or more interfaces
            // They cannot inherit from other structures or classes.
            // cannot be used a base for other structures or classes
            // memebers cannot be specified as abstract, virtual or protected

            Student s1 = new Student();
            s1.FirstName = "Oladotun";
            s1.LastName = "Lawal";
            s1.Grade = 20;
            
            Student s2;
            s2 = new Student();
            s2.FirstName = "Ayodeji";
            s2.LastName = "lawal";
            s2.Grade = 10;



            Console.WriteLine($"{s1.FirstName} {s1.LastName} - {s1.Grade}");
            Console.WriteLine($"{s2.FirstName} {s2.LastName} - {s2.Grade}");


            Student s3 = new Student("Nurudeen", "Olalemi", 30);
            s3.ShowStudent();

        }
    }
}
