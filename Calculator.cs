using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class CalculatorHelper
    {
        public static float Add(float x, float y) { return x + y; }

        public static float Subtract(float x, float y) { return x - y; }

        public static float Divide(float x, float y)
        {
            if (y == 0) throw new ArgumentException("Non è possibile dividere per zero!");
            return x / y;
        }

        public static float Multiply(float x, float y) { return x * y; }
        
    }
}
