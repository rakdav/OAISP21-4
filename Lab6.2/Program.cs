using static ClassLab6_2.ClassLib;
Random random = new Random();
//базовый уровень
//int[,] mas = new int[7, 4];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//	for (int j = 0; j < mas.GetLength(1); j++)
//	{
//		mas[i, j] = random.Next(10, 100);
//		Console.Write(mas[i,j]+" ");
//	}
//	Console.WriteLine();
//}
//Console.WriteLine("Сумма индексов max элемента:"+IndexMax(mas));
//средний
double[,] mas = new double[8, 3];
for (int i = 0; i < mas.GetLength(0); i++)
{
	for (int j = 0; j < mas.GetLength(1); j++)
	{
		mas[i, j] = Math.Pow(Math.Sin(i)* Math.Sin(i)+
            Math.Cos(i) * Math.Cos(i), (i-5)/(j+1))+
			7.45*Math.Tan((i-5)/(j+8));
		Console.Write($"{mas[i, j]:F2} ");
	}
	Console.WriteLine();
}
Console.WriteLine("Сумма элементов строк матрицы:");
double[] vector = SumRows(mas);
for(int i = 0; i < vector.Length; i++)
{
	Console.Write(vector[i]+" ");
}
Console.WriteLine();
Console.WriteLine("Разность между максимальным и индексом минимального:"+SubIndex(vector));


