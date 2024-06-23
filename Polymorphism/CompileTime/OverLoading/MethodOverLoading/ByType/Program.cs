using System;
namespace ByType;

class Program{
    public static void Main(string[] args)
    {
        //Add method to add integer
        int result=Add(1,2);
        double result2=Add(5,5.0);
        string result1=Add("ABC","DEF");

        
        
    }
    public static int Add(int a,int b){
        return a+b;
    }
    public static double Add(double a,double b){
        return a+b;
    }

     public static string Add(string a,string b){
        return a+b;
    }
}