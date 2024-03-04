using System;

class Shape
{
    public void Draw()
    {
    Console.WriteLine("Drawing a shape");
    }
    public void Draw(int width, int height)
    {
Console.WriteLine("drawing a shape with width{0} and height{1}",width,height);
    }
}//shape


class Circle : Shape
{
public void Draw(int radius)
    {
    Console.WriteLine("Drawing shape with radius {0}", radius);
    }
public void area(int radius)
    {
    double area =3.142*(radius*radius);
    Console.WriteLine("The Area is {0}m sqaured",area);
    }
public void diameter(int radius)
    {
    double diameter = radius *2;
    Console.WriteLine("The Diameter is {0}m",diameter);
    }
}//circle


class Program
{
    static void Main(string [] args)
{
    
Shape s = new Shape ();
Circle circ = new Circle ();

s.Draw();
s.Draw(10,20);
circ.Draw();
circ.Draw(5);
circ.area(2);
circ.diameter(3);

Console.ReadLine();
}//main method
}//class


        


