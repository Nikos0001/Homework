class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        Random rand = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(100,1000);
            Console.WriteLine($"[{i}] = {numbers[i]}");
        }
        int evenCount = 0;
        foreach (int number in numbers)
        {
            if ( number % 2 == 0)
            {
                evenCount++;
            }
        }
        Console.WriteLine("Количесство чётных чисел в массиве: " + evenCount);
    }
}