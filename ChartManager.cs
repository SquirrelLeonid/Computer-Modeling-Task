using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Computer_Modeling_Task
{
    public class ChartManager
    {
        private Chart _chart;
        private Size _defaultSize;

        private int _iterations;       
        private double _stepValue;

        private const int _defaultIterations = 1500;
        private const double _default_stepValue = 0.01;
        private const double RungeKuttConst = (1.0 / 6);

        public ChartManager(Chart chart)
        {
            _chart = chart;
            _defaultSize = _chart.Size;
        }

        public void ClearAll()
        {
            _chart.Series.Clear();
            _chart.Legends.Clear();
            _chart.Size = _defaultSize;
            _chart.Location = new Point(0, 0);            
        }

        public void Draw(BaseChart chart, string method, double startX, double startY,
            double stepValue, int iterations, double[] parameters)
        {
            _stepValue = stepValue == 0 ? _default_stepValue : stepValue;
            _iterations = iterations == 0 ? _defaultIterations : iterations;

            string fullName = GetFullName(chart.BaseName, startX, startY, parameters);
            if (_chart.Series.FindByName(fullName) == null)
                SetupSeries(fullName);

            if (method.Equals("Метод Эйлера"))
                DrawWithEulerMethod(chart, _chart.Series[fullName], startX, startY, parameters);
            else if (method.Equals("Метод Рунге-Кутта"))
                DrawWithRungeKutt(chart, _chart.Series[fullName], startX, startY, parameters);
        }

        private string GetFullName(string baseName, double x, double y, params double[] parameters)
        {
            var builder = new StringBuilder();
            builder.Append(baseName).Append("(X= ").Append(x).Append("; Y= ").Append(y).Append(") ");
            if (parameters != null && parameters.Length != 0)
            {
                builder.Append("{");
                for (int i = 0; i < parameters.Length; i++)
                    builder.Append(parameters[i]).Append("; ");
                builder.Append("}");
            }

            return builder.ToString().Trim();
        }

        private void SetupSeries(string seriesName)
        {
            _chart.Series.Add(new Series(seriesName));            
            _chart.Legends.Add(new Legend(seriesName));
            _chart.ChartAreas[0].AxisX.LabelStyle.Format = "{0.00}";
            _chart.Series[seriesName].ChartType = SeriesChartType.Spline;
            _chart.Legends[seriesName].Font = new Font("TimesNewRoman", 11);

            var random = new Random();
            _chart.Series[seriesName].Color = Color.FromArgb(random.Next(256), random.Next(128), random.Next(196));
        }

        private void DrawWithEulerMethod(BaseChart chart, Series series, double x, double y, double[] parameters)
        {
            for (int i = 0; i < _iterations; i++)
            {
                series.Points.AddXY(x, y);

                /*Если попытаться написать x += _stepValue * chart.f(x, y); y += _stepValue * chart.g(x, y);
                 * То теряются какие то знаки после запятой, почему?
                 * */                
                double nextX = x + _stepValue * chart.f(x, y);
                double nextY = y + _stepValue * chart.g(x, y);
                
                x = nextX;
                y = nextY;
            }
        }

        private void DrawWithRungeKutt(BaseChart chart, Series series, double x, double y, double[] parameters)
        {
            for (int i = 0; i < _iterations; i++)
            {
                double k1 = _stepValue * chart.f(x, y, parameters);
                double l1 = _stepValue * chart.g(x, y, parameters);

                double k2 = _stepValue * chart.f(x + k1 / 2, y + l1 / 2, parameters);
                double l2 = _stepValue * chart.g(x + k1 / 2, y + l1 / 2, parameters);

                double k3 = _stepValue * chart.f(x + k2 / 2, y + l2 / 2, parameters);
                double l3 = _stepValue * chart.g(x + k2 / 2, y + l2 / 2, parameters);

                double k4 = _stepValue * chart.f(x + k3, y + l3, parameters);
                double l4 = _stepValue * chart.g(x + k3, y + l3, parameters);

                series.Points.AddXY(x, y);

                x += RungeKuttConst * Math.Round(k1 + 2 * k2 + 2 * k3 + k4, 5);
                y += RungeKuttConst * Math.Round(l1 + 2 * l2 + 2 * l3 + l4, 5);
            }
        }
    }
}
