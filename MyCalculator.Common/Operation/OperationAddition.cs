using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyCalculator.Common
{
   
    public class OperationAddition: Operation,ICalculator
    {
        public OperationAddition(string numberA, string numberB) : base(numberA, numberB)
        {
        }
        public OperationAddition()
        {
        }
        T ICalculator.CalculatorMethod<T>(T numberA, T numberB)
        {
            string ts = typeof(T).ToString();
            switch (ts.Substring(ts.LastIndexOf(".") + 1))
            {
                case "Int32"://int
                    {
                        int sum = Convert.ToInt32(numberA) + Convert.ToInt32(numberB);
                        return (T)Convert.ChangeType(sum, typeof(T));
                    }
                case "Single"://float
                    {
                        float sum = Convert.ToSingle(numberA) + Convert.ToSingle(numberB);
                        return (T)Convert.ChangeType(sum, typeof(T));
                    }
                case "Double"://double
                    {
                        double sum = Convert.ToDouble(numberA) + Convert.ToDouble(numberB);
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
            int  intNumberA = 0, intNumberB = 0;
            float floatNumberA = 0, floatNumberB = 0;
            double doubleNumberA, doubleNumberB = 0;
            string sum = null;
            ICalculator calculator = new OperationAddition();

            int type = JudgeType();

            switch(type)
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
                default :
                    {
                        sum = "error";
                        break;
                    }
            }
                    
                return sum;
            
            //string pattern = @"^-?\d+$";//判断整数?
            //Regex regex = new Regex(pattern);
            //if (regex.IsMatch(NumberA))
            //{
            //    if (regex.IsMatch(NumberB))
            //        //ICalculator.CalculatorMethod(Convert.ToInt32(NumberA), Convert.ToInt32(NumberB));
            //        result = AdditionFactory.Add<Int32>(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));
            //}
            //else
            //    result = AdditionFactory.Add<Double>(Convert.ToDouble(str[0]), Convert.ToDouble(str[1]));
            //return sum;
        }
    }
}
