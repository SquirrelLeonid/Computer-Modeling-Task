﻿namespace Computer_Modeling_Task
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExampleChart_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.StartX_TextBox = new System.Windows.Forms.TextBox();
            this.StartX_Label = new System.Windows.Forms.Label();
            this.StartY_Label = new System.Windows.Forms.Label();
            this.StartY_TextBox = new System.Windows.Forms.TextBox();
            this.ChooseChart_ComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseChart_Label = new System.Windows.Forms.Label();
            this.ChooseMethod_ComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseMethod_Label = new System.Windows.Forms.Label();
            this.StartPoint_Label = new System.Windows.Forms.Label();
            this.Draw_Button = new System.Windows.Forms.Button();
            this.StepValue_Label = new System.Windows.Forms.Label();
            this.Iterations_Label = new System.Windows.Forms.Label();
            this.Iterations_TextBox = new System.Windows.Forms.TextBox();
            this.StepValue_TextBox = new System.Windows.Forms.TextBox();
            this.Parameters_Label = new System.Windows.Forms.Label();
            this.Parameters_TextBox = new System.Windows.Forms.TextBox();
            this.InnerPanel_Panel = new System.Windows.Forms.Panel();
            this.OuterPanel_Panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.InnerPanel_Panel.SuspendLayout();
            this.OuterPanel_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "MainArea";
            this.Chart.ChartAreas.Add(chartArea2);
            this.Chart.Location = new System.Drawing.Point(0, 0);
            this.Chart.Name = "Chart";
            series2.BorderWidth = 2;
            series2.ChartArea = "MainArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.IsVisibleInLegend = false;
            series2.Name = "XY_ExampleValues";
            this.Chart.Series.Add(series2);
            this.Chart.Size = new System.Drawing.Size(994, 445);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            this.Chart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Chart_MouseDown);
            this.Chart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart_MouseMove);
            this.Chart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Chart_MouseUp);
            // 
            // ExampleChart_Button
            // 
            this.ExampleChart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExampleChart_Button.Location = new System.Drawing.Point(890, 12);
            this.ExampleChart_Button.Name = "ExampleChart_Button";
            this.ExampleChart_Button.Size = new System.Drawing.Size(128, 43);
            this.ExampleChart_Button.TabIndex = 1;
            this.ExampleChart_Button.Text = "Тестовый график";
            this.ExampleChart_Button.UseVisualStyleBackColor = true;
            this.ExampleChart_Button.Click += new System.EventHandler(this.ExampleChart_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_Button.Location = new System.Drawing.Point(526, 12);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(92, 43);
            this.Clear_Button.TabIndex = 5;
            this.Clear_Button.Text = "Очистить все";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.ClearChartArea_Button_Click);
            // 
            // StartX_TextBox
            // 
            this.StartX_TextBox.Location = new System.Drawing.Point(50, 91);
            this.StartX_TextBox.Name = "StartX_TextBox";
            this.StartX_TextBox.Size = new System.Drawing.Size(92, 20);
            this.StartX_TextBox.TabIndex = 7;
            // 
            // StartX_Label
            // 
            this.StartX_Label.AutoSize = true;
            this.StartX_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartX_Label.Location = new System.Drawing.Point(19, 94);
            this.StartX_Label.Name = "StartX_Label";
            this.StartX_Label.Size = new System.Drawing.Size(25, 17);
            this.StartX_Label.TabIndex = 8;
            this.StartX_Label.Text = "X: ";
            // 
            // StartY_Label
            // 
            this.StartY_Label.AutoSize = true;
            this.StartY_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartY_Label.Location = new System.Drawing.Point(19, 120);
            this.StartY_Label.Name = "StartY_Label";
            this.StartY_Label.Size = new System.Drawing.Size(25, 17);
            this.StartY_Label.TabIndex = 9;
            this.StartY_Label.Text = "Y: ";
            // 
            // StartY_TextBox
            // 
            this.StartY_TextBox.Location = new System.Drawing.Point(50, 120);
            this.StartY_TextBox.Name = "StartY_TextBox";
            this.StartY_TextBox.Size = new System.Drawing.Size(92, 20);
            this.StartY_TextBox.TabIndex = 10;
            // 
            // ChooseChart_ComboBox
            // 
            this.ChooseChart_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseChart_ComboBox.FormattingEnabled = true;
            this.ChooseChart_ComboBox.Items.AddRange(new object[] {
            "Тестовый пример",
            "Электрический генератор с жестким возбуждением"});
            this.ChooseChart_ComboBox.Location = new System.Drawing.Point(20, 34);
            this.ChooseChart_ComboBox.Name = "ChooseChart_ComboBox";
            this.ChooseChart_ComboBox.Size = new System.Drawing.Size(152, 21);
            this.ChooseChart_ComboBox.TabIndex = 13;
            // 
            // ChooseChart_Label
            // 
            this.ChooseChart_Label.AutoSize = true;
            this.ChooseChart_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseChart_Label.Location = new System.Drawing.Point(17, 10);
            this.ChooseChart_Label.Name = "ChooseChart_Label";
            this.ChooseChart_Label.Size = new System.Drawing.Size(125, 17);
            this.ChooseChart_Label.TabIndex = 14;
            this.ChooseChart_Label.Text = "Выберите график";
            // 
            // ChooseMethod_ComboBox
            // 
            this.ChooseMethod_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseMethod_ComboBox.FormattingEnabled = true;
            this.ChooseMethod_ComboBox.Items.AddRange(new object[] {
            "Метод Эйлера",
            "Метод Рунге-Кутта"});
            this.ChooseMethod_ComboBox.Location = new System.Drawing.Point(196, 34);
            this.ChooseMethod_ComboBox.Name = "ChooseMethod_ComboBox";
            this.ChooseMethod_ComboBox.Size = new System.Drawing.Size(152, 21);
            this.ChooseMethod_ComboBox.TabIndex = 15;
            // 
            // ChooseMethod_Label
            // 
            this.ChooseMethod_Label.AutoSize = true;
            this.ChooseMethod_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseMethod_Label.Location = new System.Drawing.Point(198, 9);
            this.ChooseMethod_Label.Name = "ChooseMethod_Label";
            this.ChooseMethod_Label.Size = new System.Drawing.Size(118, 17);
            this.ChooseMethod_Label.TabIndex = 16;
            this.ChooseMethod_Label.Text = "Выберите метод";
            // 
            // StartPoint_Label
            // 
            this.StartPoint_Label.AutoSize = true;
            this.StartPoint_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartPoint_Label.Location = new System.Drawing.Point(19, 69);
            this.StartPoint_Label.Name = "StartPoint_Label";
            this.StartPoint_Label.Size = new System.Drawing.Size(123, 17);
            this.StartPoint_Label.TabIndex = 17;
            this.StartPoint_Label.Text = "Начальная точка";
            // 
            // Draw_Button
            // 
            this.Draw_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Draw_Button.Location = new System.Drawing.Point(376, 12);
            this.Draw_Button.Name = "Draw_Button";
            this.Draw_Button.Size = new System.Drawing.Size(121, 43);
            this.Draw_Button.TabIndex = 18;
            this.Draw_Button.Text = "Нарисовать график";
            this.Draw_Button.UseVisualStyleBackColor = true;
            this.Draw_Button.Click += new System.EventHandler(this.Draw_Button_Click);
            // 
            // StepValue_Label
            // 
            this.StepValue_Label.AutoSize = true;
            this.StepValue_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepValue_Label.Location = new System.Drawing.Point(193, 92);
            this.StepValue_Label.Name = "StepValue_Label";
            this.StepValue_Label.Size = new System.Drawing.Size(97, 17);
            this.StepValue_Label.TabIndex = 19;
            this.StepValue_Label.Text = "Размер шага:";
            // 
            // Iterations_Label
            // 
            this.Iterations_Label.AutoSize = true;
            this.Iterations_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Iterations_Label.Location = new System.Drawing.Point(193, 120);
            this.Iterations_Label.Name = "Iterations_Label";
            this.Iterations_Label.Size = new System.Drawing.Size(77, 17);
            this.Iterations_Label.TabIndex = 20;
            this.Iterations_Label.Text = "Итераций:";
            // 
            // Iterations_TextBox
            // 
            this.Iterations_TextBox.Location = new System.Drawing.Point(281, 120);
            this.Iterations_TextBox.Name = "Iterations_TextBox";
            this.Iterations_TextBox.Size = new System.Drawing.Size(67, 20);
            this.Iterations_TextBox.TabIndex = 21;
            // 
            // StepValue_TextBox
            // 
            this.StepValue_TextBox.Location = new System.Drawing.Point(292, 93);
            this.StepValue_TextBox.Name = "StepValue_TextBox";
            this.StepValue_TextBox.Size = new System.Drawing.Size(56, 20);
            this.StepValue_TextBox.TabIndex = 22;
            // 
            // Parameters_Label
            // 
            this.Parameters_Label.AutoSize = true;
            this.Parameters_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parameters_Label.Location = new System.Drawing.Point(373, 91);
            this.Parameters_Label.Name = "Parameters_Label";
            this.Parameters_Label.Size = new System.Drawing.Size(145, 17);
            this.Parameters_Label.TabIndex = 23;
            this.Parameters_Label.Text = "Параметры (через ;)";
            // 
            // Parameters_TextBox
            // 
            this.Parameters_TextBox.Location = new System.Drawing.Point(376, 120);
            this.Parameters_TextBox.Name = "Parameters_TextBox";
            this.Parameters_TextBox.Size = new System.Drawing.Size(142, 20);
            this.Parameters_TextBox.TabIndex = 24;
            // 
            // InnerPanel_Panel
            // 
            this.InnerPanel_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InnerPanel_Panel.Controls.Add(this.Chart);
            this.InnerPanel_Panel.Location = new System.Drawing.Point(25, 25);
            this.InnerPanel_Panel.Name = "InnerPanel_Panel";
            this.InnerPanel_Panel.Size = new System.Drawing.Size(994, 445);
            this.InnerPanel_Panel.TabIndex = 25;
            // 
            // OuterPanel_Panel
            // 
            this.OuterPanel_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OuterPanel_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OuterPanel_Panel.Controls.Add(this.InnerPanel_Panel);
            this.OuterPanel_Panel.Location = new System.Drawing.Point(12, 188);
            this.OuterPanel_Panel.Name = "OuterPanel_Panel";
            this.OuterPanel_Panel.Size = new System.Drawing.Size(1045, 494);
            this.OuterPanel_Panel.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 694);
            this.Controls.Add(this.OuterPanel_Panel);
            this.Controls.Add(this.Parameters_TextBox);
            this.Controls.Add(this.Parameters_Label);
            this.Controls.Add(this.StepValue_TextBox);
            this.Controls.Add(this.Iterations_TextBox);
            this.Controls.Add(this.Iterations_Label);
            this.Controls.Add(this.StepValue_Label);
            this.Controls.Add(this.Draw_Button);
            this.Controls.Add(this.StartY_TextBox);
            this.Controls.Add(this.StartX_Label);
            this.Controls.Add(this.StartY_Label);
            this.Controls.Add(this.StartPoint_Label);
            this.Controls.Add(this.StartX_TextBox);
            this.Controls.Add(this.ChooseMethod_Label);
            this.Controls.Add(this.ChooseMethod_ComboBox);
            this.Controls.Add(this.ChooseChart_Label);
            this.Controls.Add(this.ChooseChart_ComboBox);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.ExampleChart_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.InnerPanel_Panel.ResumeLayout(false);
            this.OuterPanel_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Button ExampleChart_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.TextBox StartX_TextBox;
        private System.Windows.Forms.Label StartX_Label;
        private System.Windows.Forms.Label StartY_Label;
        private System.Windows.Forms.TextBox StartY_TextBox;
        private System.Windows.Forms.ComboBox ChooseChart_ComboBox;
        private System.Windows.Forms.Label ChooseChart_Label;
        private System.Windows.Forms.ComboBox ChooseMethod_ComboBox;
        private System.Windows.Forms.Label ChooseMethod_Label;
        private System.Windows.Forms.Label StartPoint_Label;
        private System.Windows.Forms.Button Draw_Button;
        private System.Windows.Forms.Label StepValue_Label;
        private System.Windows.Forms.Label Iterations_Label;
        private System.Windows.Forms.TextBox Iterations_TextBox;
        private System.Windows.Forms.TextBox StepValue_TextBox;
        private System.Windows.Forms.Label Parameters_Label;
        private System.Windows.Forms.TextBox Parameters_TextBox;
        private System.Windows.Forms.Panel InnerPanel_Panel;
        private System.Windows.Forms.Panel OuterPanel_Panel;
    }
}

