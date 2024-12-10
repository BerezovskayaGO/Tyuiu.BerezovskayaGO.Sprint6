using Tyuiu.BerezovskayaGO.Sprint6.Task5.V12.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task5.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V12.txt";
        private void buttonDone_BDR_Click(object sender, EventArgs e)
        {
            dataGridViewResult_BDR.ColumnCount = 2;
            dataGridViewResult_BDR.Columns[0].Width = 25;
            dataGridViewResult_BDR.Columns[1].Width = 50;

            this.chartDiag_BDR.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_BDR.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_BDR.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_BDR.Rows.Add(i.ToString(), numsMass[i].ToString());
                chartDiag_BDR.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_BDR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_BDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы АСОиУб-24-1 Березовская Галина Олеговна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_BDR_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }

        private void buttonDone_BDR_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            base.OnMouseLeave(e);
        }

        private void buttonOpenFile_BDR_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }

        private void buttonOpenFile_BDR_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            base.OnMouseLeave(e);
        }

        private void buttonInfo_BDR_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }

        private void buttonInfo_BDR_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            base.OnMouseLeave(e);
        }
    }
}
