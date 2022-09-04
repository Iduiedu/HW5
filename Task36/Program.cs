// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
class Program
{
    public static void Main()
    {
        task36();
    }

    public static void task36()
    {
        int[] mas = new int[4];
        Random rnd = new Random();
        int sum = 0;
        int num = 1;
        for (int i = 0; i < 4; i++)
        {
            mas[i] = rnd.Next(-50, 50);
            if ((num % 2) != 0)
            {
                sum += mas[i];
            }
            num++;
        }
        Console.WriteLine("[{0}]-> {1}", string.Join(",", mas), sum);
    }
}