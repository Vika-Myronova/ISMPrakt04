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
    public partial class ForForm3 : Form
    {
        public ForForm3()
        {
            InitializeComponent();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            double a;
            int n;
            bool isok, isOk;
            isok = double.TryParse(textBoxA.Text, out a);
            isOk = int.TryParse(textBoxN.Text, out n);
            if (isOk == false || isok == false || n < 0)
            {
                MessageBox.Show("Некоректно введенне значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double pow = MyCyclesLibrary.Cycles.For3(a, n);
                labelResult.Text = pow.ToString();
                labelPow.Visible = true;
                labelResult.Visible = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
