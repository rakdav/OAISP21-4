Console.Write("Введите длину прямоугольника:");
double height = double.Parse(Console.ReadLine());
Console.Write("Введите ширину прямоугольника:");
double width = double.Parse(Console.ReadLine());
Triangle triangle = new Triangle("Прямоугольник",width, height);
triangle.Print();
Console.Write("Введите высоту призмы:");
double length = double.Parse(Console.ReadLine());
Prizma prizma = new Prizma("Призма",width, height, length);
prizma.Print();
class Triangle
{
    public string Name { get; set; }
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
    public Triangle(string name,double width, double height)
    {
        Name = name;
        Width = width;
        Height = height;
    }
    public double GetArea() => width * height;
    public double GetPerimetr() => 2 * (width + height);
    public void Print() => Console.WriteLine($"{Name}.Ширина:{Width} м, длина:{Height} м," +
        $" площадь:{GetArea():F2} кв.м, периметр:{GetPerimetr():F2} м");
}
class Prizma : Triangle
{
    private double length;
    public double Length
    {
        get => length;
        set { if (value > 0) length = value; }
    }
    public Prizma(string name, double width, double height,double length):
        base(name,width,height)
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
    public new void Print() => Console.WriteLine($"{Name}.Ширина:{Width} м, длина:{Height} м," +
        $" высота:{Length} м, площадь:{GetArea():F2} кв.м, периметр:{GetPerimetr():F2} м");
}
