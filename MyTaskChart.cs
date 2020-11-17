namespace Computer_Modeling_Task
{
    public class MyTaskChart : BaseChart
    {
        private static readonly string _defaultName = "MyTask_Chart";

        public MyTaskChart()
        {
            BaseName = _defaultName;
        }

        public override double f(double x, double y, params double[] parameters)
        {
            return y;
        }

        //TODO: подробнее обработать разное количество параметров, Сейчас предполагаю нужный параметр всегда есть
        public override double g(double x, double y, params double[] parameters)
        {
            double a = parameters[0];
            return (a + x * x - (x * x * x * x)) * y - x;
        }
    }
}
