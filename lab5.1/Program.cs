char[] mas = new char[15];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = (char)random.Next((int)'А',(int)'я'+1);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
for(int i = 0; i < mas.Length; i++)
{
    if (char.IsUpper(mas[i])) mas[i] = char.ToLower(mas[i]);
    else if (char.IsLower(mas[i]))
        mas[i] = char.ToUpper(mas[i]);
    Console.Write(mas[i]+" ");
}
