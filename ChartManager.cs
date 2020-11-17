using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Computer_Modeling_Task
{
    public class ChartManager
    {        
        private ChartArea _chartArea;
        private SeriesCollection _series;
        private int _defaultIterations = 1000;
        private double _defaultStepValue = 0.01;
        private const double RungeKuttConst = (1.0 / 6);
        
        public ChartManager(Chart chart)
        {
            _series = chart.Series;
            _chartArea = chart.ChartAreas[0];            
        }

        public void Draw(BaseChart chart, string method, double startX, double startY,
            double stepValue, int iterationsCount, double[] parameters)
        {
            if (stepValue == 0)
                stepValue = _defaultStepValue;
            if (iterationsCount == 0)
                iterationsCount = _defaultIterations;
                
            string seriesName = chart.BaseName + "_" + method + "_Series";
            if (_series.FindByName(seriesName) == null)
                SetupSeries(seriesName);

            if (method.Equals("Метод Эйлера"))
                DrawWithEulerMethod(chart, _series[seriesName], startX, startY, iterationsCount, stepValue, parameters);
            else if (method.Equals("Метод Рунге-Кутта"))
                DrawWithRungeKutt(chart, _series[seriesName], startX, startY, iterationsCount, stepValue, parameters);
        }

        private void SetupSeries(string seriesName)
        {
            _series.Add(new Series(seriesName));
            _series[seriesName].ChartType = SeriesChartType.Spline;
            _series[seriesName].Color = System.Drawing.Color.Red;
        }

        private void DrawWithEulerMethod(BaseChart chart, Series series, double startX, double startY,
            int iterationsCount, double stepValue, double[] parameters)
        {

            double prevX = startX;
            double prevY = startY;
            series.Points.AddXY(prevX, prevY);

            for (int i = 0; i < iterationsCount; i++)
            {
                double nextX = prevX + stepValue * chart.f(prevX, prevY);
                double nextY = prevY + stepValue * chart.g(prevX, prevY);

                series.Points.AddXY(nextX, nextY);

                prevX = nextX;
                prevY = nextY;
            }
        }

        //TODO: Сделать красиво
        private void DrawWithRungeKutt(BaseChart chart, Series series, double startX, double startY,
            int iterationsCount, double stepValue, double[] parameters)
        {
            double prevX = startX;
            double prevY = startY;
            double a = parameters[0];
            series.Points.AddXY(prevX, prevY);

            for (int i = 0; i < iterationsCount; i++)
            {
                double k1 = stepValue * chart.f(prevX, prevY);
                double l1 = stepValue * chart.g(prevX, prevY, a);
                double k2 = stepValue * chart.f(prevX + k1 / 2, prevY + l1 / 2);
                double l2 = stepValue * chart.g(prevX + k1 / 2, prevY + l1 / 2, a);
                double k3 = stepValue * chart.f(prevX + k2 / 2, prevY + l2 / 2);
                double l3 = stepValue * chart.g(prevX + k2 / 2, prevY + l2 / 2, a);
                double k4 = stepValue * chart.f(prevX + k3, prevY + l3);
                double l4 = stepValue * chart.g(prevX + k3, prevY + l3, a);

                double K = Math.Round(k1 + 2 * k2 + 2 * k3 + k4, 5);
                double L = Math.Round(l1 + 2 * l2 + 2 * l3 + l4, 5);
                double nextX = prevX + RungeKuttConst * K;
                double nextY = prevY + RungeKuttConst * L;

                series.Points.AddXY(prevX, prevY);

                prevX = nextX;
                prevY = nextY;
            }
        }
    }
}
