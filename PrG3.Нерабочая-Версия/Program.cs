
//на семминаре задам вопросы по этому коду 

int[] GetArray(int size, int minValue, int maxValue)
{
    Console.Write("[");
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    Console.Write("]");
    return res;
    
}



int[] array = GetArray(7, 1, 10);

int MaxNumbers(int[] maxnumber)
{
    int index = 1;
    int max = maxnumber[0];
    int n = 1;
    
    while (index < maxnumber.Length)
    {
        if (maxnumber[n] > max)
        {
            maxnumber[n] = max;
        }
        index = index  + 1;
        n = n + 1;
        Console.WriteLine($"макс = {max}");
        Console.WriteLine($"число = {n}");
    }
    return(max);
}

Console.WriteLine(MaxNumbers(array));