using Lab9;

//базовый
//Console.Write("Введите массу тела:");
//double m = double.Parse(Console.ReadLine());
//Console.Write("Введите скорость:");
//double v = double.Parse(Console.ReadLine());
//Body body = new Body(m, v);
//body.Print();

//средний
Console.Write("Введите фамилию:");
string surname = Console.ReadLine();
Console.Write("Введите должность:");
string position = Console.ReadLine();
Console.Write("Введите оклад:");
decimal oklad = decimal.Parse(Console.ReadLine());
Employee emp = new Employee(surname,position,oklad);
emp.Print();
emp.AddSalary();
emp.SetPosition();
emp.Print();