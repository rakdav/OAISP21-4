//базовый уровень
//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    for (int i = 10; i <=n; i++)
//    {
//        int min = int.MaxValue;
//        int m = i;
//        while (m != 0)
//        {
//            int temp = m % 10;
//            if (temp < min) min = temp;
//            m /= 10;
//        }
//        Console.WriteLine($"{i}-{min}");
//    }
//}
//catch(Exception ex) 
//{
//    Console.WriteLine(ex.Message);
//}

//средний уровень

try
{
    Console.Write("Введите k:");
    int k = int.Parse(Console.ReadLine());
    double p = 1;
    for (int j = 1; j <= k; j++)
        if (j != 3&&j!=4) p *= (j - 4) * j / (j - 3);
    double s = 0;
    for (int i = 1; i <=k+1; i++)
    {
        if (i != 1) s += Math.Pow(i + 5, 1 / 3.0) / (i - 1);
    }
    double res = p * s;
    Console.WriteLine($"res={res:F2}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}