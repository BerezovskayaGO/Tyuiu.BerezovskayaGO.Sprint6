using Tyuiu.BerezovskayaGO.Sprint6.Task3.V19.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] matrix = { { 4, 32, -20, 27, 21 },
                          { 17, 15, -1, -2, -1 },
                          { -3, 18, 12, -10, 29 },
                          { 7, -15, 2, -8, 12 },
                          { -10, 25, 5, 27, 21 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_SHVN.ColumnCount = columns;
            dataGridViewMatrix_SHVN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SHVN.Columns[i].Width = 40;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SHVN.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMatrix_SHVN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDoneClick_SHVN_Click(object sender, EventArgs e)
        {
            int[,] matrixres = ds.Calculate(matrix);

            int rows = matrixres.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_SHVN.ColumnCount = columns;
            dataGridViewMatrix_SHVN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SHVN.Columns[i].Width = 40;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SHVN.Rows[i].Cells[j].Value = Convert.ToString(matrixres[i, j]);
                }
            }
        }

        private void buttonHelp_SHVN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 3 ��������� ��������� ������ ������-24-1 ����������� ������ ��������.", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
