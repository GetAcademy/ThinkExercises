using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkExercises
{
    internal class Exercise3_7
    {
        public static void Run()
        {
            var numbers = new[] { 1, 9, 3, 4, 9, 5, 2, 5, 5, 8, 9, 7, 5, 5, 9, 9, 9};
            var mode = GetMode(numbers);
            Console.WriteLine(mode);
        }

        public static int GetMode(int[] numbers)
        {
            var frequencyTable = CreateFrequencyTable(numbers);

            var maxFrequency = 0;
            var mode = frequencyTable[0];

            for (var number = 1; number < frequencyTable.Length; number++)
            {
                var frequency = frequencyTable[number];
                if (frequency > maxFrequency)
                {
                    maxFrequency = frequency;
                    mode = number;
                }
            }

            return mode;
        }

        private static int[] CreateFrequencyTable(int[] numbers)
        {
            var max = numbers.Max();
            var frequencyTable = new int[max+1];
            foreach (var number in numbers)
            {
                frequencyTable[number]++;
            }
            return frequencyTable;
        }
    }
}
