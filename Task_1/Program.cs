internal class Program
{
    public static void Main()
    {
        Task_1();
    }
    static void Task_1()
    {
        bool IsEvenSum(int number)
        {
            int sum = 0;
            while(number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum % 2 == 0;
        }
        while (true)
        {
            Console.Write("Введите целое число или `q` для выхода:");
            string input = Console.ReadLine();
            if (input == "q")
            break;
            int number;
            if (int.TryParse(input, out number))
            {
                if (IsEvenSum(number))
                {
                    Console.WriteLine("Сумма числа чётная,программа завершена.");
                    break;
                }
            }
            else
            Console.WriteLine("Некорректный ввод,попробуйте снова:");
        }
    }
}