using System.Windows.Forms.DataVisualization.Charting;

namespace Computer_Modeling_Task
{
    public static class EulerChartBuilder
    {
        private const int _HalfAxisLength = 10;

        private const double _intervalAxisX = 1;
        private const double _intervalAxisY = 1;

        private static readonly string _seriesName = "XY_EulerSeries";

        private const double _startPointX = 1;
        private const double _startPointY = 0;
        private static double _defaultStepValue = 0.01;
        private static int _defaultIterationsCount = 5000;

        public static void BuildEulerChart(Chart chart)
        {
            //SetAxisOptions(chart.ChartAreas[0]);
            DrawChartValues(chart);
        }

        private static void DrawChartValues(Chart chart)
        {
            double prevX = _startPointX;
            double prevY = _startPointY;
            chart.Series.FindByName(_seriesName).Points.AddXY(prevX, prevY);

            for (int i = 0; i < _defaultIterationsCount; i++)
            {
                double nextX = prevX + _defaultStepValue * f(prevX, prevY);
                double nextY = prevY + _defaultStepValue * g(prevX, prevY);

                chart.Series.FindByName(_seriesName).Points.AddXY(nextX, nextY);

                prevX = nextX;
                prevY = nextY;
            }
        }

        private static double f(double x, double y)
        {
            return y;
        }

        private static double g(double x, double y)
        {
            return -x;
        }

        private static void SetAxisOptions(ChartArea chartArea)
        {
            chartArea.AxisX.Minimum = -_HalfAxisLength;
            chartArea.AxisX.Maximum = _HalfAxisLength;

            chartArea.AxisY.Minimum = -_HalfAxisLength;
            chartArea.AxisY.Maximum = _HalfAxisLength;

            chartArea.AxisX.Interval = _intervalAxisX;
            chartArea.AxisY.Interval = _intervalAxisY;
        }
    }     
}
