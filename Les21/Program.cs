Console.Write("Введите длину ");
class Triangle
{
    private double width;
    public double Width
    {
        get => width;
        set { if (value > 0) width = value; }
    }
    private double height;

    public double Height
    {
        get => height;
        set { if (value > 0) height = value; }
    }
    public Triangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double GetArea() => width * height;
    public double GetPerimetr() => 2 * (width + height);
}
class Prizma : Triangle
{
    private double length;
    public double Length
    {
        get => length;
        set { if (value > 0) length = value; }
    }
    public Prizma(double width, double height,double length):base(width,height)
    {
        Length = length;
    }
    public new double GetArea()
    {
        return 2 * base.GetArea() + 2 * Length *(Width + Height);
    }
    public new double GetPerimetr()
    {
        return 2 * base.GetPerimetr() + 4 * Length * (Width + Height);
    }
}
