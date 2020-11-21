using System;

namespace Computer_Modeling_Task
{
    public class MyTaskChart : BaseChart
    {
        private static readonly string _defaultName = "MyTask";

        public MyTaskChart()
        {
            BaseName = _defaultName;
            requireParamsNumber = 1;
        }
      
        public override double f(double x, double y, params double[] parameters)
        {
            return y;
        }
       
        public override double g(double x, double y, params double[] parameters)
        {
            if (parameters.Length < requireParamsNumber)
                throw new ArgumentNullException("Недостаточное количество параметров");
            double a = parameters[0];
            return (a + x * x - (x * x * x * x)) * y - x;
        }
    }
}
