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

        private void Draw_Button_Click(object sender, EventArgs e)
        {
            if (AreFieldsEmpty())
                return;

            string choosedChart = ChooseChart_ComboBox.SelectedItem.ToString();
            string choosedMethod = ChooseMethod_ComboBox.SelectedItem.ToString();

            double startPointX = 1.0;
            double startPointY = 0.0;

            if (StartX_TextBox.Text.Length != 0 && StartY_TextBox.Text.Length != 0)
            {
                if (!double.TryParse(StartX_TextBox.Text, out startPointX) || !double.TryParse(StartX_TextBox.Text, out startPointY))
                    MessageBox.Show("Недопустимые координаты.");           
            }       
            

        } 
        
        private bool AreFieldsEmpty()
        {
            if (ChooseChart_ComboBox.SelectedItem == null || ChooseMethod_ComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите график и метод");
                return true;
            }

            else if (StartX_TextBox.Text.Length == 0 && StartY_TextBox.Text.Length != 0)
            {
                MessageBox.Show("Введите X координату");
                return true;
            }

            else if (StartX_TextBox.Text.Length != 0 && StartY_TextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите Y координату");
                return true;
            }

            return false;
        }
    }
}
