using Tyuiu.BerezovskayaGO.Sprint6.Task7.V4.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task7.V4
{
    partial class FormAbout
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            buttonOK_BKV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_2024_12_11_00_49_09;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(262, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 208);
            textBox1.TabIndex = 1;
            textBox1.Text = "Разработчик Бабай К.В.\r\nгруппа СМАРТб-24-1\r\n\r\nПрограмма написана на языке С#\r\nТюменский Индустриальный Университет 2024\r\nВысшая школа цифровых технологи 2024\r\nВнутреннее имя Tyuiu.Sprint6.Task6.V15";
            // 
            // buttonOK_BKV
            // 
            buttonOK_BKV.BackColor = Color.DarkGray;
            buttonOK_BKV.Location = new Point(422, 237);
            buttonOK_BKV.Name = "buttonOK_BKV";
            buttonOK_BKV.Size = new Size(148, 45);
            buttonOK_BKV.TabIndex = 2;
            buttonOK_BKV.Text = "OK";
            buttonOK_BKV.UseVisualStyleBackColor = false;
            buttonOK_BKV.Click += buttonOK_BKV_Click;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 294);
            Controls.Add(buttonOK_BKV);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button buttonOK_BKV;
    }
}
