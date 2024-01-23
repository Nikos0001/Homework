using System;

class Program
{
    static void Main()
    {
        // Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом
        
        // Задаем произвольную строку
        string inputString = "level";

        // Проверяем, является ли строка палиндромом
        bool isPalindrome = IsPalindrome(inputString);

        // Выводим результат
        Console.WriteLine("Строка является палиндромом: " + isPalindrome);
    }

    static bool IsPalindrome(string input)
    {
        // Используем два указателя для сравнения символов с обоих концов строки
        int start = 0;
        int end = input.Length - 1;

        // Пока указатели не встретятся или пересекутся
        while (start < end)
        {
            // Сравниваем символы с обоих концов строки
            if (input[start] != input[end])
            {
                // Если хотя бы одна пара символов не совпадает, строка не является палиндромом
                return false;
            }

            // Перемещаем указатели к центру строки
            start++;
            end--;
        }

        // Если все пары символов совпали, строка является палиндромом
        return true;
    }
}