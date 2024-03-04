using System;

class Program
{
    static void Main(String [] args)
    { 
    
       Console.WriteLine("Enter b:");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter h:");
        double h = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter a:");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter c:");
        double c = Convert.ToDouble(Console.ReadLine());
        
        double area = 0.5*b*h;
        double perimeter = a+b+c;
        
        Console.WriteLine("The area is {0}m squared", area);
        Console.WriteLine("The perimeter is {0}m",perimeter);
  
    }//main method
}//class
