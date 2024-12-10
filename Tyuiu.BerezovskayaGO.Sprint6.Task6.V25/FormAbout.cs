using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.BerezovskayaGO.Sprint6.Task6.V25.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint6.Task6.V25
{
    public partial class FormAbout : System.Windows.Forms.Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
