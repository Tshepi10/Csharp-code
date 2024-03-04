using System;

class Program
{
    static void Main(String [] args)
    
{
    Console.WriteLine("Enter Number 1:");
    int num1 =Convert.ToInt16(Console.ReadLine());
    
    Console.WriteLine("Enter Number 2:");
    int num2 = Convert.ToInt16 (Console.ReadLine());
    
    Console.WriteLine("Sum:{0}",sumMethod(number1,number2));
    Console.WriteLine("Difference:{0}",differenceMethod(number1,number2));
    Console.WriteLine("Product:{0}",productMethod(number1,number2));
    Console.WriteLine("Quotient:{0}",qoutMethod(number1,number2));
    
    
}//main method

static int sumMethod(int num1, int num2)
{
    return num1+num2;
}
static int differenceMethod (int num1, int num2)
{
    return num1-num2;
}
static int productMethod(int num1, int num2)
{
    return num1*num2;
}
static int quotientMethod(int num1, num2)
{
    return num1/num2;
}


        


