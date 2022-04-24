using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp2
{
  public class Circle
    {
        //A class has the following
        //Access Modifiers -  used to define the accesbility of a class and its memebers
        //Fields -- is class level variable that can hold a value
        //Constructors -- are called when we create an instance of a class
        //Methods -- used to execute certain instructions
        //Properties -- used to encaspulate a private field

        private const double PI = Math.PI;

        //Property
        public double Radius { get; set; }


        //public Circle() is a constructor on the public class
        public Circle()
        {
            Console.WriteLine("Circle() created");
        }

        //another constructor taking radius as a parameter   
        public Circle(double radius)
        {
            Radius = radius;
        }

        //methods
        public double GetArea() => PI * Math.Pow(Radius, 2);
        public double GetPerimeter() => 2 * PI * Radius;

    }
}
