using System;
using System.Collections.Generic;
using System.Text;

namespace WisMaster_Console
{
    class ScoreL1_L4
    {
        public static bool CheckIfRightAnswer()
        {
            bool answer = false;

            L1_L4.sum.Answer = L1_L4.sum.Digit1 + L1_L4.sum.Digit2;

            switch (L1_L4.property)
            {
                case L1_L4.Property.add:
                    L1_L4.sum.Answer = L1_L4.sum.Digit1 + L1_L4.sum.Digit2;
                    break;
                case L1_L4.Property.subtract:
                    L1_L4.sum.Answer = L1_L4.sum.Digit1 - L1_L4.sum.Digit2;
                    break;
                case L1_L4.Property.devide:
                    L1_L4.sum.Answer = L1_L4.sum.Digit1 / L1_L4.sum.Digit2;
                    break;
                case L1_L4.Property.multiply:
                    L1_L4.sum.Answer = L1_L4.sum.Digit1 * L1_L4.sum.Digit2;
                    break;
            }

            int userAnswer = Int32.Parse(Console.ReadLine());

            if (L1_L4.sum.Answer == userAnswer)
            {
                answer = true;
            }

            return answer;
        }

        public static void GenerateScore(TimeSpan time)
        {
            double scoreTime = time.TotalSeconds;

            switch (Program.level)
            {
                case 1:
                    Program.score = 400 / scoreTime;
                    break;
                case 2:
                    Program.score = 500 / scoreTime;
                    break;
                case 3:
                    Program.score = 400 / scoreTime;
                    break;
                case 4:
                    Program.score = 400 / scoreTime;
                    break;
            }

            Console.WriteLine("Score: {0}", (int)Program.score);
        }
    }
}
