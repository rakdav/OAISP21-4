//базовый уровень
Console.WriteLine("┌---------------------------------------┐");
Console.WriteLine($"|        x          |         y         |");
Console.WriteLine("|---------------------------------------|");
for (double x = 1.1; x <=3.1; x+=0.2)
{
    double y = 3 * x - 2 * Math.Log(x) - 5;
    Console.WriteLine($"|       {x,-5:F2}       |       {y,5:F2}       |");
}
Console.WriteLine("└---------------------------------------┘");
Console.WriteLine();
//средний уровень
Console.WriteLine("┌---------------------------------------┐");
Console.WriteLine($"|        x          |         y         |");
Console.WriteLine("|---------------------------------------|");
for (double x = -Math.PI/4; x <= Math.PI/4; x += 0.2)
{

    double y;
    if (x > 2.5) y = Math.Cos(2.3 * x - 1);
    else if (x >= 0 && x <= 2.5) y = 3 * Math.Log(1 - x * x * x);
    else y = x * x;
    Console.WriteLine($"|       {x,-5:F2}       |       {y,5:F2}       |");
}
Console.WriteLine("└---------------------------------------┘");
//высокий уровень
Console.WriteLine("┌---------------------------------------┐");
Console.WriteLine($"|        x          |         y         |");
Console.WriteLine("|---------------------------------------|");
for (double x = -1; x <= 2; x += 0.3)
{
    double y=0;
    if (x > 0)
    {
        for (int k = 1; k <= 5; k++) y += Math.Pow(x, k) / (15 - k * k);
    }
    else y = Math.Exp(3.5*x);
    Console.WriteLine($"|       {x,-5:F2}       |       {y,5:F2}       |");
}
Console.WriteLine("└---------------------------------------┘");
Console.WriteLine();
