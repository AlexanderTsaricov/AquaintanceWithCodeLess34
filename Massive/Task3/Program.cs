// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] array = new int[9];
int[] array2 = new int[array2.Length / 2];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 20);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array2.Length; i++)
{
    array2[i] = array2[i] * array[array.Length - 1 - i];
    Console.Write(array[i] + " ");
}