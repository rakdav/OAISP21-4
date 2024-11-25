//string lang = "ru";
//switch (lang)
//{
//    case "en":SayHelloEn();break;
//    case "ru": SayHelloRu(); break;
//    case "de": SayHelloDe(); break;
//}
//Console.Write("Введите ваше имя:");
//string myName = Console.ReadLine();
//WriteMyName(myName);
//Console.Write("Введите x:");
//int x = int.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//int y = int.Parse(Console.ReadLine());
//Sum(x, y);
//Console.Write("Введите ваше имя:");
//string name = Console.ReadLine();
//Console.Write("Введите ваш возраст:");
//int age = int.Parse(Console.ReadLine());
//PrintPerson(name,age,"ООО Голубчиков корпорейтед");
//PrintPerson(age: 30,name: "Goal",company: "Nicrosoft");
DrawLine();
void DrawLine()
{
    for (int i = 0; i < 80; i++)
    {
        Console.Write("*");
    }
}
void SayHelloRu()
{
    Console.WriteLine("Голубчиков, привет!");
}
void SayHelloEn()=>Console.WriteLine("Golubchikov, hello!");

void SayHelloDe()=>Console.WriteLine("Golubchikov, pepe!");
void WriteMyName(string name) => Console.WriteLine(name);
void Sum(int a, int b) => Console.WriteLine($"{a}+{b}={a+b}");
void PrintPerson(string name, int age, string company="Samsung")
{
    if (age < 0 || age > 120)
    {
        Console.WriteLine("Возраст не существует.");
        return;
    }
    Console.WriteLine($"Меня зовут {name}, мне {age}. Я работаю в компании {company}.");
}

//Возвращение значения и оператор return
int Summa(int a,int b)
{
    return a + b;
}
int Sub(int a, int b) => a + b;
int Mult(int a, int b) => a * b;
int Div(int a, int b)
{
    if (b != 0) return a / b;
    return 0;
}
double Func(int x)
{
    return (Math.Sqrt(x)+x) / 2;
}
Console.WriteLine();
double y = Func(6) + Func(13) + Func(21);
Console.WriteLine($"y={y:F2}");
//Console.Write("Введите x:");
//int x = int.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//int y = int.Parse(Console.ReadLine());
//Console.Write("Введите операцию(+,-,*,/):");
//char op = char.Parse(Console.ReadLine());
//switch (op)
//{
//    case '+':
//        Console.WriteLine($"{x}+{y}={Summa(x,y)}");
//        break;
//    case '-':
//        Console.WriteLine($"{x}-{y}={Sub(x, y)}");
//        break;
//    case '*':
//        Console.WriteLine($"{x}*{y}={Mult(x, y)}");
//        break;
//    case '/':
//        Console.WriteLine($"{x}/{y}={Div(x, y)}");
//        break;
//    default:
//        Console.WriteLine("Такой операции нет!");
//        break;
//}
//PrintPerson("Tom",34);