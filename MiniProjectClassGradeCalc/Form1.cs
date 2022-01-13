using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectClassGradeCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name;
            Decimal grade1;
            Decimal grade2;
            Decimal grade3;
            Decimal total;
            Decimal average;
            string grade;

            try
            {
                total = 0;
                average = 0;
                name = txt_name.Text;
                grade1 = NUD_G1.Value;
                grade2 = NUD_G2.Value;
                grade3 = NUD_G3.Value;
                total = grade1 + grade2 + grade3;
                average = total / 3;
                string LisItem;

                if (average < 40)
                {
                    grade = "fail";
                }
                else if (average < 55)
                {
                    grade = "Pass";
                }
                else if (average < 70)
                {
                    grade = "Merit";
                }
                else
                {
                    grade = "Distinction";
                }
                LisItem = "Name = " + name + ", Mark = " + average.ToString() + ", Grade = " + grade;
                LSTresults.Items.Add(LisItem);
                txt_name.Clear();
                NUD_G1.Value = 0;
                NUD_G2.Value = 0;
                NUD_G3.Value = 0;
                txt_name.Focus();
            }
            catch
            {
                MessageBox.Show("Error!!!!! - Check your entries.");
            }
        }

        private void LSTresults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LSTresults.Items.Count > 0)
            {
                LSTresults.Items.Clear();
            }
        }
    }
}
