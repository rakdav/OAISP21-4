int[,] mas1 = new int[3,4];//массив 3Х4 из 0
int[,] mas2 = {{1,2,3},{4,5,6},{7,8,9}};
Random random = new Random();
int[,] mas3 = new int[3, 4];
for (int i = 0; i < mas3.GetLength(0); i++)
{
    int max_row = int.MinValue, min_row = int.MaxValue;
    for (int j = 0; j < mas3.GetLength(1); j++)
	{
		mas3[i, j] = random.Next(10, 100);
		Console.Write(mas3[i,j]+" ");
        if (mas3[i, j] > max_row) max_row = mas3[i, j];
        if (mas3[i, j] < min_row) min_row = mas3[i, j];
    }
    Console.WriteLine($"max={max_row} min={min_row}");
}
//найти max и min матрицы и каждой строки
int max = int.MinValue, min = int.MaxValue;
for (int i = 0; i < mas3.GetLength(0); i++)
{
    for (int j = 0; j < mas3.GetLength(1); j++)
	{
		if (mas3[i, j] > max) max = mas3[i, j];
        if (mas3[i, j] < min) min = mas3[i, j];
    }
}
Console.WriteLine($"max={max} min={min}");
//сумма элементов строк и столбцов и сумма всей матрицы
int[,] mas4 = new int[random.Next(3,6), random.Next(3,6)];
int S = 0;
for (int i = 0; i < mas4.GetLength(0); i++)
{
    int s_r = 0;
    for (int j = 0; j < mas4.GetLength(1); j++)
    {
        mas4[i, j] = random.Next(10, 30);
        Console.Write(mas4[i,j]+" ");
        S += mas4[i, j];
        s_r += mas4[i, j];
    }
    Console.WriteLine("s="+s_r);
}
for(int i = 0; i < mas4.GetLength(1); i++)
{
    int s_c = 0;
    for(int j=0;j<mas4.GetLength(0);j++)
    {
        s_c += mas4[j, i];
    }
    Console.Write(s_c+" ");
}
Console.WriteLine();
Console.WriteLine("S="+S);
//нахождение самого часто повторяющегося значения среди элементов массива
int k = 0;//размер массива
int[] mas5 = new int[k];
for (int i = 0; i < mas4.GetLength(0); i++)
{
    for (int j = 0; j < mas4.GetLength(1); j++)
    {
        if (Array.IndexOf(mas5, mas4[i, j]) == -1)
        {
            Array.Resize<int>(ref mas5, k+1);
            mas5[k++] = mas4[i, j];
        }
    }
}
foreach (int i in mas5) Console.Write(i+" ");
Console.WriteLine();

for (int i = 0; i < mas5.Length; i++)
{
    int m = 0;
    for (int j = 0; j < mas4.GetLength(0); j++)
    {
        for (int l = 0; l < mas4.GetLength(1); l++)
        {
            if (mas5[i] == mas4[j, l]) m++;
        }
    }
    Console.WriteLine(mas5[i]+" - "+m);
}
//нахождение среднего арифметического и среднего геометрического значений элементов массива строк/столбцов;
int[,] mas6 = new int[random.Next(3, 6), random.Next(3, 6)];
for (int i = 0; i < mas6.GetLength(0); i++)
{
    double s_r = 0;
    for (int j = 0; j < mas6.GetLength(1); j++)
    {
        mas6[i, j] = random.Next(10, 30);
        Console.Write(mas6[i, j] + " ");
        s_r += mas6[i, j];
    }
    Console.WriteLine($"s={s_r/mas6.GetLength(1):F2}");
}
for (int i = 0; i < mas6.GetLength(1); i++)
{
    double s_c = 0;
    for (int j = 0; j < mas6.GetLength(0); j++)
    {
        s_c += mas6[j, i];
    }
    Console.Write($"{s_c/mas6.GetLength(0):F2} ");
}
Console.WriteLine();
//заполнить массив значениями членов арифметической прогрессии, полученными по заданной учителем формуле
Console.Write("Введите первый элемент прогрессии:");
int a1 = int.Parse(Console.ReadLine());
Console.Write("Введите разность прогрессии:");
int d = int.Parse(Console.ReadLine());
int[,] mas7 = new int[random.Next(3, 6), random.Next(3, 6)];
int n = 1;
for (int i = 0; i < mas7.GetLength(0); i++)
{
    for (int j = 0; j < mas7.GetLength(1); j++)
    {
        mas7[i, j] = a1 + d * (n++-1);
        Console.Write(mas7[i,j]+" ");
    }
    Console.WriteLine();
}
