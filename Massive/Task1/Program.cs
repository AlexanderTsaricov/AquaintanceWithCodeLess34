Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[9];
string isFind = "Нет";

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 20);
    Console.Write(array[i] + " ");
    if (array[i] == num)
    {
        isFind = "Да";
    }
}
Console.WriteLine(isFind);