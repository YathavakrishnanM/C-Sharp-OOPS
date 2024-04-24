using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesandMethods
{
    public abstract class Employee //abstract class
    {
        //Abstract class - partial abstraction.
        //It has fields ,propertys,methods,constructors,destructors,indexers,events.
        //can have both abstract declaration and normal definitions.
        //can only usedd with an inherited class
        //not support multiple inheritance
        // it cannot be static class

        //normal field
        protected string _name;

        //abstract property

        public abstract string Name{get;set;}

        //Normal property

        public double Amount{get;set;}

        
        //Normal method
        public string Display(){
            return _name;
        }

        //abstract method

        public abstract double Salary(int dates);//only declaration

    }
}