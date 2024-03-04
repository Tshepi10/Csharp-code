using System;

class Program
{
    static void Main(String [] args)
{
    Console.WriteLine("Enter mark for English:");
    double m1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter mark for Mathematics:");
    double m2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter mark for Science:");
    double m3 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter mark for Economics:");
    double m4 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter mark for Accounting:");
    double m5 = Convert.ToDouble(Console.ReadLine());

    
    double sum = m1+m2+m3+m4+m5;

    double total = sum/500 * 100;
    
    
   if(total>=0 && total<=49)
    {
        Console.WriteLine("You got {0}%----F",total);
    }
    else if(total>=50 && total<=59)
    {
        Console.WriteLine("You got {0}%----E",total);
    }
    else if(total>=60 && total<=69)
    {
        Console.WriteLine("You got {0}%----D",total);
    }

    else if(total>=70 && total<=79)
    {
        Console.WriteLine("You got {0}%---C",total);
    }

 else if(total>=80 && total<=89)
    {
        Console.WriteLine("You got {0}%---B",total);
    }
     else if(total>=90 && total<=100)
    {
        Console.WriteLine("You got {0}%---A",total);
    }
    

}//main method

}//class

        


