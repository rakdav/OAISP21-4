//struct
Person tom = new Person();
tom.name = "Tom";
tom.age = 30;
tom.Print();
Person golub = new();
golub.name = "Голубок";
golub.age = 25;
golub.Print();
Person bob = new Person("Bob", 32);
Console.WriteLine(bob.name);
Console.WriteLine(bob.age);
Person jerry = bob with { name = "Jerry" };
Console.WriteLine(jerry.name);
Console.WriteLine(jerry.age);
Human human = new Human("Хроменков л....ра",20);
human.Print();
struct Person
{
    public string name;
    public int age;
    public Person(string _name,int _age)
    {
        name = _name;
        age = _age;
    }
    public void Print()
    {
        Console.WriteLine($"Имя:{name} Возраст:{age}");
    }
}
//records
public record Human
{
    public string Name;
    public int Age;

    public Human(string _name, int _age)
    {
        Name = _name;
        Age = _age;
    }
    public void Print()
    {
        Console.WriteLine($"Имя:{Name} Возраст:{Age}");
    }
}