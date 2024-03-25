// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231




int[] CreateArray()
{
    Console.WriteLine("Введите число");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] numbers = new int[size];
    return numbers;
}


void FillingArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + "\t");
    }
}

int GetNumInArray(int[] array)
{
    string count = "";

    for (int i = 0; i < array.Length; i++)
    {
        count += array[i];
    }
    return Convert.ToInt32(count);
}
int[] newArray = CreateArray();

FillingArray(newArray);
PrintArray(newArray);
Console.WriteLine("Строчка " + GetNumInArray(newArray));