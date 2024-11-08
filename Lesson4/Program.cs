using System.Threading.Channels;

try
{
    // Console.Write("Введите число:");
    // int n=int.Parse(Console.ReadLine());
    // //1. Дано расстояние в сантиметрах. Найти число полных метров в нем.
    // Console.WriteLine($"m={n/100} полных метров");
    // //2. Дана масса в килограммах. Найти число полных центнеров в ней.
    // Console.WriteLine($"m={n/100} полных центнеров");
    // //3.Дана масса в килограммах. Найти число полных тонн в ней.
    // Console.WriteLine($"m={n/1000} полных тонн");
    // //4. Дано расстояние в метрах. Найти число полных километров в нем.
    // Console.WriteLine($"m={n/1000} полных километров");
    // //С начала суток прошло n секунд. Определить:
    // //а) сколько полных часов прошло с начала суток;
    // int hours=n/3600;
    // int minutes = n % 3600 / 60;
    // int seconds = n % 60;
    // Console.WriteLine($"{hours}:{minutes}:{seconds}");
    // Дано трехзначное число. Найти:
    Console.Write("Введите трехзначное число:");
    int x=int.Parse(Console.ReadLine());
    int c = x % 10;
    int b=x % 100/10;
    int a=x / 100;
    Console.WriteLine($"Сумма чисел:{a+b+c}");
    Console.WriteLine($"Произведение чисел:{a*b*c}");
    Console.WriteLine($"Число в обратном порядке:{c*100+b*100*a}");
}
catch
{
    Console.WriteLine("Введите правильные данные!");
}