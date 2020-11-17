using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Computer_Modeling_Task
{
    public partial class Form1 : Form
    {
        private ChartManager _manager;

        public Form1()
        {
            InitializeComponent();
            _manager = new ChartManager(Chart);
        }       

        private void ExampleChart_Button_Click(object sender, EventArgs e)
        {
            ExampleChartBuilder.BuildExampleChart(Chart);
        }

        //TODO: добавить выбор того, что удаляем
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

            double startX = 1.0;
            double startY = 0.0;
            double stepValue = 0.0;
            int iterationsCount = 0;

            if (StartX_TextBox.Text.Length != 0 && StartY_TextBox.Text.Length != 0)
            {
                if (!double.TryParse(StartX_TextBox.Text, out startX) || !double.TryParse(StartX_TextBox.Text, out startY))
                {
                    MessageBox.Show("Недопустимые координаты.");
                    return;
                }
            }

            if (StepValue_TextBox.Text.Length != 0 && !double.TryParse(StepValue_TextBox.Text, out stepValue))
            {
                MessageBox.Show("Недопустимое значение шага.");
                return;
            }

            if (Iterations_TextBox.Text.Length != 0 && !int.TryParse(Iterations_TextBox.Text, out iterationsCount)
                || iterationsCount < 0)
            {
                MessageBox.Show("Недопустимое количество итераций.");
                return;
            }

            BaseChart chartType = GetChartType();
            double[] parameters = GetParameters();
            _manager.Draw(chartType, ChooseMethod_ComboBox.SelectedItem.ToString(),
                startX, startY, stepValue, iterationsCount, parameters);
        } 
        
        private double[] GetParameters()
        {
            var parameters = new List<double>();
            var splitResult = Parameters_TextBox.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (splitResult.Length == 0)
                return null;

            var parameter = 0.0;
            for (int i = 0; i < splitResult.Length; i++)
            {
                if (!double.TryParse(splitResult[i], out parameter))
                {
                    MessageBox.Show("Один или несколько параметров введены неверно.");
                    return null;
                }
                else
                    parameters.Add(parameter);               
            }

            return parameters.ToArray();
        }

        //TODO: как то избавиться от явного задания строк. Переписать return'ы
        private BaseChart GetChartType()
        {
            var choice = ChooseChart_ComboBox.SelectedItem.ToString();
            if (choice.Equals("Тестовый пример"))
               return new TestChart();
            if (choice.Equals("Электрический генератор с жестким возбуждением"))
                return new MyTaskChart();
            return null;
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
