using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalculator.Common
{
    public class DivideFactory
    {
        public Operation CreateDivide(string numberA, string numberB)
        {
            return new OperationDivide(numberA, numberB);
        }

    }
}