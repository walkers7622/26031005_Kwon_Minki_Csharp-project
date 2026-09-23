namespace CsharpPractice04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16번
            //for (int i = 2; i <= 100; i += 2)
            //{
            //    Console.Write(i);
            //}

            //17번
            //int i = 0;
            //while (i < 11)
            //{
            //    Console.Write(i);
            //    Console.Write('\n');
            //    i++;
            //}

            //18번
            //int number = 1;
            //do
            //{
            //    if (number % 2 != 0)
            //    {
            //        Console.Write(number);
            //    }
            //    number++;
            //} while (number <= 10);

            //19번
            //int n = 8; 
            //for (int i = 0; i < n; i++)
            //{

            //    for (int j = 0; j < n - i - 1; j++)
            //    {
            //        Console.Write(" ");
            //    }


            //    for (int k = 0; k < 2 * i + 1; k++)
            //    {
            //        Console.Write("*");
            //    }   
            //    Console.WriteLine();
            //}

            //20번
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"숫자를 입력해주세요: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"가장 작은 수: {min}");
            Console.WriteLine($"가장 큰 수: {max}");
        }
    }
}
