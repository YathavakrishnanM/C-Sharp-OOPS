using System;
namespace AbstractClassesandMethods;

class Program{
    public static void Main(string[] args)
    {
        Syncfusion company1=new Syncfusion();
        company1.Name="yathav";
        Console.WriteLine(company1.Display());
        Console.WriteLine(company1.Salary(30));


        Zoho company2=new Zoho();
        company2.Name="krish";
        Console.WriteLine(company2.Display());
        Console.WriteLine(company2.Salary(30));
    }
}