namespace csharpIfCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    var input = Console.ReadLine();
            //    var iValue = Int32.Parse(input);

            //    int n = 7;


            //    if (0 == iValue % 3)
            //    {
            //        Console.WriteLine("{n}의 배수"); 
            //    }
            //    else
            //    {
            //        Console.WriteLine("홀수");  
            //    }

            //time
            //Console.WriteLine(DateTime.Now.Year);
            //Console.WriteLine(DateTime.Now.Month);
            //Console.WriteLine(DateTime.Now.Day);
            //Console.WriteLine(DateTime.Now.Date);

            //time2
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전");
            }
            else if (DateTime.Now.Hour == 12)
            {
                Console.WriteLine("정오");
            }
            else
            {
                Console.WriteLine("오후");
            }

        }
    }
}