using _35_2_Ayrapetov_NN.ModelNN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35_2_Ayrapetov_NN
{
    public partial class Form1 : Form
    {
        double[] inputData;
        Network n = new Network(NetworkMode.Test);
        public double[] InputData
        {
            get { return inputData; }
            set { inputData = value; }
        }

        public Form1()
        {
            InputData = new double[15];
            InitializeComponent();
        }

        private void clickHandler(object but, int id){
            Button b =(Button)but;
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
            //Console.WriteLine($"id[{id}] = {InputData[id]}");
        }

        private void px1_Click(object sender, EventArgs e) => clickHandler(sender,0);

        private void px2_Click(object sender, EventArgs e) => clickHandler(sender, 1);

        private void px3_Click(object sender, EventArgs e) => clickHandler(sender,2);

        private void px4_Click(object sender, EventArgs e) => clickHandler(sender,3);

        private void px5_Click(object sender, EventArgs e) => clickHandler(sender,4);

        private void px6_Click(object sender, EventArgs e) => clickHandler(sender,5);

        private void px7_Click(object sender, EventArgs e) => clickHandler(sender,6);

        private void px8_Click(object sender, EventArgs e) => clickHandler(sender,7);

        private void px9_Click(object sender, EventArgs e) => clickHandler(sender,8);

        private void px10_Click(object sender, EventArgs e) => clickHandler(sender,9);

        private void px11_Click(object sender, EventArgs e) => clickHandler(sender,10);

        private void px12_Click(object sender, EventArgs e) => clickHandler(sender,11);

        private void px13_Click(object sender, EventArgs e) => clickHandler(sender,12);

        private void px14_Click(object sender, EventArgs e) => clickHandler(sender,13);

        private void px15_Click(object sender, EventArgs e) => clickHandler(sender,14);

        private void saveTrainDataBtn_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "trainData.txt";
            string data = digitField.Value.ToString();
            foreach(int i in InputData){
                data += " " + i.ToString();
            }
            data += "\n";
            File.AppendAllText(path, data);
            //logTextBox.Text = "Данные сохранены в " + path;
        }

        private void saveTestDataBtn_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "testData.txt";
            string data = digitField.Value.ToString();
            foreach (int i in InputData)
            {
                data += " " + i.ToString();
            }
            data += "\n";
            File.AppendAllText(path, data);
        }

        private void recBtn_Click(object sender, EventArgs e)
        {
            n.ForwardPass(n, InputData);
            var j = 0;
            var mx = 0.0;
            for (int i = 0; i < n.Fact.Length; i++)
            {
                if (n.Fact[i] > mx)
                {
                    j = i;
                    mx = n.Fact[j];
                }
            }
            MessageBox.Show(
                j.ToString(),
            "Предсказание",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
