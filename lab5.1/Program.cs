//char[] mas = new char[15];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = (char)random.Next((int)'А',(int)'я'+1);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//for(int i = 0; i < mas.Length; i++)
//{
//    if (char.IsUpper(mas[i])) mas[i] = char.ToLower(mas[i]);
//    else if (char.IsLower(mas[i]))
//        mas[i] = char.ToUpper(mas[i]);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = char.Parse(Console.ReadLine());
//}
//foreach (var item in mas) Console.Write(item+" ");
//Console.WriteLine();
//int count = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i] == 'r' || mas[i] == 'k' || mas[i] == 't') count++;
//}
//Console.WriteLine("count="+count);
//Дан массив символов указать те слова,которые содержат хотя бы одну
//букву k
//Random random = new Random();
//int length = random.Next(10, 21);
//char[] mas = new char[length];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = char.Parse(Console.ReadLine());
//}
//foreach (var item in mas) Console.Write(item);
//Console.WriteLine();
//char[] masTemp = new char[length];
//int k = 0;
//for(int i = 0; i < mas.Length; i++)
//{
//    if (char.IsLetter(mas[i])) masTemp[k++] = mas[i];
//    else
//    {
//        if (Array.IndexOf(masTemp, 'k') != -1)
//        {
//            foreach (var item in masTemp) Console.Write(item);
//            Console.WriteLine();
//        }
//        for (int j = 0; j < masTemp.Length; j++) masTemp[j] = '\0';
//        k = 0;
//    }
//}
//
Random random = new Random();
int length = random.Next(10, 21);
char[] mas = new char[length];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = char.Parse(Console.ReadLine());
}
int max = int.MinValue;
for (int i = 0; i < mas.Length; i++)
{
    if (char.IsNumber(mas[i]))
    {
        int n = int.Parse(mas[i].ToString());
        if (n > max) max = n;
    }
}
Console.WriteLine(max);






