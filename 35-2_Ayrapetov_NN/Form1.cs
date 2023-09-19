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
        int[] inputData;

        public int[] InputData
        {
            get { return inputData; }
            set { inputData = value; }
        }

        public Form1()
        {
            InputData = new int[15];
            InitializeComponent();
        }

        private void tempHandler(Button b, int id)
        {
            if (b.BackColor == Color.White)
            {
                b.BackColor = Color.Black;
                InputData[id] = 1;
            }
            else
            {
                b.BackColor = Color.White;
                InputData[id] = 0;
            }
            Console.WriteLine($"id[{id}] = {InputData[id]}");
        }

        private void px1_Click(object sender, EventArgs e) => tempHandler(px1,0);

        private void px2_Click(object sender, EventArgs e) => tempHandler(px2,1);

        private void px3_Click(object sender, EventArgs e) => tempHandler(px3,2);

        private void px4_Click(object sender, EventArgs e) => tempHandler(px4,3);

        private void px5_Click(object sender, EventArgs e) => tempHandler(px5,4);

        private void px6_Click(object sender, EventArgs e) => tempHandler(px6,5);

        private void px7_Click(object sender, EventArgs e) => tempHandler(px7,6);

        private void px8_Click(object sender, EventArgs e) => tempHandler(px8,7);

        private void px9_Click(object sender, EventArgs e) => tempHandler(px9,8);

        private void px10_Click(object sender, EventArgs e) => tempHandler(px10,9);

        private void px11_Click(object sender, EventArgs e) => tempHandler(px11,10);

        private void px12_Click(object sender, EventArgs e) => tempHandler(px12,11);

        private void px13_Click(object sender, EventArgs e) => tempHandler(px13,12);

        private void px14_Click(object sender, EventArgs e) => tempHandler(px14,13);

        private void px15_Click(object sender, EventArgs e) => tempHandler(px15,14);
    }
}
