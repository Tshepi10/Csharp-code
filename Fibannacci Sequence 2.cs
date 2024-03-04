using System;

class Program
{
    static void Main(String [] args)
    { 
        Console.WriteLine("Enter Number of terms in Sequence:");
        int n = Convert.ToInt16(Console.ReadLine());
        
        int a = 0;
        int b = 1;
        
        
        for(int i=0; i<n; i++)
        {
	    Console.Write(a+",");
            int c = a+b;
            a = b;
            b = c;
        }

    }//main method
}//class

