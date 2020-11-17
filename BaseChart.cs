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

        public abstract double f(double x, double y, params double[] parameters);

        public abstract double g(double x, double y, params double[] parametrs);
    }
}
