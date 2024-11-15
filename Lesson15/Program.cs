string s1 = "hello";
Console.WriteLine(s1);
string s2 = new String('a', 6);
Console.WriteLine(s2);
string s3 = new String(new char[] { 'd', 'f', 's', 'q', 'z' });
Console.WriteLine(s3);
string s4 = new String(new char[] { 'd', 'f', 's', 'q', 'z' },1,3);
Console.WriteLine(s4);
Console.WriteLine(s1.Length);
Console.WriteLine(s1[3]);
for (int i = 0; i < s1.Length; i++)
{
    Console.Write(s1[i]+" ");
}
Console.WriteLine();
Console.WriteLine(s1==s4);
Console.WriteLine(s1 != s4);
string text="""
    dsfs
    dsfds
    dsfds
    dsfdssd
    dfesfdsf
    dsfds
    """;
Console.WriteLine(text);
//Операции со строками
//Объединение строк
string s5 = "Hello,";
string s6 = " world";
string s7 = s5 + " " + s6;
Console.WriteLine(s7);
string s8 = string.Concat(s7,"!!!");
Console.WriteLine(s8);
string s9 = "А ";
string s10 = "роза ";
string s11 = "на ";
string s12 = "лапу ";
string s13 = "Азора.";
string[] strings = new string[] {s9,s10,s11,s12,s13};
string s14 = string.Join(" ",strings);
Console.WriteLine(s14);
//Сравнение строк
string s15 = "hello";
string s16 = "aello";
int result = string.Compare(s15,s16);
Console.WriteLine(result);
//Поиск в строке
string s17 = "Hello, world";
Console.WriteLine(s17.IndexOf('o'));
Console.WriteLine(s17.LastIndexOf('o'));
Console.WriteLine(s17.StartsWith("Hel"));
Console.WriteLine(s17.EndsWith("rld"));
string[] files = {"first.jpg","second.bmp",
"third.exe","four.png"};
for (int i = 0; i < files.Length; i++)
{
    if (files[i].EndsWith("exe"))
        Console.WriteLine(files[i]);
}
//Разделение строк
string s18 = "В качестве параметра функция Split принимает массив символов или строк, которые и будут служить разделителями";
string[] words = s18.Split(' ',',',StringSplitOptions.RemoveEmptyEntries);
foreach (var item in words) 
    Console.WriteLine(item);
//Обрезка строки
string s19 = " Good day ";
Console.WriteLine(s19.Trim());
Console.WriteLine(s19);
s19 = s19.Trim();
Console.WriteLine(s19);
s19 = s19.Trim('G', 'y');
Console.WriteLine(s19);
string s20 = s19.Substring(2);
Console.WriteLine(s20);
string s21 = s19.Substring(2,3);
Console.WriteLine(s21);
//удаление
string s23 = "Хороший Катакай";
s23 = s23.Remove(7);
Console.WriteLine(s23);
//Вставка
string s24 = "Побить Голубчикова";
s24 = s24.Insert(7,"прогульщика ");
Console.WriteLine(s24);
//Замена
string s25 = "Хороший день";
s25 = s25.Replace("Хороший", "Плохой");
Console.WriteLine(s25);
//Смена регистра
string s26 ="Всем привет";
Console.WriteLine(s26.ToLower());
Console.WriteLine(s26.ToUpper());