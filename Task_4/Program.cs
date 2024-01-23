using System;

class Program
{
    static void Main()
    {
        // Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
        
        // Задаем двумерный массив символов
        char[,] charArray = {
            {'A', 'B', 'C'},
            {'D', 'E', 'F'},
            {'G', 'H', 'I'}
        };
        
        string result = "";
        
        // Используем два вложенных цикла для прохода по каждому элементу массива
        for (int i = 0; i < charArray.GetLength(0); i++)
        {
            for (int j = 0; j < charArray.GetLength(1); j++)
            {
                // Конкатенируем каждый символ к строке
                result += charArray[i, j];
            }
        }

        // Выводим результат
        Console.WriteLine("Результирующая строка: " + result);
    }
}

