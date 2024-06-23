using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inheritance;

namespace HieraricalInheritance
{
    public class CustomerDetails:PersonalDetails
    {
        private static int s_customerID=2000;

        public string CustomerID{get;}

        public double Balance{get;set;}

        public CustomerDetails(string userID,string name,string fatherName,Gender gender,long mobilNumber,double balance):base(userID,name,fatherName,gender,mobilNumber){
            s_customerID++;

            CustomerID="CID"+s_customerID;
            Balance=balance;
        }
    }
}