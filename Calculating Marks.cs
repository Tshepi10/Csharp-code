using System;

class Program
{
    static void Main(String [] args)
{
    Console.WriteLine("Enter mark for English:");
    int m1 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Enter mark for Mathematics:");
    int m2 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Enter mark for Science:");
    int m3 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Enter mark for Economics:");
    int m4 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Enter mark for Accounting:");
    int m5 = Convert.ToInt16(Console.ReadLine());

     Console.WriteLine("Total:{0}",sumMethod(m1,m2,m3,m4,m5));



    int total = m1+m2+m3+m4+m5;
    
   if(total>0 && total<=250)
    {
        Console.WriteLine("Fail",total);
    }
    else if(total>=250 && total<=500)
    {
        Console.WriteLine("Pass",total);
    }

   

}//main method

    static int sumMethod(int m1, int m2, int m3, int m4, int m5)
{
    return m1+m2+m3+m4+m5;
}

 


}//class

