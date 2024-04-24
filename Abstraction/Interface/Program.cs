using System;
namespace Interface;

class Program{
    public static void Main(string[] args)
    {
        Square objecct=new Square();

        System.Console.WriteLine(objecct.Number=1000); 
        System.Console.WriteLine(objecct.Calculate()); 

        Circle  circle=new Circle();
        System.Console.WriteLine(circle.Number=4);
        System.Console.WriteLine(circle.Calculate());
    }
}