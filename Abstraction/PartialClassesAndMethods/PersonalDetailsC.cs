using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    public partial class PersonalDetails
    {
        //method definition

        public partial int CalculateAge(){
            return Age;
        }
    }
}