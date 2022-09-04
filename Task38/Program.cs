// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
class Program
{
    public static void Main()
    {
        task38();
    }

    public static void task38()


    {
        double[] array = new double[4];
        for (int i = 0; i < 4; i++)
        {
            array[i] = Random.Shared.NextDouble();
        }
        int lenght = array.Length;
        double firstnumber = array[0];
        double lastnumber = array[lenght - 1];
        double difference = lastnumber - firstnumber;
        Console.WriteLine(difference);
    }
}