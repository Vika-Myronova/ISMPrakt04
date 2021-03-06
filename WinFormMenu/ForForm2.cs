using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMenu
{
    public partial class ForForm2 : Form
    {
        public ForForm2()
        {
            InitializeComponent();
        }

        private void buttonSolveFor2_Click(object sender, EventArgs e)
        {
            double summa = 0;
            int n;
            bool isok;
            isok = int.TryParse(textBoxN.Text, out n);
            if (isok == false || n < 0)
            {
                MessageBox.Show("Некоректно введенне значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                summa = MyCyclesLibrary.Cycles.For2(n);
                labelResult.Text = summa.ToString();
                labelSum.Visible = true;
                labelResult.Visible = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
