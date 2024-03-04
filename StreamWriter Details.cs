using System;
using System.IO;

class Program
{
    static void Main(string []args)
    {
        string filepath = "Username , password, age and email address";

        using(StreamWriter sw = new StreamWriter(filepath))
        {
            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter your email address: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the year you were born: ");
            int yearOfbirth = Convert.ToInt16(Console.ReadLine());

            int age = 2023 - yearOfbirth;
            
            Console.WriteLine("Enter Gender Male/Female:" );
            string Gender = Console.ReadLine();

            Console.WriteLine("Enter Your ID number");
            string ID = Console.ReadLine();

           
            sw.WriteLine("Your username is: {0}",username);
            sw.WriteLine("Your password is: {0}",password);
            sw.WriteLine("Your email address is: {0}",email);
            sw.WriteLine("Your age is: {0}",age);
            sw.WriteLine("Gender: {0}",Gender);
            sw.WriteLine("Your identification number is: {0}",ID);
            Console.WriteLine();


        }//

        using(StreamReader sr = new StreamReader(filepath))
        {
            string line;
            Console.WriteLine("Reading file : {0}",filepath);

            while((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        Console.WriteLine("Read file {0} complete!",filepath);
        Console.WriteLine();

    }//Main method
}//class


        


