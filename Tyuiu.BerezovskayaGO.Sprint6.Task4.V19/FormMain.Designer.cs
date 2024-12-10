using Tyuiu.BerezovskayaGO.Sprint6.Task4.V19.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task4.V19
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_SRR = new System.Windows.Forms.GroupBox();
            this.labelCondition_SRR = new System.Windows.Forms.Label();
            this.groupBoxOutput_SRR = new System.Windows.Forms.GroupBox();
            this.labelResult_SSR = new System.Windows.Forms.Label();
            this.textBoxResult_SRR = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SSR = new System.Windows.Forms.GroupBox();
            this.labelEndValue_SSR = new System.Windows.Forms.Label();
            this.labelStartValue_SSR = new System.Windows.Forms.Label();
            this.textBoxStopValue_SRR = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_SRR = new System.Windows.Forms.TextBox();
            this.buttonDone_SRR = new System.Windows.Forms.Button();
            this.buttonSave_SRR = new System.Windows.Forms.Button();
            this.chartGraph_SRR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonHelp_SRR = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxCondition_SRR.SuspendLayout();
            this.groupBoxOutput_SRR.SuspendLayout();
            this.groupBoxInput_SSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_SRR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SRR
            // 
            this.groupBoxCondition_SRR.Controls.Add(this.labelCondition_SRR);
            this.groupBoxCondition_SRR.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_SRR.Name = "groupBoxCondition_SRR";
            this.groupBoxCondition_SRR.Size = new System.Drawing.Size(200, 279);
            this.groupBoxCondition_SRR.TabIndex = 0;
            this.groupBoxCondition_SRR.TabStop = false;
            this.groupBoxCondition_SRR.Text = "Условие";
            // 
            // labelCondition_SRR
            // 
            this.labelCondition_SRR.AutoSize = true;
            this.labelCondition_SRR.Location = new System.Drawing.Point(7, 20);
            this.labelCondition_SRR.Name = "labelCondition_SRR";
            this.labelCondition_SRR.Size = new System.Drawing.Size(154, 78);
            this.labelCondition_SRR.TabIndex = 0;
            this.labelCondition_SRR.Text = "Написать программу,\r\nкоторая выводит\r\nтаблицу значений функции, \r\nотобразить это " +
    "на графике, \r\nсохранить в отдельный \r\ntxt файл при помощи кнопки.";
            // 
            // groupBoxOutput_SRR
            // 
            this.groupBoxOutput_SRR.Controls.Add(this.labelResult_SSR);
            this.groupBoxOutput_SRR.Controls.Add(this.textBoxResult_SRR);
            this.groupBoxOutput_SRR.Location = new System.Drawing.Point(219, 13);
            this.groupBoxOutput_SRR.Name = "groupBoxOutput_SRR";
            this.groupBoxOutput_SRR.Size = new System.Drawing.Size(200, 419);
            this.groupBoxOutput_SRR.TabIndex = 1;
            this.groupBoxOutput_SRR.TabStop = false;
            this.groupBoxOutput_SRR.Text = "Вывод данных";
            // 
            // labelResult_SSR
            // 
            this.labelResult_SSR.AutoSize = true;
            this.labelResult_SSR.Location = new System.Drawing.Point(6, 15);
            this.labelResult_SSR.Name = "labelResult_SSR";
            this.labelResult_SSR.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SSR.TabIndex = 1;
            this.labelResult_SSR.Text = "Результат:";
            // 
            // textBoxResult_SRR
            // 
            this.textBoxResult_SRR.Location = new System.Drawing.Point(6, 34);
            this.textBoxResult_SRR.Multiline = true;
            this.textBoxResult_SRR.Name = "textBoxResult_SRR";
            this.textBoxResult_SRR.Size = new System.Drawing.Size(188, 379);
            this.textBoxResult_SRR.TabIndex = 0;
            // 
            // groupBoxInput_SSR
            // 
            this.groupBoxInput_SSR.Controls.Add(this.labelEndValue_SSR);
            this.groupBoxInput_SSR.Controls.Add(this.labelStartValue_SSR);
            this.groupBoxInput_SSR.Controls.Add(this.textBoxStopValue_SRR);
            this.groupBoxInput_SSR.Controls.Add(this.textBoxStartValue_SRR);
            this.groupBoxInput_SSR.Location = new System.Drawing.Point(13, 356);
            this.groupBoxInput_SSR.Name = "groupBoxInput_SSR";
            this.groupBoxInput_SSR.Size = new System.Drawing.Size(206, 76);
            this.groupBoxInput_SSR.TabIndex = 2;
            this.groupBoxInput_SSR.TabStop = false;
            this.groupBoxInput_SSR.Text = "Ввод данных";
            // 
            // labelEndValue_SSR
            // 
            this.labelEndValue_SSR.AutoSize = true;
            this.labelEndValue_SSR.Location = new System.Drawing.Point(105, 26);
            this.labelEndValue_SSR.Name = "labelEndValue_SSR";
            this.labelEndValue_SSR.Size = new System.Drawing.Size(66, 13);
            this.labelEndValue_SSR.TabIndex = 3;
            this.labelEndValue_SSR.Text = "Конец шага";
            // 
            // labelStartValue_SSR
            // 
            this.labelStartValue_SSR.AutoSize = true;
            this.labelStartValue_SSR.Location = new System.Drawing.Point(7, 26);
            this.labelStartValue_SSR.Name = "labelStartValue_SSR";
            this.labelStartValue_SSR.Size = new System.Drawing.Size(72, 13);
            this.labelStartValue_SSR.TabIndex = 2;
            this.labelStartValue_SSR.Text = "Начало шага";
            // 
            // textBoxStopValue_SRR
            // 
            this.textBoxStopValue_SRR.Location = new System.Drawing.Point(108, 45);
            this.textBoxStopValue_SRR.Name = "textBoxStopValue_SRR";
            this.textBoxStopValue_SRR.Size = new System.Drawing.Size(92, 20);
            this.textBoxStopValue_SRR.TabIndex = 1;
            // 
            // textBoxStartValue_SRR
            // 
            this.textBoxStartValue_SRR.Location = new System.Drawing.Point(6, 45);
            this.textBoxStartValue_SRR.Name = "textBoxStartValue_SRR";
            this.textBoxStartValue_SRR.Size = new System.Drawing.Size(91, 20);
            this.textBoxStartValue_SRR.TabIndex = 0;
            // 
            // buttonDone_SRR
            // 
            this.buttonDone_SRR.Location = new System.Drawing.Point(19, 327);
            this.buttonDone_SRR.Name = "buttonDone_SRR";
            this.buttonDone_SRR.Size = new System.Drawing.Size(91, 23);
            this.buttonDone_SRR.TabIndex = 3;
            this.buttonDone_SRR.Text = "Выполнить";
            this.buttonDone_SRR.UseVisualStyleBackColor = true;
            this.buttonDone_SRR.Click += new System.EventHandler(this.buttonDone_SSR_Click);
            // 
            // buttonSave_SRR
            // 
            this.buttonSave_SRR.Location = new System.Drawing.Point(121, 327);
            this.buttonSave_SRR.Name = "buttonSave_SRR";
            this.buttonSave_SRR.Size = new System.Drawing.Size(92, 23);
            this.buttonSave_SRR.TabIndex = 4;
            this.buttonSave_SRR.Text = "Сохранить";
            this.buttonSave_SRR.UseVisualStyleBackColor = true;
            this.buttonSave_SRR.Click += new System.EventHandler(this.buttonSave_SRR_Click);
            // 
            // chartGraph_SRR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraph_SRR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraph_SRR.Legends.Add(legend1);
            this.chartGraph_SRR.Location = new System.Drawing.Point(425, 13);
            this.chartGraph_SRR.Name = "chartGraph_SRR";
            this.chartGraph_SRR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraph_SRR.Series.Add(series1);
            this.chartGraph_SRR.Size = new System.Drawing.Size(363, 413);
            this.chartGraph_SRR.TabIndex = 5;
            this.chartGraph_SRR.Text = "chartGraph_SRR";
            // 
            // buttonHelp_SRR
            // 
            this.buttonHelp_SRR.Location = new System.Drawing.Point(19, 298);
            this.buttonHelp_SRR.Name = "buttonHelp_SRR";
            this.buttonHelp_SRR.Size = new System.Drawing.Size(194, 23);
            this.buttonHelp_SRR.TabIndex = 6;
            this.buttonHelp_SRR.Text = "?";
            this.buttonHelp_SRR.UseVisualStyleBackColor = true;
            this.buttonHelp_SRR.Click += new System.EventHandler(this.buttonHelp_SRR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_SRR);
            this.Controls.Add(this.chartGraph_SRR);
            this.Controls.Add(this.buttonSave_SRR);
            this.Controls.Add(this.buttonDone_SRR);
            this.Controls.Add(this.groupBoxInput_SSR);
            this.Controls.Add(this.groupBoxOutput_SRR);
            this.Controls.Add(this.groupBoxCondition_SRR);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 19 | Березовская Г. О.";
            this.groupBoxCondition_SRR.ResumeLayout(false);
            this.groupBoxCondition_SRR.PerformLayout();
            this.groupBoxOutput_SRR.ResumeLayout(false);
            this.groupBoxOutput_SRR.PerformLayout();
            this.groupBoxInput_SSR.ResumeLayout(false);
            this.groupBoxInput_SSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_SRR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SRR;
        private System.Windows.Forms.GroupBox groupBoxOutput_SRR;
        private System.Windows.Forms.GroupBox groupBoxInput_SSR;
        private System.Windows.Forms.Label labelResult_SSR;
        private System.Windows.Forms.TextBox textBoxResult_SRR;
        private System.Windows.Forms.TextBox textBoxStopValue_SRR;
        private System.Windows.Forms.TextBox textBoxStartValue_SRR;
        private System.Windows.Forms.Label labelEndValue_SSR;
        private System.Windows.Forms.Label labelStartValue_SSR;
        private System.Windows.Forms.Button buttonDone_SRR;
        private System.Windows.Forms.Button buttonSave_SRR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_SRR;
        private System.Windows.Forms.Label labelCondition_SRR;
        private System.Windows.Forms.Button buttonHelp_SRR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
