using System.Drawing;

object[] shapes=[new Circle(2), new Rectangle(3,4), new Triangle(3,5),"hello"];
foreach(var shape in shapes)
{
    try
    {
        Console.WriteLine($"{shape.GetType().Name,-10} area={Area(shape):0.00}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

static double Area(object? shape)=>shape switch
{
  Circle c=>Math.PI*c.Radius*c.Radius,
  Rectangle {Width: var w, Height: var h}=> w*h,
  Triangle {Base: var b, Height: var h}=>0.5*b*h,
  null=> throw new ArgumentNullException(nameof(shape)),
    _=>throw new ArgumentException($"unknown Shape: {shape.GetType().Name}")
};

class Circle
{
    public double Radius {get;}
    public Circle(double radius)=>Radius=radius;
    
}

class Rectangle
{
    public double Width { get; }
    public double Height { get; }
    public Rectangle(double width, double height)=>(Width, Height)=(width,height);
}

class Triangle
{
    public double Base { get; }
    public double Height { get; }
    public Triangle(double @base, double height)=>(Base,Height)=(@base,height);
}