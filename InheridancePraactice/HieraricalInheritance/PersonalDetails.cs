using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    public enum Gender{Male,Female,Others}
    public class PersonalDetails
    {
        //field 
        private static int s_userID=100;

        //Properties
        public string UserID{
            get;
        }
        public string Name{get;set;}

        public string FatherName{get;set;}

        public Gender Gender{get;set;}

        public long MobileNumber{get;set;} 

        //constructor

        public PersonalDetails(string name,string fatherName,Gender gender,long mobilNumber){
            s_userID++;

            UserID="UID"+s_userID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobilNumber;
        }
        public PersonalDetails(string userID,string name,string fatherName,Gender gender,long mobilNumber){
            
            UserID=userID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobilNumber;
        }

    }
}