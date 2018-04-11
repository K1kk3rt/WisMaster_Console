using System;
using System.Diagnostics;

namespace WisMaster_Console
{
    class Program
    {
        public static SumL1 sum = new SumL1();

        static void Main(string[] args)
        {
            Console.WriteLine("Welkom to WisMaster! Press any key to start...");
            Console.WriteLine("Press 0 to stop");

            Console.ReadKey();
            
            while (true)
            {
                GenerateSumL1();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                if (CheckIfRightAnswer())
                {
                    stopwatch.Stop();
                    TimeSpan time = stopwatch.Elapsed;
                    GenerateScore(time);
                }
                Console.ReadKey();
                
            }
            
            //Console.ReadKey();
        }

        public static void GenerateSumL1()
        {
            //Generate random digits for sum
            Random random = new Random();
            sum.Digit1 = random.Next(0,9);
            sum.Digit2 = random.Next(0, 9);

            PrintSumL1();
        }

        public static void PrintSumL1()
        {
            Console.WriteLine(sum.Digit1.ToString() + " + " + sum.Digit2.ToString() + " =");
        }

        public static bool CheckIfRightAnswer()
        {
            bool answer = false;

            sum.Answer = sum.Digit1 + sum.Digit2;

            int userAnswer = Int32.Parse(Console.ReadLine());

            if (sum.Answer == userAnswer)
            {
                answer = true;
                Console.WriteLine("Right!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            return answer;
        }

        public static void GenerateScore(TimeSpan time)
        {
            double scoreTime = time.TotalSeconds;
            double score = (1/10000) * scoreTime * scoreTime;

            Console.WriteLine("Score: " + score);
        }
    }
}
