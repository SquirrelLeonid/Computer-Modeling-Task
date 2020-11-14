using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Computer_Modeling_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddEvents();
            
        }
        
        private void AddEvents()
        {
            Chart.MouseWheel += new MouseEventHandler(Chart_MouseWheel_Scroll);
        }

        private void Chart_MouseWheel_Scroll(object sender, MouseEventArgs e)
        {
            Point mousePos = e.Location;
            Chart.ChartAreas[0].AxisX.ScaleView.Position = 30;
        }

        private void EulerMethod_Button_Click(object sender, EventArgs e)
        {
            ChartPreparer.PrepareChart(Chart);
            EulerChartBuilder.BuildEulerChart(Chart);            
        }

        private void RungeKutt_Button_Click(object sender, EventArgs e)
        {
            ChartPreparer.PrepareChart(Chart);
            RungeKuttChartBuilder.BuildRungeKuttChart(Chart);
        }

        private void ExampleChart_Button_Click(object sender, EventArgs e)
        {
            ChartPreparer.PrepareChart(Chart);
            ExampleChartBuilder.BuildExampleChart(Chart);
        }

        private void ClearChartArea_Button_Click(object sender, EventArgs e)
        {
            foreach (var series in Chart.Series)
                series.Points.Clear();
        }

        private void TaskChart_Button_Click(object sender, EventArgs e)
        {           
            ChartPreparer.PrepareChart(Chart);
            MyTaskChartBuilder.BuildMyTaskChart(Chart, double.Parse(textBox1.Text));
        }
    }
}
