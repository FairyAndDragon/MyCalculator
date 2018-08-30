using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Common
{
    class OperationMultiply:Operation,ICalculator
    {
        public OperationMultiply(string numberA, string numberB) : base(numberA, numberB)
        {
        }
        public OperationMultiply()
        {
        }
        T ICalculator.CalculatorMethod<T>(T numberA, T numberB)
        {
            string ts = typeof(T).ToString();
            switch (ts.Substring(ts.LastIndexOf(".") + 1))
            {
                case "Int32"://int
                    {
                        int sum = Convert.ToInt32(numberA) * Convert.ToInt32(numberB);
                        return (T)Convert.ChangeType(sum, typeof(T));
                    }
                case "Single"://float
                    {
                        float sum = Convert.ToSingle(numberA) * Convert.ToSingle(numberB);
                        return (T)Convert.ChangeType(sum, typeof(T));
                    }
                case "Double"://double
                    {
                        double sum = Convert.ToDouble(numberA) * Convert.ToDouble(numberB);
                        return (T)Convert.ChangeType(sum, typeof(T));
                    }
                default://error
                    {

                        return (T)(new object());
                    }
            }
        }

        public override string GetResult()
        {
            int intNumberA = 0, intNumberB = 0;
            float floatNumberA = 0, floatNumberB = 0;
            double doubleNumberA, doubleNumberB = 0;
            string sum = null;
            ICalculator calculator = new OperationMultiply();

            int type = JudgeType();

            switch (type)
            {
                case 0:
                    {
                        intNumberA = int.Parse(NumberA);
                        intNumberB = int.Parse(NumberB);
                        sum = calculator.CalculatorMethod<Int32>(intNumberA, intNumberB).ToString();
                        break;
                    }
                case 1:
                    {
                        floatNumberA = float.Parse(NumberA);
                        floatNumberB = float.Parse(NumberB);
                        sum = calculator.CalculatorMethod<float>(floatNumberA, floatNumberB).ToString();
                        break;
                    }
                case 2:
                    {
                        doubleNumberA = double.Parse(NumberA);
                        doubleNumberB = double.Parse(NumberB);
                        sum = calculator.CalculatorMethod<double>(doubleNumberA, doubleNumberB).ToString();
                        break;
                    }
                default:
                    {
                        sum = "error";
                        break;
                    }
            }

            return sum;
        }
    }
}
