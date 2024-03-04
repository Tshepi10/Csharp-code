using System;

class Program
{
    static void Main (String [] args)
    {
        int secretNo = 7;
        int userInput = 0;

        while(userInput != secretNo)
    {
    Console.WriteLine("Enter Number 1-10 to WIN:");
    userInput = Convert.ToInt16(Console.ReadLine());

    if(userInput != secretNo)
    {
        Console.WriteLine("Try again, Please Enter Valid secretNo");
    }

    }//while
{
        Console.WriteLine("You've entered the secretNo {0}, You've won R10000",userInput);

    }
    
}//main method
}//class

