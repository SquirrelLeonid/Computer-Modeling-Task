using System.Windows.Forms.DataVisualization.Charting;

namespace Computer_Modeling_Task
{   
    public static class ChartPreparer
    {
        private const int _halfAxisLength = 2;
        private const int _intervalAxis = 1;

        public static void PrepareChart(Chart chart)
        {
            //SetAxisOptions(chart.ChartAreas[0]);

            /*foreach (var series in chart.Series)
                series.Points.Clear();*/
        }

        private static void SetAxisOptions(ChartArea chartArea)
        {
            chartArea.AxisX.Minimum = -_halfAxisLength;
            chartArea.AxisX.Maximum = _halfAxisLength;

            chartArea.AxisY.Minimum = -_halfAxisLength;
            chartArea.AxisY.Maximum = _halfAxisLength;

            chartArea.AxisX.Interval = _intervalAxis;
            chartArea.AxisY.Interval = _intervalAxis;
        }
    }
}
