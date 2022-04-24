using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp2
    {
    public class Parents : IPerson, ITest
    {

        //    public string Occupation { get; set; }
        //    public override string GetDetails() => $"{FullName} of age {Age} Occupation={Occupation}";

        public string Occupation { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public string GetDetails() => $"{FullName} of age {Age}";
        public string GetDetails(double height) => $"{FullName} of age {Age} Occupation={Occupation}";

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
  
}

