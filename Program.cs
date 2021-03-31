namespace NakovTask
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a numbers (2 3 4...): ");
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int LongesSeries = 1;
            int startPosition = 0;

            int seriesLongest = 1;
            int currentStart = 0;
           
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    seriesLongest++;

                    if (seriesLongest > LongesSeries)
                    {
                        LongesSeries = seriesLongest;
                        startPosition = currentStart;
                    }
                }
                else
                {
                    seriesLongest = 1;
                    currentStart = i;
                }
            }

            for (int i = startPosition; i < startPosition + LongesSeries; i++)
                Console.Write($"{numbers[i]} ");
        }
    }
}
