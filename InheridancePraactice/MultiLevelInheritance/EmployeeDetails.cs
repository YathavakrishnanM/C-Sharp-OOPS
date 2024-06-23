using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inheritance;

namespace MultiLevelInheritance
{
    public class EmployeeDetails:StudentDetails
    {
        private static int s_employeeID=1000;

        public string EmployeeID{get;}

        public string Desigination{get;set;}

        public EmployeeDetails(string studentID,string userID,string name,string fatherName,Gender gender,long mobilNumber,int standrad,string yearOFJoin,string desigination):base(studentID,userID,name,fatherName,gender,mobilNumber,standrad,yearOFJoin
        ){
                s_employeeID++;

                EmployeeID="EID"+s_employeeID;
                Desigination=desigination;
        }
    }
}