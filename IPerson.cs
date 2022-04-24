using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp2
{
  public interface IPerson
    {
        string FullName { get; set; }
         int Age { get; set; }


      //interfaces can't contain private memebers, all the memebers are public by default, so no nned of the public access modifier
         string GetDetails();


        //overloading method
         string GetDetails(double height); 

    }
    public interface ITest
    {
        void Test();
    }
}
