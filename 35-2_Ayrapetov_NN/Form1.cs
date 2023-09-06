using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35_2_Ayrapetov_NN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tempHandler(Button b)
        {
            if (b.BackColor == Color.White)
            {
                b.BackColor = Color.Black;
            }
            else
            {
                b.BackColor = Color.White;
            }
        }

        private void px1_Click(object sender, EventArgs e){
            tempHandler(px1);
        }

        private void px2_Click(object sender, EventArgs e)
        {
            tempHandler(px2);
        }

        private void px3_Click(object sender, EventArgs e)
        {
            tempHandler(px3);
        }

        private void px4_Click(object sender, EventArgs e)
        {
            tempHandler(px4);
        }

        private void px5_Click(object sender, EventArgs e)
        {
            tempHandler(px5);
        }

        private void px6_Click(object sender, EventArgs e)
        {
            tempHandler(px6);
        }

        private void px7_Click(object sender, EventArgs e)
        {
            tempHandler(px7);
        }

        private void px8_Click(object sender, EventArgs e)
        {
            tempHandler(px8);
        }

        private void px9_Click(object sender, EventArgs e)
        {
            tempHandler(px9);
        }

        private void px10_Click(object sender, EventArgs e)
        {
            tempHandler(px10);
        }

        private void px11_Click(object sender, EventArgs e)
        {
            tempHandler(px11);
        }

        private void px12_Click(object sender, EventArgs e)
        {
            tempHandler(px12);
        }

        private void px13_Click(object sender, EventArgs e)
        {
            tempHandler(px13);
        }

        private void px14_Click(object sender, EventArgs e)
        {
            tempHandler(px14);
        }

        private void px15_Click(object sender, EventArgs e)
        {
            tempHandler(px15);
        }
    }
}
