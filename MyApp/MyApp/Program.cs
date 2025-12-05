using System.Globalization;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int evenNumsSum = 0;
            int evenNums = 0;
            int oddNums = 0;
            int oddNumsSum = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"please enter ${i}. index of array");
                int yourChoice = int.Parse(Console.ReadLine());

                numbers[i] = yourChoice;
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    evenNums++;
                    evenNumsSum += numbers[j];
                }
                else
                {
                    oddNums++;
                    oddNumsSum += numbers[j];
                }
            }

            Console.WriteLine("***********************************");

            Console.WriteLine($"even numbers sum: ${evenNumsSum}");
            Console.WriteLine($"even numbers count: ${evenNums}");
            Console.WriteLine("***********************************");
            Console.WriteLine($"odd numbers sum: ${oddNumsSum}");
            Console.WriteLine($"odd numbers count: ${oddNums}");
        }
    }
}