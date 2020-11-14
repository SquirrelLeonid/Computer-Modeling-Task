using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace Computer_Modeling_Task
{
    public static class ExampleChartBuilder
    {
        private const int valuesCount = 15;
        private const int minRandomValue = 1;
        private const int maxRandomValue = 21;

        private static readonly string seriesName = "XY_ExampleValues";    

        public static void BuildExampleChart(Chart chart)
        {
            int[] yValues = GetValues();
            DrawChartValues(chart, yValues);
        }

        private static int[] GetValues()
        {
            var random = new Random();
            var values = new int[valuesCount];
            for (int i = 0; i < valuesCount; i++)
                values[i] = random.Next(minRandomValue, maxRandomValue);
            return values;
        }

        private static void DrawChartValues(Chart chart, int[] yValues)
        {
            for (int i = 0; i < valuesCount; i++)
                chart.Series[seriesName].Points.AddXY(i, yValues[i]);
        }
    }
}
