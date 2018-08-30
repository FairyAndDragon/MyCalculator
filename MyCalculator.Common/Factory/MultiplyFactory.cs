using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalculator.Common
{
    public class MultiplyFactory
    {
        public Operation CreateMultiply(string numberA, string numberB)
        {
            return new OperationMultiply(numberA, numberB);
        }
    }
}