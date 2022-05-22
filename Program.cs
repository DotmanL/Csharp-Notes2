using System;
using System.Text;
using System.Collections;

namespace LearningCsharp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Structure is value type data type, we use struct to create structures,
            //structures are used to represent a record
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

            //Enum is a value type data type used to declare a list of named inetger constants,
            //defined using Enum in a namespace, class or structure
            //enum cannot be used with the string type 
            //Enum is an abstract class with methods like
            //GetName--(returns name of the constant of the specified value of specified enum,
            //GetNames--(array of string name of all constant of the specified enum,
            //TryParse-(converts the streing representation of the name or numeric value of
            //one or more enumerated constants to an equivalent enumerated object).
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Friday);

            Console.WriteLine("GetName()");
            Console.WriteLine(Enum.GetName(typeof(WeekDays), 5));
            
            Console.WriteLine("GetNames()");
            foreach(string str in Enum.GetNames(typeof(WeekDays)))
            Console.WriteLine(str);
            
            Console.WriteLine("TryParse()");
            WeekDays wdEnum;
            Enum.TryParse<WeekDays>("1", out wdEnum);
            Console.WriteLine(wdEnum);


            //StringBuilder
            //A string object is immutable.

            string hello = "Hello World";
            var hi = hello;
            hello = "Hi there!";
            Console.WriteLine(ReferenceEquals(hello, hi));

            //A stringBuilder is a dynmaic object that allows expnads the number of character in a string
            //without creaitng a new object but dynamically expand the memory to acoomodate the modified string

            StringBuilder sb = new StringBuilder("this is a string builder");
            var sbNew = sb;
            sb.Append("this is Additional");
            Console.WriteLine(ReferenceEquals(sb, sbNew));

            //methods of StringBuilder -- Append, AppendFormat, Insert, Remove and Replace.
            //StringBuilder is mutable, performs faster when appending multiple sting values, initalize StingBuilder as class
            // Use StringBuidler when you need to append more than three or four strings, use ToString to get string from StringBuilder

            StringBuilder sbBuilder = new StringBuilder();
            sbBuilder.Append("I have ");
            sbBuilder.AppendFormat("{0:C}", 25);
            sbBuilder.Insert(0, "Dotun: ");
            sbBuilder.Remove(0, 2);
            sbBuilder.Replace("have", "had");
            Console.WriteLine(sbBuilder);

            //Arrays -- is a group of variable of the same type, intitalize and define the length of the array,
            //eg: with length [5] and initialize with new keyword
            //size must be specified while initialization, can be single dimensional

            int[] numbers = new int[5];
            numbers[0] = 20;
            numbers[1] = 9;
            numbers[2] = 1;
            numbers[3] = 28;
            numbers[4] = 5;

            Array.Sort(numbers);

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            string[] studentNames = new string[10];
            double[] studentResults = new double[4]
            {
                5, 6.5, 10, 11
            };

            //Classes-- is like a blueprint of a specific object

            //one way of instantiating the constructor
            //Circle c1 = new Circle();
            //c1.Radius = 5;
            //c1.GetArea();

            Circle c1 = new ()
            {
                Radius = 5
            };
            c1.GetArea();
            double a1 = c1.GetArea();
            Console.WriteLine(a1);


            //new exprrssion is simplified below
            //Circle c2 = new Circle(5);
            //c2.GetArea();

            Circle c2 = new(5);
            c2.GetArea();
            double a2 = c1.GetArea();
            Console.WriteLine(a2);


            //Inheritance and Polymorphism 
            //Inheritance is used to make application faster and simpler, we can build several types
            // based on a single abstraction, utlimate base class is the object class, 

            //properties for each of the objet, both base and child classes
            Person person = new() { FullName = "john doe", Age = 25 };
            Console.WriteLine(person.GetDetails());
            Teacher teacher = new() { FullName = "peter doe", Age = 45, Subject="maths" };
            Console.WriteLine(teacher.GetDetails());
            Parents parents = new() { FullName = "Mr doe", Age = 55, Occupation="footballer" };
            Console.WriteLine(parents.GetDetails());

            //Polymorphism - means having many forms, eg: reusing the method defined in the person class 
            // in other child classes but with modifications, a method can be defined more than one time.
            // Types of polymorphism- Method overloading and method overiding
            // Overloading- is having the same class methods with the same name but different signature
            //Overlading method example --- check person class
            //Overriding is have a child and parent class methods with the same name and signature but diffrent outcome
            //use the vitrual keyword, check person and teacher class for the implementation of this.

            //Interface-- we cannot inherit from multiple classes,not posssible to have multiple base classes.
            // Intefraces come into play here, Interface define properties, method and evnts which are members of that interface
            //interfaces contain only declaration of the members -- see example with an interface created for the person class used in
            // teacher and parents class , you can inherit from multiple interfaces, check example in Parents class

            //COLLECTIONS-- are similar to aarays, but more flexible, in arrays you need to define the number of elements,
            // in collection, you don't need to , you can remove and add elements at any point also.
            //Every collection class implements the IEnumerable interface. Values from the collection can be accessed using the foreach loop.
            // Tweo types of collection,
            // 1) Generic - Lists(eg: Bookstore). items of similar types
            // 2) Non Generic -Array Lists (Ex: Supermarket) -- items of differnt types.

            // Systems.Collections namespace includes five non-generic collections
            // ArrayList- stires objects of any type like an array
            // SortedList - stores keys and value pairs
            // Stack - stores the values in LIFO style, (LAST IN FIRST OUT)
            // Queue - stores the values in FIFO style (FIRST IN FIRST OUT)

            // Hashtable - stores key and value pairs



            //Array Lists -- non gernic type of collection, it grows automatically, no need to specify the size of ann array list

            ArrayList myValues = new ArrayList();
            //myValues.Add(10);
            //myValues.Add("This is a string");
            //myValues.Add(12.25);

            //myValues.AddRange(new ArrayList() { "Dotun", 23, 76, 72.35 });

            //myValues.Insert(0, "This is the first value");
            //myValues.Insert(1, "This is the second value");

            //myValues.Remove("This is the first value");
            //myValues.RemoveRange(0, 2);
            //myValues.RemoveAt(0);

            //IMPLEMENTING SORT, values must have the same data type when using sort or reverse
            myValues.Add(12);
            myValues.Add(13);
            myValues.Add(11);
            myValues.AddRange(new ArrayList() { 5, 7,  4, 9, 23, });

            myValues.Sort();
            myValues.Reverse();
            
            Console.WriteLine($"12 exists in the array - {myValues.Contains(12)}");
            myValues.Clear();
            

            //ArrayList allocates memories for items in four, ie: memory for items are allocated, when a 5th item is added, memory for another 4items are added


            foreach (var value in myValues)
            {
                Console.WriteLine(value);
            }

            //Sorted Lists -- stores key-value pairs in the ascending order of  the key, elements can accessed by key and index
            // cannot have different key types
            
            SortedList sl1 = new SortedList();
            sl1.Add("3", "Number Three");
            sl1.Add("4", "Number Four");
            sl1.Add("1", "Number One");
            sl1.Add("5", "Number Five");
            sl1.Add("2", "Number Two");

            string specificValue = (string)sl1["4"];
            Console.WriteLine($"Value: {specificValue}");

           // sl1.Remove("4");
            sl1.RemoveAt(0);

            Console.WriteLine($"Contains() - {sl1.Contains("3")}");
            Console.WriteLine($"ContainsKey() - {sl1.Contains("4")}");

            //Better alternative to the for loop below
            foreach (DictionaryEntry element in sl1)
            {
                Console.WriteLine($"Key :  {element.Key}, Value: {element.Value}");
            }
   

            //for (int i = 0; i < sl1.Count; i++)
            //{
            //    Console.WriteLine($"Key :  {sl1.GetKey(i)}, Value: {sl1.GetByIndex(i)}");
            //}

            //Stack - stores elements in LIFO style, last in, first out


        }
        enum WeekDays
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

    }
}
