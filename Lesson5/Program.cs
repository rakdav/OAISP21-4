try
{
    Console.Write("Введите x:");
    double x=double.Parse(Console.ReadLine());
    Console.Write("Введите y:");
    double y=double.Parse(Console.ReadLine());
    Console.WriteLine((y<=Math.Sqrt(x))&&(x<=1));
}
catch
{
    Console.WriteLine("Введите корректные данные");
}
