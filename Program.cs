using System;

class Rectangle
{
    private double length;
    private double width;

    
    public Rectangle()
    {
        length = 0;
        width = 0;
    }

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    
    public double GetArea()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + GetArea());
    }
}
