// using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 }; // Создаем исходный массив

        // Переворачиваем массив
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            int temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }

        // Выводим результат
        Console.WriteLine("Перевернутый массив:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}