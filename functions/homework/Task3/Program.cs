/*
    Напишите программу, которая перевернёт одномерный массив 
    (первый элемент станет последним, второй – предпоследним и т.д.)
*/

int[] GetArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("Массив: ");
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
    Console.Write("\n");
}

int[] GetFlipArray(int[] array)
{
    int arrayEndIndex = array.Length - 1;
    int[] flipArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        flipArray[i] = array[arrayEndIndex];
        arrayEndIndex--;
    }

    return flipArray;
}

int sizeArray = 10;
int[] arrayNumbers = GetArray(sizeArray);
PrintArray(arrayNumbers);
int[] flipArr = GetFlipArray(arrayNumbers);
PrintArray(flipArr);

