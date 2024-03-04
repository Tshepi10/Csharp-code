using System;

class Program
{
    static void Main(String [] args)
    { 
        
       Console.WriteLine("Enter length:");
        int length = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Enter breadth:");
        int breadth = Convert.ToInt16(Console.ReadLine());
        
        int area = length * breadth;
        int perimeter = 2*(length + breadth);
        
        Console.WriteLine("The area is {0}m squared", area);
        Console.WriteLine("The perimeter is {0}m",perimeter);
        
    

    }//main method
}//class