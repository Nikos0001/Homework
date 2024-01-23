﻿using System;

class Program
{
    static void Main()
    {
        // Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
        // Сформируйте строку, в которой все заглавные буквы заменены на строчные.
        
        
        // Задаем строку с латинскими буквами в обоих регистрах
        string input = "Hello World1";
        
        // Создаем пустую строку
        string result = "";

        // Формируем строку, в которой все заглавные буквы заменены на строчные
        // Используем цикл для обработки каждого символа в строке
        for (int i = 0; i < input.Length; i++)
        {
            // Проверяем, является ли текущий символ заглавной буквой
            if (input[i] >= 'A' && input[i] <= 'Z')
            {
                // Если да, заменяем его на соответствующую строчную букву
                result += (char)(input[i] + ('a' - 'A'));
            }
            else
            {
                // Если не заглавная буква, оставляем символ без изменений
                result += input[i];
            }
        }

        // Выводим результат
        Console.WriteLine("Результирующая строка: " + result);
    }
}
