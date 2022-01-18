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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWhile3_Click(object sender, EventArgs e)
        {
            WhileForm3 form = new WhileForm3();
            form.ShowDialog();
        }

        private void buttonFor1_Click(object sender, EventArgs e)
        {
            ForForm1 form = new ForForm1();
            form.ShowDialog();
        }

        private void buttonFor2_Click(object sender, EventArgs e)
        {
            ForForm2 form = new ForForm2();
            form.ShowDialog();
        }

        private void buttonFor3_Click(object sender, EventArgs e)
        {
            ForForm3 form = new ForForm3();
            form.ShowDialog();
        }

        private void buttonFor4_Click(object sender, EventArgs e)
        {
            ForForm4 form = new ForForm4();
            form.ShowDialog();
        }

        private void buttonFor5_Click(object sender, EventArgs e)
        {
            ForForm5 form = new ForForm5();
            form.ShowDialog();
        }

        private void buttonWhile1_Click(object sender, EventArgs e)
        {
            WhileForm1 form = new WhileForm1();
            form.ShowDialog();
        }

        private void buttonWhile2_Click(object sender, EventArgs e)
        {
            WhileForm2 form = new WhileForm2();
            form.ShowDialog();
        }
    }
}
