// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
class Program
{
    public static void Main()
    {
        task34();
    }

    public static void task34()
    {
        int[] mas = new int[4];
        Random rnd = new Random();
        int count = 0;
        for (int i = 0; i < 4; i++)
        {
            mas[i] = rnd.Next(100, 999);
            if ((mas[i] % 2) == 0)
            {
                count++;
            }
        }
        Console.WriteLine("[{0}]->{1}", string.Join(",", mas), count);
    }
}