int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(array[i] + "\t");
}
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i] + "\t");
}