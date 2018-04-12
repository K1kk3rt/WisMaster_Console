using System;
using System.Collections.Generic;
using System.Text;

namespace WisMaster_Console
{
    public static class L1_L4
    {
        public static Sum sum = new Sum();
        public static Property property = new Property();

        public struct Sum
        {
            public int Digit1;
            public int Digit2;
            public Property property;
            public int Answer;
        }

        public enum Property
        {
            add, subtract, devide, multiply
        };
    }
    
}
