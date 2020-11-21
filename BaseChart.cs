using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Modeling_Task
{
    public abstract class BaseChart
    {
        public int SerialNumber = 0;
        public string BaseName { protected set; get; }
        public int requireParamsNumber { protected set; get; }

        /// <summary>
        /// Передавать параметры в алфавитном порядке
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="parameters"> Параметры, перечисленные по-порядку или переданные массивом </param>
        /// <returns> Возвращает значение функции</returns>
        public abstract double f(double x, double y, params double[] parameters);

        /// <summary>
        /// Передавать параметры в алфавитном порядке
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="parameters"> Параметры, перечисленные по-порядку или переданные массивом </param>
        /// <returns> Возвращает значение функции</returns>
        public abstract double g(double x, double y, params double[] parameters);
    }
}
