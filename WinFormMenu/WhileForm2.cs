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
    public partial class WhileForm2 : Form
    {
        public WhileForm2()
        {
            InitializeComponent();
        }

        private void labelK_Click(object sender, EventArgs e)
        {

        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            int k;
            int n;
            bool isok;
            isok = int.TryParse(textBoxN.Text, out n);
            if (isok == false || n < 1)
            {
                MessageBox.Show("Некоректно введенне значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                k = MyCyclesLibrary.Cycles.While2(n);
                labelResult.Text = k.ToString();
                labelK.Visible = true;
                labelResult.Visible = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
