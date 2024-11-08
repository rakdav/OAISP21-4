try
{
    Console.Write("Введите m:");
    double m = double.Parse(Console.ReadLine());
    double N = m * m + 2.8 * Math.Abs(m) + 0.55;
    Console.WriteLine($"N={N:F2}");
}
catch
{
    Console.WriteLine("Правильно введите данные");
}