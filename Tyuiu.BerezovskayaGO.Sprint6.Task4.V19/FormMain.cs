using Tyuiu.BerezovskayaGO.Sprint6.Task4.V19.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task4.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_SSR_Click(object sender, EventArgs e)
        {
            int startStep = Convert.ToInt32(textBoxStartValue_SRR.Text);
            int stopStep = Convert.ToInt32(textBoxStopValue_SRR.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            this.chartGraph_SRR.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGraph_SRR.ChartAreas[0].AxisY.Title = "Ось Y";

            textBoxResult_SRR.Text = "";

            for (int i = 0; i < len; i++)
            {
                textBoxResult_SRR.AppendText(valueArray[i] + Environment.NewLine);

                this.chartGraph_SRR.Series[0].Points.AddXY(startStep, valueArray[i]);

                startStep++;
            }
        }

        private void buttonSave_SRR_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
            File.WriteAllText(path, textBoxResult_SRR.Text);

            DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }

        }

        private void buttonHelp_SRR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы АСОиУб-24-1 Березовская Галина Олеговна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
