using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICalculate
    {
        // noo fields and Constructors
        //only have properties and methods

        //property
        int Number{get;set;}   //declaration only

        int Calculate();//method-declaration it dont have definition

        //Fully abstraction - no definiton
    }
}