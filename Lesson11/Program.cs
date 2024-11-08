//одномерные массивы
//int[] mas1 = { 5, 7, 2, 1, 6, 8 };
////ввод с клавиатуры
//int[] mas2 = new int[5];
//Console.WriteLine("Введите элементы массива:");
//for (int i = 0; i < mas2.Length; i++)
//{
//    try
//    {
//        Console.Write($"Введите {i + 1} элемент массива:");
//        mas2[i] = int.Parse(Console.ReadLine());
//    }
//    catch { }
//}
//for (int i = 0; i < mas2.Length; i++)
//    Console.Write(mas2[i]+" ");
//Console.WriteLine();
////генерация по формуле
//int[] mas3 = new int[10];
//for (int i = 0; i < mas3.Length; i++)
//{
//    mas3[i] = 2 * i + 1;
//    Console.Write(mas3[i]+" ");
//}
//Console.WriteLine();
////генерация с момощью генератора случайных чисел
//int[] mas4 = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas4.Length; i++)
//{
//    mas4[i] = random.Next(10,100);
//    Console.Write(mas4[i]+" ");
//}
//Console.WriteLine();
////генерация вещественных типов данных
//double[] mas5 = new double[10];
//for (int i = 0; i < mas5.Length; i++)
//{
//    mas5[i] = random.NextDouble()*10;
//    Console.Write($"{mas5[i]:F2} ");
//}
//Console.WriteLine();

//основные операции с массивами


using System.ComponentModel;
using System.Net.Security;

int[] mas = new int[10];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10, 100);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();

//поиск элемента в массиве
Console.Write("Введите элемент для поиска:");
int n = int.Parse(Console.ReadLine());
for(int i = 0; i < mas.Length; i++)
{
    if (n == mas[i])
    {
        Console.WriteLine($"Элемент найден в позиции {i+1}");
        break;
    }
}
//поиск max и min
int max = mas[0];
int min = mas[0];
for (int i = 1; i < mas.Length; i++)
{
    if (mas[i] > max) max = mas[i];
    if (mas[i] < min) min = mas[i];
}
Console.WriteLine("max="+max+" min="+min);
max = int.MinValue;
min = int.MaxValue;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] > max) max = mas[i];
    if (mas[i] < min) min = mas[i];
}
Console.WriteLine("max=" + max + " min=" + min);
//сортировка
for(int i = 0; i < mas.Length-1; i++)
{
    for (int j = i+1; j < mas.Length; j++)
    {
        if (mas[i] > mas[j])
        {
            int temp = mas[i];
            mas[i] = mas[j];
            mas[j] = temp;
        }
    }
}
foreach(int i in mas)
    Console.Write(i+" ");
Console.WriteLine();
