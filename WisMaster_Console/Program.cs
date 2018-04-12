using System;
using System.Diagnostics;

namespace WisMaster_Console
{
    class Program
    {
        public static int level = 1;
        public static double score = 0;
        public static double totalScore = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welkom to WisMaster! Press any key to start...");

            Console.ReadKey();
            
            while (level <= 4)
            {
                MakeSum.GenerateSumL1_L4();
                UIL1_L4.PrintSum();

                //start timer for score
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                //bereken score wanneer goed antwoord
                if (ScoreL1_L4.CheckIfRightAnswer())
                {
                    stopwatch.Stop();
                    TimeSpan time = stopwatch.Elapsed;
                    Console.WriteLine("Right!");
                    ScoreL1_L4.GenerateScore(time);
                }
                else
                {
                    stopwatch.Stop();
                    score = 0;
                    Console.WriteLine("Wrong!");
                }

                totalScore = totalScore + score;

                //bepaal level
                if (totalScore < 1000) { level = 1; }
                if (totalScore < 2000) { level = 2; }
                if (totalScore < 3500) { level = 3; }
                if (totalScore < 5000) { level = 4; }

                Console.WriteLine("Level: " + level);

                Console.ReadKey();
                
            }
            
            Console.WriteLine("Je hebt level 4 bereikt! Je hebt het spel uitgespeeld!");
            Console.ReadKey();
        }


    }
}
