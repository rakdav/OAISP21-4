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

//IsUpper() - показывает, является ли символ буквой верхнего регистра
//ToUpper() - преобразует символ в верхний регистр
//IsLower() - показывает, является ли символ буквой нижнего регистра
//ToLower() - преобразует символ в нижний регистр
//IsLetter() - показывает, является ли символ буквой
//IsNumber() - показывает, является ли символ цифрой
//IsPunctuation() - показывает, является ли символ знаком препинания
//IsSeparator() - показывает, является ли символ знаком разделителем
//IsSymbol() - показывает, является ли символ символьным знаком
//IsWhiteSpace() - показывает, является ли символ пробелом