try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите k:");
    int n = int.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 1; i <= n; i += 2)
        s += Math.Sin(i*Math.Pow(x,i));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
