using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentID=1000;

        public string StudentID{get;}

        public int Standrad{get;set;}

        public string YearOFJoin{get;set;}

        public StudentDetails(string userID,string name,string fatherName,Gender gender,long mobilNumber,int standrad,string yearOFJoin):base(userID,name,fatherName,gender,mobilNumber){
            s_studentID++;

            StudentID="SID"+s_studentID;
            Standrad=standrad;
            YearOFJoin=yearOFJoin;
            Name=name;
        }
         public StudentDetails(string studentID,string userID,string name,string fatherName,Gender gender,long mobilNumber,int standrad,string yearOFJoin):base(userID,name,fatherName,gender,mobilNumber){
            

            StudentID=studentID;
            Standrad=standrad;
            YearOFJoin=yearOFJoin;
            
        }
    }
}