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
    public partial class ForForm4 : Form
    {
        public ForForm4()
        {
            InitializeComponent();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            bool isok, isOk;
            isok = int.TryParse(textBoxA.Text, out a);
            isOk = int.TryParse(textBoxB.Text, out b);
            if (isOk == false || isok == false || a > b)
            {
                MessageBox.Show("Некоректно введенне значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int summ = MyCyclesLibrary.Cycles.For4(a, b);
                labelResult.Text = summ.ToString();
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
