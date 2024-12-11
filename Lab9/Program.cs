using Lab9;

//базовый
//Console.Write("Введите массу тела:");
//double m = double.Parse(Console.ReadLine());
//Console.Write("Введите скорость:");
//double v = double.Parse(Console.ReadLine());
//Body body = new Body(m, v);
//body.Print();
//Console.Write("Введите высоту:");
//double height = double.Parse(Console.ReadLine());
//FlightBody fb = new FlightBody(m, v, height);
//fb.Print();

//средний
Console.Write("Введите фамилию:");
string surname = Console.ReadLine();
Console.Write("Введите должность:");
string position = Console.ReadLine();
Console.Write("Введите оклад:");
decimal oklad = decimal.Parse(Console.ReadLine());
Employee emp = new Employee(surname, position, oklad);
emp.Print();
emp.AddSalary();
emp.SetPosition();
emp.Print();
Console.Write("Введите рейтинг:");
int rating = int.Parse(Console.ReadLine());
EmpFactory empFact = new EmpFactory(surname,position,oklad,rating);
empFact.AddSalary();
empFact.Print();