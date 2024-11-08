//8.1a
for (int i = 1; i <=4; i++)
{
	for (int j = 1; j <=6; j++)
	{
		Console.Write(5+" ");
	}
	Console.WriteLine();
}
Console.WriteLine();
//8.1б
for (int i = 1; i <=4; i++)
{
	for (int j = 1; j <=10; j++)
	{
		Console.Write(j+" ");
	}
	Console.WriteLine();
}
Console.WriteLine();
//8.1в
int k = 41;
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write(k+++ " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//8.2а
for (int i = 1; i <=5; i++)
{
	for (int j = 1; j <=i ; j++)
	{
		Console.Write(5+" ");
	}
	Console.WriteLine();
}
Console.WriteLine();
//8.2б
for (int i = 0; i <=5; i++)
{
	for (int j = 5-i; j>=1; j--)
	{
		Console.Write(1+" ");
	}
	Console.WriteLine();
}
Console.WriteLine();
//8.3а
int m = 1;
for (int i = 1; i <= 5; i++)
{ 
    for (int j = 1; j <= i; j++)
    {
        Console.Write(m+ " ");
    }
    Console.WriteLine();
	m++;
}
Console.WriteLine();
//8.5
for (int i = 1; i <=9; i++)
{
	for (int j = 1; j <=9; j++)
	{
		Console.Write($"{j}+{i}={j+i} ");
	}
	Console.WriteLine();
}
Console.WriteLine();
//8.7
for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.Write($"{j}*{i}={j * i} ");
    }
    Console.WriteLine();
}