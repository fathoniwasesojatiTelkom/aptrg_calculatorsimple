using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TONY
{
    public partial class Form1 : Form
    {
        float num1, aso;
        String ano = "";
        string ha;
        private readonly object txtDisplay;

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Text = "";
            ano = "a";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Text = "";
            ano = "b";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Text = "";
            ano = "c";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Text = "";
            ano = "d";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            compute(aso);
        }

        private void compute(float aso)
        {
            const string V = "f";
            switch (ano)
            {
                case "a":
                    aso = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = aso.ToString();
                    break;
                case "b":
                    aso = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = aso.ToString();
                    break;
                case "c":
                    aso = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = aso.ToString();
                    break;
                case "d":
                    aso = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = aso.ToString();
                    break;
               

         


            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int hakel = textBox1.TextLength - 1;
            string prog = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < hakel; i++)
                textBox1.Text = textBox1.Text + prog[i];

        }

        private void button21_Click(object sender, EventArgs e)
        {
            int a = textBox1.TextLength;
            int batas = 0;
            string data = textBox1.Text;
            for(int i=0;i<a;i++)
            {
                if(data[i].ToString() == ".")
                {
                    batas = 1;
                    break;
                }
                else
                {
                    batas = 0;
                }
                if(batas == 0 )
                {
                    textBox1.Text = textBox1.Text + ".";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(textBox1.Text);
            ilog = Math.Tan(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sinusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 521;
            sinusToolStripMenuItem.Width = 644;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(textBox1.Text);
            ilog = Math.Sin(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(textBox1.Text);
            ilog = Math.Cos(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;

        }
    }
}
