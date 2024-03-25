Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[];
void FillingArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 30);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int GetNumInArray()
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 7 == 0 && array[i] == 1)
        {
            count++;
        }
    }
    return count;
}

FillingArray();
PrintArray();
Console.WriteLine($"Кол. = {GetNumInArray()}");