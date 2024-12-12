using Tyuiu.BerezovskayaGO.Sprint6.Task7.V4.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task7.V4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            buttonSave_BKV = new Button();
            buttonHelp_KVB = new Button();
            buttonResult_BKV = new Button();
            buttonOpenFile_BKV = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBoxTask_BKV = new GroupBox();
            textBoxTask_BKV = new TextBox();
            panel4 = new Panel();
            groupBoxInput_BKV = new GroupBox();
            dataGridViewInput_BKV = new DataGridView();
            panel5 = new Panel();
            groupBoxOutput_BKV = new GroupBox();
            dataGridViewOutPut_BKV = new DataGridView();
            splitter1 = new Splitter();
            openFileDialogTask_BKV = new OpenFileDialog();
            saveFileDialogMatrix_BKV = new SaveFileDialog();
            toolTipButton = new ToolTip(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxTask_BKV.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxInput_BKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_BKV).BeginInit();
            panel5.SuspendLayout();
            groupBoxOutput_BKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_BKV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave_BKV);
            panel1.Controls.Add(buttonHelp_KVB);
            panel1.Controls.Add(buttonResult_BKV);
            panel1.Controls.Add(buttonOpenFile_BKV);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 226);
            panel1.TabIndex = 0;
            // 
            // buttonSave_BKV
            // 
            buttonSave_BKV.Enabled = false;
            buttonSave_BKV.Image = Properties.Resources.accept;
            buttonSave_BKV.Location = new Point(236, 12);
            buttonSave_BKV.Name = "buttonSave_BKV";
            buttonSave_BKV.Size = new Size(96, 73);
            buttonSave_BKV.TabIndex = 5;
            toolTipButton.SetToolTip(buttonSave_BKV, "Сохранить  файл");
            buttonSave_BKV.UseVisualStyleBackColor = true;
            buttonSave_BKV.Click += buttonSave_BKV_Click;
            // 
            // buttonHelp_KVB
            // 
            buttonHelp_KVB.Image = Properties.Resources.help;
            buttonHelp_KVB.Location = new Point(696, 12);
            buttonHelp_KVB.Name = "buttonHelp_KVB";
            buttonHelp_KVB.Size = new Size(92, 75);
            buttonHelp_KVB.TabIndex = 4;
            toolTipButton.SetToolTip(buttonHelp_KVB, "Информация о создателе");
            buttonHelp_KVB.UseVisualStyleBackColor = true;
            buttonHelp_KVB.Click += buttonHelp_KVB_Click;
            // 
            // buttonResult_BKV
            // 
            buttonResult_BKV.Enabled = false;
            buttonResult_BKV.Image = Properties.Resources.page_white_put;
            buttonResult_BKV.Location = new Point(128, 12);
            buttonResult_BKV.Name = "buttonResult_BKV";
            buttonResult_BKV.Size = new Size(90, 74);
            buttonResult_BKV.TabIndex = 3;
            toolTipButton.SetToolTip(buttonResult_BKV, "Совершить действие найд файлом\r\n");
            buttonResult_BKV.UseVisualStyleBackColor = true;
            buttonResult_BKV.Click += buttonResult_BKV_Click;
            // 
            // buttonOpenFile_BKV
            // 
            buttonOpenFile_BKV.Image = Properties.Resources.folder_explore;
            buttonOpenFile_BKV.Location = new Point(12, 12);
            buttonOpenFile_BKV.Name = "buttonOpenFile_BKV";
            buttonOpenFile_BKV.Size = new Size(94, 74);
            buttonOpenFile_BKV.TabIndex = 2;
            toolTipButton.SetToolTip(buttonOpenFile_BKV, "Вставьте необходимый файл\r\n");
            buttonOpenFile_BKV.UseVisualStyleBackColor = true;
            buttonOpenFile_BKV.Click += buttonOpenFile_BKV_Click;
            buttonOpenFile_BKV.MouseEnter += buttonOpenFile_BKV_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 100);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxTask_BKV);
            panel3.Location = new Point(0, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 123);
            panel3.TabIndex = 1;
            // 
            // groupBoxTask_BKV
            // 
            groupBoxTask_BKV.BackColor = SystemColors.Menu;
            groupBoxTask_BKV.Controls.Add(textBoxTask_BKV);
            groupBoxTask_BKV.Location = new Point(12, 11);
            groupBoxTask_BKV.Name = "groupBoxTask_BKV";
            groupBoxTask_BKV.Size = new Size(776, 106);
            groupBoxTask_BKV.TabIndex = 0;
            groupBoxTask_BKV.TabStop = false;
            groupBoxTask_BKV.Text = "Условие";
            groupBoxTask_BKV.Enter += groupBoxTask_BKV_Enter;
            // 
            // textBoxTask_BKV
            // 
            textBoxTask_BKV.BackColor = SystemColors.MenuBar;
            textBoxTask_BKV.Location = new Point(6, 22);
            textBoxTask_BKV.Multiline = true;
            textBoxTask_BKV.Name = "textBoxTask_BKV";
            textBoxTask_BKV.Size = new Size(764, 78);
            textBoxTask_BKV.TabIndex = 0;
            textBoxTask_BKV.Text = "Дан файл InPutFileTask7V4.csv в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить во второй строке числа кратные 4 на 4.";
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxInput_BKV);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 226);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 321);
            panel4.TabIndex = 2;
            // 
            // groupBoxInput_BKV
            // 
            groupBoxInput_BKV.Controls.Add(dataGridViewInput_BKV);
            groupBoxInput_BKV.Location = new Point(12, 6);
            groupBoxInput_BKV.Name = "groupBoxInput_BKV";
            groupBoxInput_BKV.Size = new Size(352, 312);
            groupBoxInput_BKV.TabIndex = 0;
            groupBoxInput_BKV.TabStop = false;
            groupBoxInput_BKV.Text = "Ввод";
            // 
            // dataGridViewInput_BKV
            // 
            dataGridViewInput_BKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_BKV.Location = new Point(6, 22);
            dataGridViewInput_BKV.Name = "dataGridViewInput_BKV";
            dataGridViewInput_BKV.Size = new Size(340, 281);
            dataGridViewInput_BKV.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBoxOutput_BKV);
            panel5.Controls.Add(splitter1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(370, 226);
            panel5.Name = "panel5";
            panel5.Size = new Size(430, 321);
            panel5.TabIndex = 3;
            // 
            // groupBoxOutput_BKV
            // 
            groupBoxOutput_BKV.Controls.Add(dataGridViewOutPut_BKV);
            groupBoxOutput_BKV.Location = new Point(11, 6);
            groupBoxOutput_BKV.Name = "groupBoxOutput_BKV";
            groupBoxOutput_BKV.Size = new Size(416, 312);
            groupBoxOutput_BKV.TabIndex = 1;
            groupBoxOutput_BKV.TabStop = false;
            groupBoxOutput_BKV.Text = "Вывод";
            // 
            // dataGridViewOutPut_BKV
            // 
            dataGridViewOutPut_BKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_BKV.Location = new Point(10, 24);
            dataGridViewOutPut_BKV.Name = "dataGridViewOutPut_BKV";
            dataGridViewOutPut_BKV.Size = new Size(397, 279);
            dataGridViewOutPut_BKV.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 321);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_BKV
            // 
            openFileDialogTask_BKV.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6| Таск 7| Вариант 4| Березовская Г. О.";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBoxTask_BKV.ResumeLayout(false);
            groupBoxTask_BKV.PerformLayout();
            panel4.ResumeLayout(false);
            groupBoxInput_BKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_BKV).EndInit();
            panel5.ResumeLayout(false);
            groupBoxOutput_BKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_BKV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button buttonHelp_KVB;
        private Button buttonResult_BKV;
        private Button buttonOpenFile_BKV;
        private GroupBox groupBoxTask_BKV;
        private Splitter splitter1;
        private TextBox textBoxTask_BKV;
        private GroupBox groupBoxInput_BKV;
        private GroupBox groupBoxOutput_BKV;
        private DataGridView dataGridViewInput_BKV;
        private DataGridView dataGridViewOutPut_BKV;
        private OpenFileDialog openFileDialogTask_BKV;
        private Button buttonSave_BKV;
        private SaveFileDialog saveFileDialogMatrix_BKV;
        private ToolTip toolTipButton;
    }
}