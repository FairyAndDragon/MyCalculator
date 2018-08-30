using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCalculator.Common
{
    public class AdditionFactory 
    {
        public Operation CreateAddition(string numberA,string numberB)
        {
            return new OperationAddition(numberA, numberB);
        }
        public static T Add<T>(T a, T b) where T : struct
        {
            string ts = typeof(T).ToString();
            switch (ts.Substring(ts.LastIndexOf(".") + 1))
            {
                case "Int32"://int类型
                    {
                        int sum = Convert.ToInt32(a) + Convert.ToInt32(b);
                        return (T)Convert.ChangeType(sum, typeof(T));
                    }
                case "Single"://float类型
                    {
                        Double sum = Convert.ToDouble(a) + Convert.ToDouble(b);
                        return (T)Convert.ChangeType(sum, typeof(T));
                    }
                case "Double"://double
                    {
                        Double sum = Convert.ToDouble(a) + Convert.ToDouble(b);
                        return (T)Convert.ChangeType(sum, typeof(T));
                    }
                default://error
                    {
                        return (T)(new object());
                    }
            }
        }

    }
}