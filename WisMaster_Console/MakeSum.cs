using System;
using System.Collections.Generic;
using System.Text;

namespace WisMaster_Console
{
    public static class MakeSum
    {
        public static void GenerateSumL1_L4()
        {
            //Generate random digits for sum
            Random random = new Random();
            L1_L4.sum.Digit1 = random.Next(0, 9);
            L1_L4.sum.Digit2 = random.Next(0, 9);

            switch (Program.level)
            {
                case 1:
                    L1_L4.sum.property = 0;
                    break;
                case 2:
                    int a = random.Next(0, 1);
                    L1_L4.sum.property = (L1_L4.Property)a;
                    break;
                case 3:
                    int b = random.Next(0, 2);
                    L1_L4.sum.property = (L1_L4.Property)b;
                    break;
                case 4:
                    int c = random.Next(0, 3);
                    L1_L4.sum.property = (L1_L4.Property)c;
                    break;
            }
        }
    }
}
