/*
    Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается 
    при вводе символа ‘q’ или при вводе числа, 
    сумма цифр которого чётная.
*/
int GetSumNumbersDigit(int num)
{
    int sum = 0;
    while (num >= 1)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

void InputEvenNumber()
{

    while (true)
    {
        Console.WriteLine("Введите целое число, сумма цифр которого четная или введите 'q'");
        string inputData = Console.ReadLine();
        int sumNumber = 1;
        int IsNumeric;
        if (int.TryParse(inputData, out IsNumeric))
        {
            int inputNumber = Convert.ToInt32(inputData);
            sumNumber = GetSumNumbersDigit(inputNumber);
        }

        if (inputData == "q" || sumNumber % 2 == 0)
        {
            Console.WriteLine("Программа завершена");
            return;
        }
    }
}

InputEvenNumber();