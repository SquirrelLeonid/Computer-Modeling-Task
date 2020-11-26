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

        private int minimumChartWidth;
        private int minimumChartHeight;
        
        private Point _prevMousePos;
        private bool isMouseDown = false;

        public Form1()
        {
            InitializeComponent();
            AddEvents();
            InitFields();
               
        }       

        private void AddEvents()
        {
            Chart.MouseWheel += new MouseEventHandler(Chart_MouseWheel);
        }

        private void InitFields()
        {
            _manager = new ChartManager(Chart);
            minimumChartWidth = Chart.Size.Width;
            minimumChartHeight = Chart.Size.Height;
        }

        private void Chart_MouseWheel(object sender, MouseEventArgs e)
        {
            var oldChartSize = Chart.Size;

            if (e.Delta > 0)
                Chart.Size = new Size(Chart.Size.Width + minimumChartWidth / 10, Chart.Size.Height + minimumChartHeight / 10);
            else if (e.Delta < 0)
            {
                int newWidth = Chart.Size.Width - minimumChartWidth / 10;
                int newHeight = Chart.Size.Height - minimumChartHeight / 10;
                if (newWidth >= minimumChartWidth && newHeight >= minimumChartHeight)
                    Chart.Size = new Size(newWidth, newHeight);
            }
        }

        private void ExampleChart_Button_Click(object sender, EventArgs e)
        {
            ExampleChartBuilder.BuildExampleChart(Chart);
        }

        private void ClearChartArea_Button_Click(object sender, EventArgs e)
        {
            _manager.ClearAll();
        }

        private void Draw_Button_Click(object sender, EventArgs e)
        {
            if (AreFieldsEmpty())
                return;

            string choosedChart = ChooseChart_ComboBox.SelectedItem.ToString();
            string choosedMethod = ChooseMethod_ComboBox.SelectedItem.ToString();

            var startX = 1.0;
            var startY = 0.0;
            var stepValue = 0.0;
            var iterations = 0;

            if (StartX_TextBox.Text.Length != 0 && StartY_TextBox.Text.Length != 0)
            {
                if (!double.TryParse(StartX_TextBox.Text, out startX) || !double.TryParse(StartY_TextBox.Text, out startY))
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

            if (Iterations_TextBox.Text.Length != 0 && !int.TryParse(Iterations_TextBox.Text, out iterations)
                || iterations < 0)
            {
                MessageBox.Show("Недопустимое количество итераций.");
                return;
            }

            BaseChart chartType = GetChartType();
            double[] parameters = GetParameters();
            string methodName = ChooseMethod_ComboBox.SelectedItem.ToString();
            _manager.Draw(chartType, methodName, startX, startY, stepValue, iterations, parameters);
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

        private void Chart_MouseDown(object sender, MouseEventArgs e)
        {
            _prevMousePos = e.Location;
            isMouseDown = true;
            System.Windows.Forms.Cursor.Current = Cursors.Hand;
        }

        //TODO: Попробовать решить проблему с мерцанием
        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int mousePosX = e.X;
                int mousePosY = e.Y;

                int diffX = mousePosX - _prevMousePos.X;
                int diffY = mousePosY - _prevMousePos.Y;

                Chart.Location = new Point(Chart.Location.X + diffX, Chart.Location.Y + diffY);

                _prevMousePos.X = mousePosX;
                _prevMousePos.Y = mousePosY;
            }
        }

        private void Chart_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ChooseChart_ComboBox.SelectedIndex = 1;
            ChooseMethod_ComboBox.SelectedIndex = 1;
            StartX_TextBox.Text = "1";
            StartY_TextBox.Text = "0";           
        }
    }
}
