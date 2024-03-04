using System;

class Program
{
        static void Main(String [] args)
    {
        Console.WriteLine();
        Console.WriteLine("WELCOME TO EMMAS CURRENCY CONVERTER");
        Console.WriteLine();
        
        {
        Console.WriteLine("Please Enter Amount in Rands:");
        double rands = Convert.ToDouble(Console.ReadLine());
        
        double dollars = rands/19.43;
        
        Console.WriteLine("Dollar Value: ${0}",dollars);
        }

}//main method
}//class

