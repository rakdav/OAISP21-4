using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

var tuple1 = (5, 10);
Console.WriteLine(tuple1.Item1);
Console.WriteLine(tuple1.Item2);
tuple1.Item1 += 28;
Console.WriteLine(tuple1.Item1);
(int, int) tuple2 = (12, 18);
(string, int, double) person = ("Tom", 23, 56.0);
var tuple3 = (count: 3, sum: 10);
Console.WriteLine(tuple3.count);
Console.WriteLine(tuple3.sum);
var (name, age) = ("Jerry", 10);
Console.WriteLine(name);
Console.WriteLine(age);

int a = 7;
int b = 10;
Console.WriteLine(a+" "+b);
(a, b) = (b, a);
Console.WriteLine(a + " " + b);

Random random = new Random();
int[] mas = new int[10];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10, 100);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
for (int i = 0; i < mas.Length-1; i++)
{
    for (int j =i+1 ; j < mas.Length; j++)
    {
        if (mas[i] > mas[j]) 
            (mas[i], mas[j]) = (mas[j], mas[i]);
    }
}
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i] + " ");
}
Console.WriteLine();

int Max(int[] mas)
{
    int max = mas[0];
    for (int i = 1; i < mas.Length; i++)
    {
        if (mas[i] > max) max = mas[i];
    }
    return max;
}
int Min(int[] mas)
{
    int min = mas[0];
    for (int i = 1; i < mas.Length; i++)
    {
        if (mas[i] < min) min = mas[i];
    }
    return min;
}

(int max,int min) GetMaxMin(int[] mas)
{
    int min = mas[0];
    int max = mas[0];
    for (int i = 1; i < mas.Length; i++)
    {
        if (mas[i] < min) min = mas[i];
        if (mas[i] > max) max = mas[i];
    }
    return (max,min);
}

var maxMin = GetMaxMin(mas);
Console.WriteLine("max="+maxMin.max);
Console.WriteLine("min="+maxMin.min);