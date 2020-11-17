namespace Computer_Modeling_Task
{
    public class TestChart : BaseChart
    {
        private static readonly string _defaultName = "Test_example";

        public TestChart()
        {
            BaseName = _defaultName;
            //SerialNumber = ;
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
