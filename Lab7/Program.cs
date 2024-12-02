//Computer[] comps = new Computer[5];
//for (int i = 0; i < comps.Length; i++)
//{
//    Console.Write("Введите название:");
//    string name = Console.ReadLine();
//    Console.Write("Введите частоту:");
//    double fr = double.Parse(Console.ReadLine());
//    Console.Write("Введите объем памяти:");
//    int memory = int.Parse(Console.ReadLine());
//    Console.Write("Выберите y - если присутствует DVD или n - если отсутствует.");
//    char dvd = char.Parse(Console.ReadLine());
//    bool hasDVD = false;
//    if (dvd == 'y') hasDVD = true;
//    Console.Write("Введите цену:");
//    decimal price = decimal.Parse(Console.ReadLine());
//    Computer comp = new Computer(name, fr, memory, hasDVD, price);
//    comps[i] = comp;
//}
//foreach (Computer item in comps)
//{
//    if (item.DVD == true) item.Print();
//}
Car[] cars = new Car[3];
for (int i = 0; i < cars.Length; i++)
{
    Console.Write("Введите марку:");
    string marka = Console.ReadLine();
    Console.Write("Введите произволителя:");
    string manufacturer = Console.ReadLine();
    Console.Write("Выберите тип: 1 - Cедан, 2 - Купе, 3 - Кабриолет, 4 - Хетчбек, 5 - Универсал, 6 - Пикап:");
    TypeOfCar tc= TypeOfCar.sedan;
    int typeNumber = int.Parse(Console.ReadLine());
    switch (typeNumber)
    {
        case 1: tc = TypeOfCar.sedan; break;
        case 2: tc = TypeOfCar.kupe; break;
        case 3: tc = TypeOfCar.cabriolet; break;
        case 4: tc = TypeOfCar.hatchback; break;
        case 5: tc = TypeOfCar.universal; break;
        case 6: tc = TypeOfCar.pikap; break;
    }
    Console.Write("Введите год выпуска:");
    int year = int.Parse(Console.ReadLine());
    Console.Write("Введите дату техосмотра:");
    DateTime td = DateTime.Parse(Console.ReadLine());
    Console.Write("Введите дату регистрации:");
    DateTime rd = DateTime.Parse(Console.ReadLine());
    Car car = new Car(marka,manufacturer,tc,year,td,rd);
    cars[i] = car;
}
foreach(Car car in cars)
{
    if (DateTime.Now.Subtract(car.Date).TotalDays < 365)
        car.Print();
}
struct Computer
{
    public string Name;
    public double Frecuancy;
    public int Memory;
    public bool DVD;
    public decimal Price;
    public Computer(string name, double frecuancy, int memory, bool dVD, decimal price)
    {
        Name = name;
        Frecuancy = frecuancy;
        Memory = memory;
        DVD = dVD;
        Price = price;
    }
    public void Print()
    {
        Console.WriteLine($"Название:{Name} Частота:{Frecuancy} Память:{Memory} DVD:{DVD} Price:{Price}");
    }
}

enum TypeOfCar
{
    sedan,
    kupe,
    cabriolet,
    hatchback,
    universal,
    pikap
}
struct Car
{
    public string Marka;
    public string Manufacturer;
    public TypeOfCar Type;
    public int Year;
    public DateTime Date;
    public DateTime RegistrationDate;

    public Car(string marka, string manufacturer, TypeOfCar type, int year, DateTime date, DateTime registrationDate)
    {
        Marka = marka;
        Manufacturer = manufacturer;
        Type = type;
        Year = year;
        Date = date;
        RegistrationDate = registrationDate;
    }
    public void Print()
    {
        Console.WriteLine($"Марка:{Marka} " +
                          $"Производитель:{Manufacturer} " +
                          $"Тип:{Type} " +
                          $"Год выпуска:{Year} " +
                          $"Дата техосмотра:{Date}" +
                          $"Дата регистрации:{RegistrationDate}");
    }
}
