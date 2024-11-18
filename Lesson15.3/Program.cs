using System.Text.RegularExpressions;

string str = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
Regex regex = new Regex(@"туп(\w*)");
MatchCollection matches = regex.Matches(str);
if (matches.Count > 0)
{
    foreach (Match match in matches) Console.WriteLine(match.Value);
}
else
{
    Console.WriteLine("Совпадений нет");
}


string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
string mail = "tup@mail.ru";
Console.WriteLine(Regex.IsMatch(mail,pattern));
Console.WriteLine(Regex.IsMatch("Голубчиков прогульщик", pattern));
do
{
    Console.Write("Введите почту:");
    mail = Console.ReadLine();
    if (!Regex.IsMatch(mail, pattern)) Console.WriteLine("Это не почта!");
}
while (!Regex.IsMatch(mail, pattern));

