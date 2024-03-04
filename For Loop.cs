using System;

class Program
{
    static void Main(String [] args)
{
    Console.WriteLine("Enter Amount of Number to Calculate:");
    int amount = Convert.ToInt16(Console.ReadLine());
    int sum = 0;
    int prod =0;
    int quot =0;

 
     for (int i = 1; i <= amount; i++) 
{
  Console.WriteLine("Enter amount of number {0}:",i);
  int num = Convert.ToInt16(Console.ReadLine());

  sum = num + num;
  prod = sum*num;
  quot = prod/num;
  Console.WriteLine("Sum  :{0}",sum);
  Console.WriteLine("Prod :{0}",prod);
  Console.WriteLine("Quot :{0}",quot);
}


}//main method
}//class

