using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalculator.Common
{
    public class SubtractionFactory
    {
        public Operation CreateSubtraction(string numberA, string numberB)
        {
            return new OperationSubtraction(numberA, numberB);
        }
    }
}