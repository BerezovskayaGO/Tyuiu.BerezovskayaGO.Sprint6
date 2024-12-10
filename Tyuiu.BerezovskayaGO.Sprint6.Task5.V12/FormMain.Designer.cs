using Tyuiu.BerezovskayaGO.Sprint6.Task5.V12.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task5.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1_BDR = new System.Windows.Forms.Panel();
            this.panel2_BDR = new System.Windows.Forms.Panel();
            this.panel3_BDR = new System.Windows.Forms.Panel();
            this.groupBoxDataOutPut_BDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_BDR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition_BDR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BDR = new System.Windows.Forms.TextBox();
            this.buttonDone_BDR = new System.Windows.Forms.Button();
            this.buttonOpenFile_BDR = new System.Windows.Forms.Button();
            this.buttonInfo_BDR = new System.Windows.Forms.Button();
            this.chartDiag_BDR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1_BDR.SuspendLayout();
            this.panel2_BDR.SuspendLayout();
            this.panel3_BDR.SuspendLayout();
            this.groupBoxDataOutPut_BDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BDR)).BeginInit();
            this.groupBoxCondition_BDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_BDR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_BDR
            // 
            this.panel1_BDR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1_BDR.Controls.Add(this.buttonInfo_BDR);
            this.panel1_BDR.Controls.Add(this.buttonOpenFile_BDR);
            this.panel1_BDR.Controls.Add(this.buttonDone_BDR);
            this.panel1_BDR.Controls.Add(this.groupBoxCondition_BDR);
            this.panel1_BDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_BDR.Location = new System.Drawing.Point(0, 0);
            this.panel1_BDR.Name = "panel1_BDR";
            this.panel1_BDR.Size = new System.Drawing.Size(1101, 100);
            this.panel1_BDR.TabIndex = 0;
            // 
            // panel2_BDR
            // 
            this.panel2_BDR.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2_BDR.Controls.Add(this.groupBoxDataOutPut_BDR);
            this.panel2_BDR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2_BDR.Location = new System.Drawing.Point(0, 100);
            this.panel2_BDR.Name = "panel2_BDR";
            this.panel2_BDR.Size = new System.Drawing.Size(200, 493);
            this.panel2_BDR.TabIndex = 1;
            // 
            // panel3_BDR
            // 
            this.panel3_BDR.BackColor = System.Drawing.Color.Lime;
            this.panel3_BDR.Controls.Add(this.chartDiag_BDR);
            this.panel3_BDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3_BDR.Location = new System.Drawing.Point(200, 100);
            this.panel3_BDR.Name = "panel3_BDR";
            this.panel3_BDR.Size = new System.Drawing.Size(901, 493);
            this.panel3_BDR.TabIndex = 2;
            // 
            // groupBoxDataOutPut_BDR
            // 
            this.groupBoxDataOutPut_BDR.Controls.Add(this.dataGridViewResult_BDR);
            this.groupBoxDataOutPut_BDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataOutPut_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDataOutPut_BDR.ForeColor = System.Drawing.Color.Black;
            this.groupBoxDataOutPut_BDR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataOutPut_BDR.Name = "groupBoxDataOutPut_BDR";
            this.groupBoxDataOutPut_BDR.Size = new System.Drawing.Size(200, 493);
            this.groupBoxDataOutPut_BDR.TabIndex = 0;
            this.groupBoxDataOutPut_BDR.TabStop = false;
            this.groupBoxDataOutPut_BDR.Text = "Вывод данных:";
            // 
            // dataGridViewResult_BDR
            // 
            this.dataGridViewResult_BDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_BDR.ColumnHeadersVisible = false;
            this.dataGridViewResult_BDR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewResult_BDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_BDR.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewResult_BDR.Name = "dataGridViewResult_BDR";
            this.dataGridViewResult_BDR.ReadOnly = true;
            this.dataGridViewResult_BDR.RowHeadersVisible = false;
            this.dataGridViewResult_BDR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_BDR.Size = new System.Drawing.Size(194, 471);
            this.dataGridViewResult_BDR.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // groupBoxCondition_BDR
            // 
            this.groupBoxCondition_BDR.Controls.Add(this.textBoxTask_BDR);
            this.groupBoxCondition_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_BDR.Location = new System.Drawing.Point(4, 4);
            this.groupBoxCondition_BDR.Name = "groupBoxCondition_BDR";
            this.groupBoxCondition_BDR.Size = new System.Drawing.Size(662, 90);
            this.groupBoxCondition_BDR.TabIndex = 0;
            this.groupBoxCondition_BDR.TabStop = false;
            this.groupBoxCondition_BDR.Text = "Условие:";
            // 
            // textBoxTask_BDR
            // 
            this.textBoxTask_BDR.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTask_BDR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_BDR.Location = new System.Drawing.Point(3, 19);
            this.textBoxTask_BDR.Multiline = true;
            this.textBoxTask_BDR.Name = "textBoxTask_BDR";
            this.textBoxTask_BDR.ReadOnly = true;
            this.textBoxTask_BDR.Size = new System.Drawing.Size(656, 68);
            this.textBoxTask_BDR.TabIndex = 0;
            this.textBoxTask_BDR.TabStop = false;
            this.textBoxTask_BDR.Text = "Прочитать данные из файла InPutFileTask5V12.txt. Вывести в DataGridView\r\nвсе числ" +
    "а не кратные 5 и построить диаграмму по этим значениям.";
            // 
            // buttonDone_BDR
            // 
            this.buttonDone_BDR.BackColor = System.Drawing.Color.Green;
            this.buttonDone_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_BDR.Location = new System.Drawing.Point(722, 12);
            this.buttonDone_BDR.Name = "buttonDone_BDR";
            this.buttonDone_BDR.Size = new System.Drawing.Size(93, 78);
            this.buttonDone_BDR.TabIndex = 1;
            this.buttonDone_BDR.Text = "Выполнить";
            this.buttonDone_BDR.UseVisualStyleBackColor = false;
            this.buttonDone_BDR.Click += new System.EventHandler(this.buttonDone_BDR_Click);
            this.buttonDone_BDR.MouseLeave += new System.EventHandler(this.buttonDone_BDR_MouseLeave);
            this.buttonDone_BDR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDone_BDR_MouseMove);
            // 
            // buttonOpenFile_BDR
            // 
            this.buttonOpenFile_BDR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpenFile_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile_BDR.Location = new System.Drawing.Point(834, 12);
            this.buttonOpenFile_BDR.Name = "buttonOpenFile_BDR";
            this.buttonOpenFile_BDR.Size = new System.Drawing.Size(93, 78);
            this.buttonOpenFile_BDR.TabIndex = 1;
            this.buttonOpenFile_BDR.Text = "Открыть файл";
            this.buttonOpenFile_BDR.UseVisualStyleBackColor = false;
            this.buttonOpenFile_BDR.Click += new System.EventHandler(this.buttonOpenFile_BDR_Click);
            this.buttonOpenFile_BDR.MouseLeave += new System.EventHandler(this.buttonOpenFile_BDR_MouseLeave);
            this.buttonOpenFile_BDR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonOpenFile_BDR_MouseMove);
            // 
            // buttonInfo_BDR
            // 
            this.buttonInfo_BDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_BDR.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonInfo_BDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_BDR.ForeColor = System.Drawing.Color.White;
            this.buttonInfo_BDR.Location = new System.Drawing.Point(947, 12);
            this.buttonInfo_BDR.Name = "buttonInfo_BDR";
            this.buttonInfo_BDR.Size = new System.Drawing.Size(93, 78);
            this.buttonInfo_BDR.TabIndex = 1;
            this.buttonInfo_BDR.Text = "Справка";
            this.buttonInfo_BDR.UseVisualStyleBackColor = false;
            this.buttonInfo_BDR.Click += new System.EventHandler(this.buttonInfo_BDR_Click);
            this.buttonInfo_BDR.MouseLeave += new System.EventHandler(this.buttonInfo_BDR_MouseLeave);
            this.buttonInfo_BDR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonInfo_BDR_MouseMove);
            // 
            // chartDiag_BDR
            // 
            chartArea10.Name = "ChartArea1";
            this.chartDiag_BDR.ChartAreas.Add(chartArea10);
            this.chartDiag_BDR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.chartDiag_BDR.Legends.Add(legend10);
            this.chartDiag_BDR.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_BDR.Name = "chartDiag_BDR";
            this.chartDiag_BDR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series10.ChartArea = "ChartArea1";
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartDiag_BDR.Series.Add(series10);
            this.chartDiag_BDR.Size = new System.Drawing.Size(901, 493);
            this.chartDiag_BDR.TabIndex = 0;
            this.chartDiag_BDR.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 593);
            this.Controls.Add(this.panel3_BDR);
            this.Controls.Add(this.panel2_BDR);
            this.Controls.Add(this.panel1_BDR);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 12 | Березовская Г. О.";
            this.panel1_BDR.ResumeLayout(false);
            this.panel2_BDR.ResumeLayout(false);
            this.panel3_BDR.ResumeLayout(false);
            this.groupBoxDataOutPut_BDR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BDR)).EndInit();
            this.groupBoxCondition_BDR.ResumeLayout(false);
            this.groupBoxCondition_BDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_BDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_BDR;
        private System.Windows.Forms.Button buttonInfo_BDR;
        private System.Windows.Forms.Button buttonOpenFile_BDR;
        private System.Windows.Forms.Button buttonDone_BDR;
        private System.Windows.Forms.GroupBox groupBoxCondition_BDR;
        private System.Windows.Forms.TextBox textBoxTask_BDR;
        private System.Windows.Forms.Panel panel2_BDR;
        private System.Windows.Forms.GroupBox groupBoxDataOutPut_BDR;
        private System.Windows.Forms.DataGridView dataGridViewResult_BDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel3_BDR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_BDR;
    }
}
