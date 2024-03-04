using System;

class Program
{
	static void Main(String [] args)
{

	int currentYear = 2023;

	Console.WriteLine ("Enter year of Birth:");
	int yearOfBirth = Convert.ToInt16 (Console.ReadLine());

	int age = currentYear-yearOfBirth;
	Console.WriteLine("You are {0} years old!",age);

if (age>=18)
        {
                Console.WriteLine("You are Eligible to vote!");
        }
        else
        {
                Console.WriteLine("You are Underage - Can't vote");
        }
}//main method
}//class


        


