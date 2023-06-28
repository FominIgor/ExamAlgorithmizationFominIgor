using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите количество чисел: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];


            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }


            double average = numbers.Average();
            int roundedDown = (int)Math.Floor(average);
            int roundedUp = (int)Math.Ceiling(average);


            Console.WriteLine($"Среднее значение: {average}");
            Console.WriteLine($"Округление в меньшую сторону: {roundedDown}");
            Console.WriteLine($"Округление в большую сторону: {roundedUp}");

        }
    }
}
