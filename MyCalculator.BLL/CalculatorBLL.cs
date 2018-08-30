using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalculator.DAL;

namespace MyCalculator.BLL
{
    /// <summary>
    /// 单例模式的实现
    /// </summary>
    public class CalculatorBLL
    {

        #region 单例模式
        private static CalculatorBLL instance;
        private static object _lock = new object();

        private CalculatorBLL()
        {
        }
        public static CalculatorBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new CalculatorBLL();
                        }
                    }
                }
                return instance;
            }
        }
        #endregion 单例模式


        public string GetResult(string expression)
        {
            
            DAL.CalculatorDAL calculatorDAL = new DAL.CalculatorDAL(expression);
            return calculatorDAL.GetResult();
        }
        //public List<NFine.Entity.Views.VCustomersMessage> GetList(string queryJson)
        //{
        //    return DAL.Self.CustomersMessageDAL.Instance.GetList(queryJson);
        //}

        //public bool Delete(string keyValue)
        //{
        //    return DAL.Self.CustomersMessageDAL.Instance.Delete(keyValue);
        //}
    }
}