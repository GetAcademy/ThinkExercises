using System.Linq;

namespace ThinkExercises
{
    internal class Exercise3_3
    {
        /*
            3-3 Write a bool function that is passed an array and the number of elements in
            that array and determines whether the data in the array is sorted. This should
            require only one pass!         
         */

        public static void Run()
        {
            var numbers1 = new[] {1, 9, 3, 4, 9, 5, 2, 5, 5, 8, 9, 7, 5, 5, 9, 9, 9};
            var numbers2 = new[] {1, 2, 3, 4, 5, 6};

            Console.WriteLine(IsSorted(numbers1));
            Console.WriteLine(IsSorted(numbers2));
        }

        private static bool IsSorted(int[] numbers)
        {
            var lastNumber = int.MinValue;
            foreach (var number in numbers)
            {
                if (number < lastNumber) return false;
                lastNumber = number;
            }

            return true;
        }

        private static bool IsSorted2(int[] numbers)
        {
            for (var i = 1; i < numbers.Length;)
            {
                if (numbers[i] < numbers[i - 1]) return false;
            }

            return true;
        }

        private static bool IsSorted3(int[] numbers)
        {
            return !numbers
                .Select((value, index) => index)
                .Any(i => i > 0 && numbers[i] < numbers[i - 1]);
        }
    }
}
