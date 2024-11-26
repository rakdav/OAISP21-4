//UI user1;
//for (user1 = UI.Name; user1 <= UI.Sex; user1++)
//    Console.WriteLine("Элемент: \"{0}\", значение {1}", user1, (int)user1);
//Console.ReadLine();

//enum UI : long
//{
//    Name,
//    Family,
//    ShortName = 5,
//    Age,
//    Sex
//}
void PrintMessage(DayTime dayTime)
{
    switch (dayTime)
    {
        case DayTime.Morning: Console.WriteLine("Доброе утро!"); break;
        case DayTime.Evening: Console.WriteLine("Добрый вечер!"); break;
        case DayTime.Night: Console.WriteLine("Доброй ночи!"); break;
        case DayTime.Afternoon: Console.WriteLine("Добрый день!"); break;
    }
}
void DoOperation(double x,double y,Operation op)
{
    double result = op switch
    {
        Operation.Add=>x+y,
        Operation.Subtract=>x-y,
        Operation.Multiply=>x*y,
        Operation.Divide=>x/y
    };
    Console.WriteLine(result);
}
DayTime dayTime = DayTime.Morning;
if (dayTime == DayTime.Morning)
    Console.WriteLine("Доброе утро!");
else
    Console.WriteLine("Привет!");
PrintMessage(dayTime);
PrintMessage(DayTime.Evening);
DoOperation(10, 5, Operation.Add);
DoOperation(10, 5, Operation.Subtract);
DoOperation(10, 5, Operation.Multiply);
DoOperation(10, 5, Operation.Divide);
string moon = "Moon";
if (!Enum.IsDefined(typeof(DistanceSun), moon))
{
    Console.WriteLine($"Значения {moon} нет в перечислении DistanceSun");
}
foreach (DistanceSun item in Enum.GetValues(typeof(DistanceSun)))
{
    Console.WriteLine("{0,-10}{1,-10}{2,20}",
    Enum.Format(typeof(DistanceSun), item, "G"),
    Enum.Format(typeof(DistanceSun), item, "D"),
    Enum.Format(typeof(DistanceSun), item, "X"));
}
foreach(string str in Enum.GetNames(typeof(DistanceSun)))
{
    Console.WriteLine(str);
}
ulong number = 7783000000;
Console.WriteLine(Enum.GetName(typeof(DistanceSun),number));
enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}
enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}
enum DistanceSun : ulong
{
    Sun=0,
    Mercury= 57900000,
    Venus = 108200000,
    Earth = 149600000,
    Mars = 227900000, 
    Jupiter = 7783000000,
    Saturn = 1427000000,
    Uranus = 2870000000, 
    Neptune = 4496000000,
    Pluto = 5946000000
}