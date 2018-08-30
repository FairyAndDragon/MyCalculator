using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MyCalculator.IDAL;
using MyCalculator.Common;
using System.Text.RegularExpressions;

namespace MyCalculator.DAL
{
    public class CalculatorDAL//:ICalculator
    {
        private string expression = null;
        public CalculatorDAL(string expression)
        {
            this.expression = expression;
        }
       
        public string GetResult()
        {
            string[] str = expression.Split(new char[4] { '+', '-', '/', '*' });
            string result = null;

            if (str.Length == 1)
                return Convert.ToDouble(str[0]).ToString();
            else
            {
                //第一个数带符号问题
                if (str.Length == 3)
                {
                    str[0] = "-"+ str[1];
                    str[1] = str[2]; 
                }
                char c = expression.ToCharArray()[expression.IndexOf(str[0]) + str[0].Length];
                //string pattern = @"^-?\d+$";//判断整数?
                //Regex regex = new Regex(pattern);
                switch (c)
                {
                    case '+':
                        {
                            AdditionFactory additionFactory = new AdditionFactory();
                            Operation operateAddition = additionFactory.CreateAddition(str[0],str[1]);
                            result = operateAddition.GetResult();
                            break;
                        }
                    case '-':
                        {
                            SubtractionFactory subtractionFactory = new SubtractionFactory();
                            Operation operateSubtraction = subtractionFactory.CreateSubtraction(str[0], str[1]);
                            result = operateSubtraction.GetResult();
                            break;
                        }
                    case '*':
                        {
                            MultiplyFactory additionFactory = new MultiplyFactory();
                            Operation operateMultiply = additionFactory.CreateMultiply(str[0], str[1]);
                            result = operateMultiply.GetResult();
                            break;
                        }
                    case '/':
                        {
                            DivideFactory additionFactory = new DivideFactory();
                            Operation operateDivide = additionFactory.CreateDivide(str[0], str[1]);
                            result = operateDivide.GetResult();
                            break;
                        }
                    default: result = "error"; break;
                }

            }
            return result.ToString();
        }
    }
}
