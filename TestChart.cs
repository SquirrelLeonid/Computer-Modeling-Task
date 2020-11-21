using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Modeling_Task
{
    public class TestChart : BaseChart
    {
        private readonly string _defaultName = "TestExample";

        public TestChart()
        {
            BaseName = _defaultName;
        }

        public override double f(double x, double y, params double[] parameters)
        {
            return y;
        }

        public override double g(double x, double y, params double[] parameters)
        {
            return -x;
        }
    }
}
