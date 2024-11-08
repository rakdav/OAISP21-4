try 
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    //Инициализация
    //long P = 1;
    //int i = 1;
    //цикл с предусловием
    //while(i<=n)
    //{
    //    //Тело цикла
    //    P *= i;
    //    i++;
    //}
    //Console.WriteLine($"Факториал {n} равен:{P}");
    //цикл с постусловием
    //P = 1;
    //i = 1;
    //do
    //{
    //    P *= i;
    //    i++;
    //}
    //while (i<=n);
    //Console.WriteLine($"Факториал {n} равен:{P}");
    //цикл for
    //int P = 1;
    //for (int i = 1; i <= n; i++) P *= i;
    //Console.WriteLine($"Факториал {n} равен:{P}");
    //for(int i=35;i<=87;i++)
    //    if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5) Console.WriteLine(i);
    int s = 0;
    for (int i = 1; i <= n; i++)
    {

        if (i % 2 != 0) continue; 
        s += i;
    }
    Console.WriteLine($"s={s}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}