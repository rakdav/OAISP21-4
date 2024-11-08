//Array
//Length - длина массива
//Rank - размерность массива
//BinarySearch - бинарный поиск
//Sort - сортировка массива
//IndexOf - возвращает индекс первого вхождения элемента в массив
//LastIndexOf - возвращает индекс последнего вхождения элемента в массив
//FindIndex - возвращает индекс первого вхождения элемента, который удовлеворяет определенному условию
//FindLastIndex - возвращает индекс последнего вхождения элемента, который удовлеворяет определенному условию
//Find - находит первый элемент, который удовлеворяет определенному условию. Если элемент не найден, то возвращается null.
//FindLast - находит последний элемент, который удовлеворяет определенному условию. Если элемент не найден, то возвращается null
//FindAll - возвращает все элементы в виде массива, которые удовлеворяет определенному условию
//Reverse - располагает элементы массива в обратном порядке
//Exists - проверяет, содержит ли массив элементы, которые удовлеворяют условию
//Fill - заполняет массив значением value
//Resize - изменяет размер одномерного массива
string[] people = { "Gabitov U", "Karpov T", "Goluboy G", "Kirill C" };
int[] numbers = { 4,8,3,2,6,9,1,7};
Console.WriteLine(people.Length);
Console.WriteLine(people.Rank);
Array.Sort(people);
foreach (string item in people) Console.Write(item+" ");
Console.WriteLine();
Console.WriteLine(Array.BinarySearch(people, "Karpov T"));
Array.Sort(numbers);
foreach (int item in numbers) Console.Write(item + " ");
Console.WriteLine();
Console.WriteLine(Array.BinarySearch(numbers, 6));
Console.WriteLine(Array.BinarySearch(numbers, 5));
int[] mas = { 7,3,9,3,8,3,6};
Console.WriteLine(Array.IndexOf(mas,3));
int lastIndex=Array.LastIndexOf(mas, 3);
Console.WriteLine(lastIndex);
Console.WriteLine(Array.FindIndex(mas,p=>p>8));
Console.WriteLine(Array.FindLastIndex(mas, p => p>7));
Console.WriteLine(Array.Find(mas,p=>p>=5));
Console.WriteLine(Array.FindLast(mas, p => p <= 6));
int[] res = Array.FindAll(mas, p => p > 5);
foreach (int item in res) Console.Write(item+" ");
Console.WriteLine(); //rakdav
Array.Reverse(mas);
foreach (int item in mas) Console.Write(item + " ");
Console.WriteLine();
Console.WriteLine(Array.Exists(mas,p=>p>7));
int[] fillmas = new int[10];
Array.Fill(fillmas, 5);
foreach (int item in fillmas) Console.Write(item + " ");
Console.WriteLine();
Array.Fill(fillmas, 3,1,7);
foreach (int item in fillmas) Console.Write(item + " ");
Console.WriteLine();
int[] copymas = new int[10];
Array.Copy(fillmas,copymas,5);
foreach (int item in copymas) Console.Write(item + " ");
Console.WriteLine();
Array.Clear(mas);
foreach (int item in mas) Console.Write(item + " ");

Array.Resize<int>(ref mas, 8);




