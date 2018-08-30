using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator.Common
{
   
    public interface ICalculator
    {
        T CalculatorMethod<T>(T numberA, T numberB) where T : struct;
        // T CalculatorMethod<T>(ref T numberA, ref T numberB) where T : struct;

        //方法：PushNum PushCal BackAWord(退格) Reset（重置）
        //   ClearOneOppend（清除当前操作数）
        //属性：Result 只读格式只有一个get方法 供外界调用
    }
}
