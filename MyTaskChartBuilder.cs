using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Computer_Modeling_Task
{
    public static class MyTaskChartBuilder
    {
        private const double HalfAxisLength = 4;
        private const double IntervalAxisX = 1;
        private const double IntervalAxisY = 1;

        private static readonly string seriesName = "XY_MyTaskSeries";

        private const double _startPointX = 1;
        private const double _startPointY = 2;
        private const double _defaultStepValue = 0.01;
        private const double _defaultIterationsCount = 5000;

        public static void BuildMyTaskChart(Chart chart, double a)
        {
            //SetAxisOptions(chart.ChartAreas[0]);
            DrawChartValues(chart,a);
        }

        private static void DrawChartValues(Chart chart, double a)
        {
            double prevX = _startPointX;
            double prevY = _startPointY;
            chart.Series.FindByName(seriesName).Points.AddXY(prevX, prevY);

            for (int i = 0; i < _defaultIterationsCount; i++)
            {
                double k1 = _defaultStepValue * f(prevX, prevY);
                double l1 = _defaultStepValue * g(prevX, prevY, a);
                double k2 = _defaultStepValue * f(prevX + k1 / 2, prevY + l1 / 2);
                double l2 = _defaultStepValue * g(prevX + k1 / 2, prevY + l1 / 2, a);
                double k3 = _defaultStepValue * f(prevX + k2 / 2, prevY + l2 / 2);
                double l3 = _defaultStepValue * g(prevX + k2 / 2, prevY + l2 / 2, a);
                double k4 = _defaultStepValue * f(prevX + k3, prevY + l3);
                double l4 = _defaultStepValue * g(prevX + k3, prevY + l3, a);

                double K = Math.Round(k1 + 2 * k2 + 2 * k3 + k4, 5);
                double L = Math.Round(l1 + 2 * l2 + 2 * l3 + l4, 5);
                double nextX = prevX + (1.0 / 6.0) * K;
                double nextY = prevY + (1.0 / 6.0) * L;

                chart.Series.FindByName(seriesName).Points.AddXY(prevX, prevY);

                prevX = nextX;
                prevY = nextY;
            }
        }

        private static double f(double x, double y)
        {
            return y;
        }

        private static double g(double x, double y, double a)
        {
            return (a + x * x - (x * x * x * x)) * y - x;
        }

        private static void SetAxisOptions(ChartArea chartArea)
        {
            chartArea.AxisX.Minimum = -HalfAxisLength;
            chartArea.AxisX.Maximum = HalfAxisLength;

            chartArea.AxisY.Minimum = -HalfAxisLength;
            chartArea.AxisY.Maximum = HalfAxisLength;

            chartArea.AxisX.Interval = IntervalAxisX;
            chartArea.AxisY.Interval = IntervalAxisY;
        }
    }
}
