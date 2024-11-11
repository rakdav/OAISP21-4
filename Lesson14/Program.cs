char ch = 'q';
char p = '\n';
char d = (char)999;
Console.WriteLine(d);
int first = (int)'А';
int last = (int)'я';
for (int i = first; i <=last; i++)
{
    Console.WriteLine($"{i}-{(char)i}");
}
char A = 'A';
char z = 'z';
for (int i = A; i <= z; i++)
{
    Console.WriteLine($"{i}-{(char)i}");
}
for(int i = (int)'0'; i <= (int)'9'; i++)
{
    Console.WriteLine($"{i}-{(char)i}");
}
if (char.IsDigit('5')) Console.WriteLine("Цифра");
else Console.WriteLine("Не цифра");
if (char.IsLetter('я')) Console.WriteLine("Буква");
else Console.WriteLine("Не буква");
if (char.IsControl('\xA')) Console.WriteLine("Управляющий");
else Console.WriteLine("Не управляющий");
for (int i = 0; i <= char.MaxValue; i++)
{
    Console.WriteLine($"{i}-{(char)i}");
}
