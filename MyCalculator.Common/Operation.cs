using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Common
{
    /// <summary>
    /// 区分运算操作
    /// </summary>
    public class Operation //:ICalculator
    {
        /// <summary>
        /// Desc:- 
        /// Default:- 
        /// Nullable:False 
        /// </summary>
        public string NumberA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NumberB { get; set; }

        public Operation(string numberA, string numberB)
        {
            NumberA = numberA;
            NumberB = numberB;
        }
        public Operation()
        {
        }
        public virtual string GetResult()
        {
            return "";
        }
        /// <summary>
        /// 判断数值类型，返回数值的最佳匹配类型
        /// 0==Int32;
        /// 1==float;
        /// 2==douuble;
        /// 3==error.
        /// </summary>
        /// <returns></returns>
        public int JudgeType()
        {
            int intNumberA = 0, intNumberB = 0;
            float  floatNumberA = 0, floatNumberB = 0;
            double doubleNumberA, doubleNumberB = 0;
            //类型判断
            //numberA 为主导
            #region
            if (int.TryParse(NumberA, out intNumberA)) //numberA可以转换为int类型
            {
                if (int.TryParse(NumberB, out intNumberB)) //如果转成int成功则为int
                {
                    return 0;//int类型
                }
            }
            else
            {
                if (float.TryParse(NumberA, out floatNumberA)) //numberA可以转换为float类型
                {
                    if (float.TryParse(NumberB, out floatNumberB)) //numberB可以转换为float类型
                    {
                        return 1;// float类型
                    }
                }
                else
                {
                    if (double.TryParse(NumberA, out doubleNumberA)) //numberA可以转换为double类型
                    {
                        if (double.TryParse(NumberB, out doubleNumberB)) //如果转成double成功则为double
                        {
                            return 2;// double类型
                        }
                    }
                    else
                    {
                        return 3;//error！
                    }
                }
            }
            #endregion
            //numberB 为主导
            #region
            if (double.TryParse(NumberB, out doubleNumberB)) //numberB可以转换为double类型
            {
                if (float.TryParse(NumberA, out floatNumberA)) //numberB可以转换为float类型
                {
                    return 1;//float类型
                }
                else
                {
                    return 2;//double类型
                }
            }
            else
            {
                return 3;//error
            }
            #endregion
        }
        
    }
}
