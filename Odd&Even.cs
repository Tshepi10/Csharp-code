using System;

class Program
{
    static void Main (String [] args)
    {
        Console.WriteLine("Enter numbers, and the program will end when an odd number is entered");
        int userInput =0;

        while(userInput % 2 == 0)
    {
    Console.WriteLine("Enter A Number:");
    userInput = Convert.ToInt16(Console.ReadLine());

    if(userInput % 2 == 0)
    {
        Console.WriteLine("Try again, Please enter an odd number");
    }

    }//while
{
        Console.WriteLine("You've entered the odd number {0}, program end!",userInput);

    }
    
}//main method
}//class

        


