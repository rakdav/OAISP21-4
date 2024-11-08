//базовый уровень 30 вариант
//double[] mas = new double[12];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.NextDouble() * 90 + 10;
//    Console.Write($"{mas[i]:F2} ");
//}
//Console.WriteLine();
//double min = double.MaxValue;
//double imin = -1;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] < min)
//    {
//        min = mas[i];
//        imin = i;
//    }
//}
//Console.WriteLine($"{min:F2}+{imin}={min+imin:F2}");
//средний уровень 30 вариант
using System.Net.Security;

Random random = new Random();
int length = random.Next(10,20);
double[] mas1 = new double[length];
double[] mas2 = new double[length];
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.NextDouble() * 90 + 10;
    Console.Write($"{mas1[i]:F2} ");
}
Console.WriteLine();
for (int i = 0; i < mas2.Length; i++)
{
    mas2[i] = random.NextDouble() * 90 + 10;
    Console.Write($"{mas2[i]:F2} ");
}
Console.WriteLine();
double min1 = double.MaxValue;
int imin1 = -1;
for (int i = 0; i < mas1.Length; i++)
{
    if (mas1[i] < min1)
    {
        min1 = mas1[i];
        imin1 = i;
    }
}
double min2 = double.MaxValue;
int imin2 = -1;
for (int i = 0; i < mas2.Length; i++)
{
    if (mas2[i] < min2)
    {
        min2 = mas2[i];
        imin2 = i;
    }
}
Console.WriteLine($"min1={min1:F2} imin1={imin1}");
Console.WriteLine($"min2={min2:F2} imin2={imin2}");
mas1[imin1] = min2;
mas2[imin2] = min1;
foreach (double item in mas1) Console.Write($"{item:F2} ");
Console.WriteLine();
foreach (double item in mas2) Console.Write($"{item:F2} ");
Console.WriteLine();

