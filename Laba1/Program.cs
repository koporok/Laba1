using System;

class Laba1
{
    static void Main(string[] args)
    {
        Console.Write("Введите n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (n < 0 || x <= 0)
        {
            Console.WriteLine("Не верный ввод значения");
        }
        else
        {
            double sum = 2 * QuichSort(n, x);
            Console.WriteLine("Ответ: " + sum);
        }
    }

    static double QuichSort(int n, int x)
    {
        double sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum = sum + Math.Pow((x - 1), (2 * i + 1)) / ((2 * i + 1) * Math.Pow((x + 1), (2 * i + 1)));
        }
        return sum;
    }
}
