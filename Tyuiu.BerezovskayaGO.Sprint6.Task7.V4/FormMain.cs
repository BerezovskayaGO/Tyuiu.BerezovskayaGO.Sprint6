using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.BerezovskayaGO.Sprint6.Task7.V4.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task7.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void groupBoxTask_BKV_Enter(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_BKV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BKV.ShowDialog();
            openFilePath = openFileDialogTask_BKV.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_BKV.ColumnCount = columns;
            dataGridViewInput_BKV.RowCount = rows;
            dataGridViewOutPut_BKV.RowCount = rows;
            dataGridViewOutPut_BKV.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_BKV.Columns[i].Width = 25;
                dataGridViewOutPut_BKV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_BKV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonResult_BKV.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_BKV.ColumnCount = 50;
            dataGridViewOutPut_BKV.ColumnCount = 50;

            dataGridViewInput_BKV.RowCount = 50;
            dataGridViewOutPut_BKV.RowCount = 50;
        }

        private void buttonHelp_KVB_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonResult_BKV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_BKV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_BKV.Enabled = true;
        }

        private void buttonSave_BKV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_BKV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_BKV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_BKV.ShowDialog();

            string path = saveFileDialogMatrix_BKV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_BKV.RowCount;
            int columns = dataGridViewOutPut_BKV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_BKV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_BKV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";

            }


        }
        private void buttonOpenFile_BKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }
        private void buttonResult_BKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }
        private void buttonSave_BKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сноу в дому";
        }
        private void buttonHelp_BKV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }
    }
}
