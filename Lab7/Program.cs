struct Computer
{
    public string Name;
    public double Frecuancy;
    public int Memory;
    public bool DVD;
    public decimal Price;
    public Computer(string name, double frecuancy, int memory, bool dVD, decimal price)
    {
        Name = name;
        Frecuancy = frecuancy;
        Memory = memory;
        DVD = dVD;
        Price = price;
    }
    public void Print()
    {
        Console.WriteLine($"Название:{Name} Частота:{Frecuancy} Память:{Memory} DVD:{DVD} Price:{Price}");
    }
}
