//передача параметра по значению
//При передаче аргументов параметрам по значению параметр метода получает не саму переменную, а ее копию и далее работает с этой копией независимо от самой переменной.
void Swap(int x, int y)
{
    int temp = x;
    x = y;
    y = temp;
}
int Sum(int z, int y) => z + y;
int a = 6, b = 8;
Console.WriteLine($"a={a} b={b}");
Swap(a, b);
Console.WriteLine($"a={a} b={b}");
Console.WriteLine($"Sum={Sum(a,b)}");
//передача параметра по ссылке ref
//При передаче значений параметрам по ссылке метод получает адрес переменной в памяти. И, таким образом, если в методе изменяется значение параметра, передаваемого по ссылке, то также изменяется и значение переменной, которая передается на его место.
void SwapRef(ref int x,ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}
a = 6; b = 8;
Console.WriteLine($"a={a} b={b}");
SwapRef(ref a,ref b);
Console.WriteLine($"a={a} b={b}");
//Выходные параметры. Модификатор out
void SumOut(int a,int b,out int res)
{
    res = a + b;
}
int res;
SumOut(a, b, out res);
Console.WriteLine("res="+res);
SumOut(a, b, out int result);
Console.WriteLine("result=" + result);
//Входные параметры. Модификатор in
int Square(in int n)
{
    //n = 8;
    return n * n;
}
Console.WriteLine("5^2="+Square(5));
//Массив параметров и ключевое слово params
int SumParams(params int[] numbers)
{
    int sum = 0;
    foreach (int item in numbers)
    {
        sum += item;
    }
    return sum;
}
Console.WriteLine(SumParams(5,7,3,7,4,8));
//Массив в качестве параметра
int SumMas(int[] mas)
{
    int sum = 0;
    foreach (int item in mas)
    {
        sum += item;
    }
    return sum;
}
int[] massive = new int[10];
for (int i = 0; i < massive.Length; i++)
{
    massive[i]=new Random().Next(10, 100);
    Console.Write(massive[i]+" ");
}
Console.WriteLine();
Console.WriteLine("Sum="+SumMas(massive));
//Рекурсивные функции
//Не рекурсивная функция факториала
long Factorial(int n)
{
    long F = 1;
    for (int i = 1; i <= n; i++) F *= i;
    return F;
}
//Рекурсивная функция факториала
long FactorialRecursive(int n)
{
    if (n == 1 || n == 0) return 1;
    else return n*FactorialRecursive(n-1);
}
int F1(int n)
{
    if (n<=0) return 0;
    else if (n % 2 == 0) return F1(n / 2);
    else return 1 + F1(n - 1); 
}
Console.WriteLine(Factorial(5));
Console.WriteLine(FactorialRecursive(5));
int count = 0;
for (int i = 1; i <=1000; i++)
{
    if (F1(i) == 3) count++;
}
Console.WriteLine(count);
int Fib(int n)
{
    if (n == 1) return 0;
    else if (n == 2 || n == 3) return 1;
    else return Fib(n - 2) + Fib(n - 1);
}
for (int i = 1; i <= 30; i++)
{
    Console.Write(Fib(i)+" ");
}
Console.WriteLine();
