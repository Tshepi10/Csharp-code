using System;

class Program
{
    static void Main(String [] args)
{ 
    Console.WriteLine("Enter mark");
        int mark = Convert.ToInt16(Console.ReadLine());
        
    if(mark>=90 && mark<=100)
    {
        Console.WriteLine("A");
    }
    else if(mark>=80 && mark<=89)
    {
        Console.WriteLine("B");
    }
   else if(mark>=70 && mark<=79)
   {
       Console.WriteLine("C");
   }
   else if(mark>=60 && mark<=69)
   {
       Console.WriteLine("D");
   }
   else if(mark>=0 && mark<=59)
   {
       Console.WriteLine("F");
   }
}//main method
}//class
        


