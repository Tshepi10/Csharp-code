using System;

class Program
{
    static void Main(String [] args)
    { 
        
        Console.WriteLine("Enter A :");
        int A = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter B:");
        int B = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Enter Height:");
        int Height = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter C:");
        int C = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter D:");
        int D = Convert.ToInt16(Console.ReadLine());
        
        int area = A + B/2* Height ;
        int perimeter = A + B + C + D;
        
        Console.WriteLine("The area of Trapezium is {0}m squared", area);
        Console.WriteLine("The perimeter of Trapezium is {0}m",perimeter);
        
    

    }//main method
}//class