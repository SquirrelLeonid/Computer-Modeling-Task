namespace Computer_Modeling_Task
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExampleChart_Button = new System.Windows.Forms.Button();
            this.TaskChart_Button = new System.Windows.Forms.Button();
            this.RungeKutt_Button = new System.Windows.Forms.Button();
            this.EulerMethod_Button = new System.Windows.Forms.Button();
            this.ClearChartArea_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.Name = "MainArea";
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Location = new System.Drawing.Point(12, 100);
            this.Chart.Name = "Chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "MainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.Name = "XY_ExampleValues";
            series2.ChartArea = "MainArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Name = "XY_EulerSeries";
            series3.ChartArea = "MainArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.GreenYellow;
            series3.Name = "XY_RungeKuttSeries";
            series4.ChartArea = "MainArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Yellow;
            series4.Name = "XY_MyTaskSeries";
            this.Chart.Series.Add(series1);
            this.Chart.Series.Add(series2);
            this.Chart.Series.Add(series3);
            this.Chart.Series.Add(series4);
            this.Chart.Size = new System.Drawing.Size(988, 535);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // ExampleChart_Button
            // 
            this.ExampleChart_Button.Location = new System.Drawing.Point(853, 12);
            this.ExampleChart_Button.Name = "ExampleChart_Button";
            this.ExampleChart_Button.Size = new System.Drawing.Size(128, 43);
            this.ExampleChart_Button.TabIndex = 1;
            this.ExampleChart_Button.Text = "Тестовый график";
            this.ExampleChart_Button.UseVisualStyleBackColor = true;
            this.ExampleChart_Button.Click += new System.EventHandler(this.ExampleChart_Button_Click);
            // 
            // TaskChart_Button
            // 
            this.TaskChart_Button.Location = new System.Drawing.Point(244, 22);
            this.TaskChart_Button.Name = "TaskChart_Button";
            this.TaskChart_Button.Size = new System.Drawing.Size(112, 33);
            this.TaskChart_Button.TabIndex = 4;
            this.TaskChart_Button.Text = "Мое задание";
            this.TaskChart_Button.UseVisualStyleBackColor = true;
            this.TaskChart_Button.Click += new System.EventHandler(this.TaskChart_Button_Click);
            // 
            // RungeKutt_Button
            // 
            this.RungeKutt_Button.Location = new System.Drawing.Point(12, 61);
            this.RungeKutt_Button.Name = "RungeKutt_Button";
            this.RungeKutt_Button.Size = new System.Drawing.Size(125, 33);
            this.RungeKutt_Button.TabIndex = 3;
            this.RungeKutt_Button.Text = "Метод Рунге-Кутта";
            this.RungeKutt_Button.UseVisualStyleBackColor = true;
            this.RungeKutt_Button.Click += new System.EventHandler(this.RungeKutt_Button_Click);
            // 
            // EulerMethod_Button
            // 
            this.EulerMethod_Button.Location = new System.Drawing.Point(12, 22);
            this.EulerMethod_Button.Name = "EulerMethod_Button";
            this.EulerMethod_Button.Size = new System.Drawing.Size(125, 33);
            this.EulerMethod_Button.TabIndex = 2;
            this.EulerMethod_Button.Text = "Метод Эйлера";
            this.EulerMethod_Button.UseVisualStyleBackColor = true;
            this.EulerMethod_Button.Click += new System.EventHandler(this.EulerMethod_Button_Click);
            // 
            // ClearChartArea_Button
            // 
            this.ClearChartArea_Button.Location = new System.Drawing.Point(413, 22);
            this.ClearChartArea_Button.Name = "ClearChartArea_Button";
            this.ClearChartArea_Button.Size = new System.Drawing.Size(75, 33);
            this.ClearChartArea_Button.TabIndex = 5;
            this.ClearChartArea_Button.Text = "Очистить";
            this.ClearChartArea_Button.UseVisualStyleBackColor = true;
            this.ClearChartArea_Button.Click += new System.EventHandler(this.ClearChartArea_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 694);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClearChartArea_Button);
            this.Controls.Add(this.RungeKutt_Button);
            this.Controls.Add(this.EulerMethod_Button);
            this.Controls.Add(this.TaskChart_Button);
            this.Controls.Add(this.ExampleChart_Button);
            this.Controls.Add(this.Chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Button ExampleChart_Button;
        private System.Windows.Forms.Button TaskChart_Button;
        private System.Windows.Forms.Button RungeKutt_Button;
        private System.Windows.Forms.Button EulerMethod_Button;
        private System.Windows.Forms.Button ClearChartArea_Button;
        private System.Windows.Forms.TextBox textBox1;
    }
}

