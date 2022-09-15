//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

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




int max = array[0];
int index = 0;
int n = 0;

while (index < array.Length)
{
    if (array[n] > max)
    {
        max = array[n];
    }
    index++;
    n++;

}


int min = array[0];
int index1= 0;
int n1 = 0;


while (index1 < array.Length)
{
    if (array[n1] < min)
    {
        min = array[n1];

    }
    index1++;
    n1++;
}

int razniza = max - min;

Console.WriteLine();

Console.WriteLine($"Pазница между максимальным и минимальным элементов массива = {razniza}");

