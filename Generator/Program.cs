Random random = new Random();
HashSet<int> set = new HashSet<int>();
int i = 1;
do
{
    int index = random.Next(1, 31);
    if (!set.Contains(index))
    {
        set.Add(index);
        Console.WriteLine(index);
        i++;
    }
} while (i < 20);
