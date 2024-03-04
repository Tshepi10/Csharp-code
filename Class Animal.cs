using System;

class Animal
{
    public string name {get; set;}
    public int age {get; set;}
    
    public void Eat()
{
    Console.WriteLine("{0} is eating!",name);
}
}

class Dog : Animal
{
    public void Bark ()
    {
    Console.WriteLine("{0} is barking!",name);
    }
}

class Program
{
static void Main(string [] args)
{
    Dog myDog = new Dog();
    myDog.name = "Buddy";
    myDog.age = 4;
    
    Console.WriteLine("{0} is {1} years old",myDog.name,myDog.age);
    myDog.Eat();
    
    myDog.Bark();
    
    Console.ReadLine();
    
}//main method
}//class

