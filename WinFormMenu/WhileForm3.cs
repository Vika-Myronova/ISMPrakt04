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
    public partial class WhileForm3 : Form
    {
        public WhileForm3()
        {
            InitializeComponent();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            double l = 10, sum = 10;
            int p;
            int day = 1;
            bool isok;
            isok = int.TryParse(textBoxP.Text, out p);
            if (isok == false)
            {
                MessageBox.Show("Некоректно введенне значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (sum < 200)
                {
                    MyCyclesLibrary.Cycles.While3(ref p, ref day, l, ref sum);
                }
                labelResult.Text = $"{day}";
                labelResult2.Text = $"{sum:F2}";
                labelSum.Visible = true;
                labelResult.Visible = true;
                labelDay.Visible = true;
                labelResult2.Visible = true;

            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
