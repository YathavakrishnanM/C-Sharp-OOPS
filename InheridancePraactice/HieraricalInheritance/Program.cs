using System;
using HieraricalInheritance;
namespace Inheritance;

class Program{
    public static void Main(string[] args)
    {
        PersonalDetails person=new PersonalDetails("yathav","mohan",Gender.Male,8925317233);

        System.Console.WriteLine($"|  {person.UserID}  |  {person.Name}  |  {person.FatherName}  |  {person.Gender}  |  {person.MobileNumber}  |");
    
        StudentDetails student=new StudentDetails(person.UserID,person.Name,person.FatherName,person.Gender,person.MobileNumber,2,"2022");
        System.Console.WriteLine($"|  {student.UserID}  |  {student.StudentID}  |  {student.Standrad}  |  {student.Name}  |  {student.FatherName}  |  {student.Gender}  |  {student.MobileNumber}  |");

//public CustomerDetails(string userID,string name,string fatherName,Gender gender,long mobilNumber,double balance):base(userID,name,fatherName,gender,mobilNumber){

        CustomerDetails customer=new CustomerDetails(student.UserID,student.Name,student.FatherName,student.Gender,student.MobileNumber,100.00);
    
        System.Console.WriteLine($"|  {customer.CustomerID}  |  {customer.UserID}  |  {customer.Name}  |  {customer.FatherName}  |  {customer.Gender}  |  {customer.MobileNumber}  |  {customer.Balance}  |");
    }
}