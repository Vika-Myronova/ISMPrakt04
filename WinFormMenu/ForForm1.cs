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
    public partial class ForForm1 : Form
    {
        public ForForm1()
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
                int dob = MyCyclesLibrary.Cycles.For1(a, b);
                labelResult.Text = dob.ToString();
                labelDob.Visible = true;
                labelResult.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
