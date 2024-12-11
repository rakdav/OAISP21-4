Console.Write("Введите название:");
string name = Console.ReadLine();
Console.Write("Введите ширину:");
double w = double.Parse(Console.ReadLine());
Console.Write("Введите высоту:");
double h = double.Parse(Console.ReadLine());
Rectangle rectangle = new Rectangle(name,w,h);
Console.WriteLine($"Площадь:{rectangle.Width}X{rectangle.Width}={rectangle.GetArea():F2}");
Console.WriteLine($"Периметр:2*({rectangle.Width}+{rectangle.Height})={rectangle.GetPerimetr():F2}");
Console.WriteLine("Введите новую ширину:");
w = double.Parse(Console.ReadLine());
rectangle.Width=w;
Console.WriteLine($"Площадь:{rectangle.Width}X{rectangle.Width}={rectangle.GetArea():F2}");
Console.WriteLine($"Периметр:2*({rectangle.Width}+{rectangle.Height})={rectangle.GetPerimetr():F2}");

//class Rectangle
//{
//    private double width;
//    private double height;
//    public Rectangle(double _width, double _height)
//    {
//        this.width = _width;
//        this.height = _height;
//    }
//    public double GetArea()=>width * height;
//    public double GetPerimetr()=>2 * (width+height);
//    public double GetWidth() => width;
//    public double GetHeight() => height;
//    public void SetWidth(double _w) => width = _w;
//    public void SetHeight(double _h) => height = _h;
//}

class Rectangle
{
    public string Name { get; set; } 
    private double width;
    public double Width
    {
        get => width;
        set
        {
            if (value >= 0) width = value;
        }
    }
    private double height;
    public double Height
    {
        get => height;
        set
        {
            if (value >= 0) height = value;
        }
    }
    public Rectangle(string _name,double _w,double _h)
    {
        Name = _name;
        Width = _w;
        Height = _h;
    }
    public double GetArea() => width * height;
    public double GetPerimetr()=>2 * (width+height);
}
