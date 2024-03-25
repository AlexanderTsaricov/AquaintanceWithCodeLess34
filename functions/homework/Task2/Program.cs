/*
    Задайте массив заполненный случайными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int[] GetArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int GetEvenNumbersCount(int[] array)
{
    int evenCount = 0;
    foreach (int e in array)
    {
        if (e % 2 == 0)
        {
            evenCount++;
        }
    }
    return evenCount;
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
    Console.Write("\n");
}

int sizeArray = 10;
int[] arrayNumbers = GetArray(sizeArray);
PrintArray(arrayNumbers);
int count = GetEvenNumbersCount(arrayNumbers);
Console.WriteLine(count);