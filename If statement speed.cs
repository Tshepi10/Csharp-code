using System;

class Program
{
    static void Main(string [] args)
{
    Console.WriteLine("Enter Speed");
    int speed =Convert.ToInt16(Console.ReadLine());
    
if (speed>10 && speed<=60)
{ 
    Console.WriteLine("No Fine");
}
else if (speed>60 && speed<=80)
{
   Console.WriteLine("R200 Fine");
}
else if (speed>80 && speed<=100)
{
    Console.WriteLine("R500 Fine");
}
else if (speed>100 && speed<=120)
{
    Console.WriteLine("R1000 Fine");
}
else
{
    Console.WriteLine("JAIL");
}


}//main method
}//class
        


