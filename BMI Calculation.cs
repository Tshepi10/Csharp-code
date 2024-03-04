using System;

class Program
{
    static void Main(string [] args)
{
    Console.WriteLine("Enter Weight(Kg):");
    double Weight =Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter Height(m):");
    double Height =Convert.ToDouble(Console.ReadLine());
    

    double bmi = Weight/(Height*Height);
    

     

if(bmi <16)
{ 
    Console.WriteLine("Your BMI is {0} - Severe Underweight",bmi);
}
else if(bmi >=16 && bmi <18.5)
{
   Console.WriteLine("Your BMI is {0} - Underweight",bmi);
}
if(bmi >=18.5 && bmi <25)
{
    Console.WriteLine("Your BMI is {0} - Normal",bmi);
}
else if(bmi >=25 && bmi <30)
{
    Console.WriteLine("Your BMI is {0} - Overweight",bmi);
}
else if(bmi >=30 && bmi <40)
{
    Console.WriteLine("Your BMI is {0} - Obese",bmi);
}
else if(bmi >40)
{
    Console.WriteLine("Your BMI is {0} - Go To The Doctor",bmi);
}



}//main method
}//class
