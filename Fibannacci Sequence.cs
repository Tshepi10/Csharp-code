using System;

class Program
{
    static void Main(String [] args)
    { 
        Console.WriteLine("Fibanacci Sequence:");
        
        int count = 20;
        
        int a = 0;
        int b = 1;
        
        Console.Write($"{a},{b}");
        
        for(int i=2; i<count; i++)
        {
            int c = a+b;
            Console.Write($", {c}");
            a = b;
            b = c;
        }
        Console.ReadLine();

    }//main method
}//class

