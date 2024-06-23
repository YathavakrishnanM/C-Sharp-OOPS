using System;
using MultiLevelInheritance;
namespace Inheritance;

class Program{
    public static void Main(string[] args)
    {
        PersonalDetails person=new PersonalDetails("yathav","mohan",Gender.Female,8925317233);

        System.Console.WriteLine($"|  {person.UserID}  |  {person.Name}  |  {person.FatherName}  |  {person.Gender}  |  {person.MobileNumber}  |");
    
        StudentDetails student=new StudentDetails(person.UserID,person.Name,person.FatherName,person.Gender,person.MobileNumber,2,"2022");
        System.Console.WriteLine($"|  {student.UserID}  |  {student.StudentID}  |  {student.Standrad}  |  {student.Name}  |  {student.FatherName}  |  {student.Gender}  |  {student.MobileNumber}  |");


        EmployeeDetails employee=new EmployeeDetails(student.StudentID,person.UserID,person.Name,person.FatherName,person.Gender,person.MobileNumber,student.Standrad,student.YearOFJoin,"Enginner");

        Console.WriteLine($"|  {employee.EmployeeID}  |  {employee.StudentID}  |  {employee.UserID}  |  {employee.Name}");
    }
}