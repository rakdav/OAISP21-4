using System.Text;

StringBuilder sb1 = new StringBuilder();
StringBuilder sb2 = new StringBuilder("Hello");
Console.WriteLine(sb2);
Console.WriteLine($"Length={sb2.Length}");
Console.WriteLine($"Capacity={sb2.Capacity}");
StringBuilder sb3 = new StringBuilder("New String",32);
Console.WriteLine($"Length={sb3.Length}");
Console.WriteLine($"Capacity={sb3.Capacity}");
//Методы
sb1.Append("First");
Console.WriteLine(sb1);
sb1.Insert(5, " second");
Console.WriteLine(sb1);
sb1.Remove(10,2);
Console.WriteLine(sb1);
sb1.Replace("First","Первый");
Console.WriteLine(sb1);
sb1.AppendFormat("Второй");
Console.WriteLine(sb1);
//Когда надо использовать класс String, а когда StringBuilder?
//Microsoft рекомендует использовать класс String в следующих случаях:
//1. При небольшом количестве операций и изменений над строками
//2. При выполнении фиксированного количества операций объединения. В этом случае компилятор может объединить все операции объединения в одну
//3. Когда надо выполнять масштабные операции поиска при построении строки, например IndexOf или StartsWith. Класс StringBuilder не имеет подобных методов.

//Класс StringBuilder рекомендуется использовать в следующих случаях:
//1. При неизвестном количестве операций и изменений над строками во время выполнения программы
//2. Когда предполагается, что приложению придется сделать множество подобных операций
