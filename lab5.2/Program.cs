Console.Write("Введите строку:");
string str = Console.ReadLine();

//базовый уровень
//char s = str[2];
//char l = str[str.Length - 1];
//str = str.Remove(2,1);
//str = str.Insert(2, l.ToString());
//str = str.Remove(str.Length - 1, 1);
//str = str.Insert(str.Length,s.ToString());
//Console.WriteLine(str);

//средний уровень
string[] mas = str.Split("  ",' ');
Console.WriteLine(mas.Length);
