using System;

class Program
{
    static void Main (String [] args)
    {
        string password = "Tshepiso10" ;
        string userInput = "" ;

        while(userInput != password)
    {
    Console.WriteLine("Enter Password:");
    userInput = Console.ReadLine();

    if(userInput != password)
    {
        Console.WriteLine("Try again,Invalid Password!!");
    }

    }//while
    
        Console.WriteLine("Password {0} Valid, Login Success!",password);

    
}//main method
}//class


        


