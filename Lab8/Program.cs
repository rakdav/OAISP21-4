//Вариант 30 Базовый уровень
//Задача 1
//Console.Write("Введите первую дату:");
//DateTime d1 = DateTime.Parse(Console.ReadLine());
//Console.Write("Введите вторую дату:");
//DateTime d2 = DateTime.Parse(Console.ReadLine());
//if(d1.CompareTo(d2)<0) Console.WriteLine($"{d1} раньше чем {d2}");
//else if(d1.CompareTo(d2)==0) Console.WriteLine($"{d1} равен {d2}");
//else Console.WriteLine($"{d1} позже чем {d2}");
//Задача 2
//Console.Write("Введите дату последней профилактики:");
//DateOnly data = DateOnly.Parse(Console.ReadLine());
//Console.Write("Введите периодичность проведения осмотра:");
//int period = int.Parse(Console.ReadLine());
//Console.WriteLine($"Следующая дата проведения осмотра:{data.AddMonths(period)}");
//Вариант 30 Средний уровень

SmartHome[] mas = new SmartHome[3];
for (int i = 0; i < mas.Length; i++)
{
    Console.Write("Введите дату включения кондиционера:");
    DateOnly d = DateOnly.Parse(Console.ReadLine());
    Console.Write("Введите время включения кондиционера:");
    TimeOnly t = TimeOnly.Parse(Console.ReadLine());
    Console.Write("Выберите температурный режим: 1 - Охлаждение, 2 - Отопление, 3 - Вентиляция, 4 - Сон, 5 - Осушение:");
    int n = int.Parse(Console.ReadLine());
    Mode mode=Mode.Сон;
    switch (n)
    {
        case 1:mode = Mode.Охлаждение;break;
        case 2: mode = Mode.Отопление; break;
        case 3: mode = Mode.Вентиляция; break;
        case 4: mode = Mode.Сон; break;
        case 5: mode = Mode.Осушение; break;
    }
    Console.Write("Введите температуру:");
    int temp = int.Parse(Console.ReadLine());
    SmartHome sm = new SmartHome();
    sm.mode = mode;
    sm.time = t;
    sm.date = d;
    sm.temp = temp;
    mas[i] = sm;
}
foreach (SmartHome item in mas)
{
    if (item.time > TimeOnly.FromDateTime(DateTime.Now))
    {
        TimeSpan ts = item.time - TimeOnly.FromDateTime(DateTime.Now);
        Console.WriteLine($"{item.mode}.Время до включения " +
            $"{ts.Hours}:{ts.Minutes}:{ts.Seconds}");
    }
}
foreach (SmartHome item in mas)
{
    int d = DateOnly.FromDateTime(DateTime.Now).Day-item.date.Day;
    if (d==-1)
    {
        Console.WriteLine(item.mode);
    }
}
enum Mode
{
    Охлаждение,
    Отопление,
    Вентиляция,
    Сон,
    Осушение
}
struct SmartHome
{
    public DateOnly date;
    public TimeOnly time;
    public Mode mode;
    public int temp;
}
