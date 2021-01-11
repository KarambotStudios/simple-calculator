using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            string v = richTextBox2.Text;
            string v2 = "";
            if (v == v2)
            {
                richTextBox1.Text = richTextBox1.Text + "0";
            }
            else
            {
                richTextBox3.Text = richTextBox3.Text + "0";
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string v = richTextBox2.Text;
            string v2 = "";
            if (v == v2)
            {
                richTextBox1.Text = richTextBox1.Text + "1";
            }
            else
            {
                richTextBox3.Text = richTextBox3.Text + "1";
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            string v = richTextBox2.Text;
            string v2 = "";
            if (v == v2)
            {
                richTextBox1.Text = richTextBox1.Text + "2";
            }
            else
            {
                richTextBox3.Text = richTextBox3.Text + "2";
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            string v = richTextBox2.Text;
            string v2 = "";
            if (v == v2)
            {
                richTextBox1.Text = richTextBox1.Text + "3";
            }
            else
            {
                richTextBox3.Text = richTextBox3.Text + "3";
            }
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            string v = richTextBox2.Text;
            string v2 = "";
            if (v == v2)
            {
                richTextBox1.Text = richTextBox1.Text + "4";
            }
            else
            {
                richTextBox3.Text = richTextBox3.Text + "4";
            }
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            string v = richTextBox2.Text;
            string v2 = "";
            if (v == v2)
            {
                richTextBox1.Text = richTextBox1.Text + "5";
            }
            else
            {
                richTextBox3.Text = richTextBox3.Text + "5";
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            string v = richTextBox2.Text;
            string v2 = "";
            if (v == v2)
            {
                richTextBox1.Text = richTextBox1.Text + "6";
            }
            else
            {
                richTextBox3.Text = richTextBox3.Text + "6";
            }
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            string v = richTextBox2.Text;
            string v2 = "";
            if (v == v2)
            {
                richTextBox1.Text = richTextBox1.Text + "7";
            }
            else
            {
                richTextBox3.Text = richTextBox3.Text + "7";
            }
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            string v = richTextBox2.Text;
            string v2 = "";
            if (v == v2)
            {
                richTextBox1.Text = richTextBox1.Text + "8";
            }
            else
            {
                richTextBox3.Text = richTextBox3.Text + "8";
            }
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            string v = richTextBox2.Text;
            string v2 = "";
            if (v == v2)
            {
                richTextBox1.Text = richTextBox1.Text + "9";
            }
            else
            {
                richTextBox3.Text = richTextBox3.Text + "9";
            }
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = "X";
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            if(richTextBox2.Text == "X")
            { 
                string xy = richTextBox1.Text;
                string yx = richTextBox3.Text;
                int x = int.Parse(xy);
                int y = int.Parse(yx);
                int v = x*y;
                string answer = v.ToString();
                richTextBox4.Text = answer;
            }
            if (richTextBox2.Text == "+")
            {
                string xy = richTextBox1.Text;
                string yx = richTextBox3.Text;
                int x = int.Parse(xy);
                int y = int.Parse(yx);
                int v = x + y;
                string answer = v.ToString();
                richTextBox4.Text = answer;
            }
            if (richTextBox2.Text == "-")
            {
                string xy = richTextBox1.Text;
                string yx = richTextBox3.Text;
                int x = int.Parse(xy);
                int y = int.Parse(yx);
                int v = x - y;
                string answer = v.ToString();
                richTextBox4.Text = answer;
            }
            if (richTextBox2.Text == ":")
            {
                string xy = richTextBox1.Text;
                string yx = richTextBox3.Text;
                int x = int.Parse(xy);
                int y = int.Parse(yx);
                int v = x / y;
                string answer = v.ToString();
                richTextBox4.Text = answer;
                string ver1 = richTextBox1.Text;
                string ver2 = richTextBox3.Text;
                int v1 = int.Parse(ver1);
                int v2 = int.Parse(ver2);
                if (v1 < v2)
                {
                    richTextBox1.Text = richTextBox1.Text + "0";
                    string zb = richTextBox1.Text;
                    string bz = richTextBox3.Text;
                    int z = int.Parse(zb);
                    int b = int.Parse(bz);
                    int r = (z / b);
                    string result = r.ToString();
                    richTextBox4.Text = "0." + result;
                    richTextBox1.Text = "";
                    richTextBox2.Text = "";
                    richTextBox3.Text = "";
                }

            }



            if (richTextBox2.Text == "%")
            {
                richTextBox1.Text = richTextBox1.Text + "0";
                string xy = richTextBox1.Text;
                string yx = richTextBox3.Text;
                int x = int.Parse(xy);
                int y = int.Parse(yx);
                int v = (x / y) * 10;
                string answer = v.ToString();
                richTextBox4.Text = answer + "%";
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                richTextBox3.Text = "";
            }
        }

        private void button16_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = "+";
        }

        private void button15_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = "-";
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = ":";
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
        }

        private void button17_MouseClick(object sender, MouseEventArgs e)
        {

            richTextBox2.Text = "%";
            
        }

        private void button18_MouseClick(object sender, MouseEventArgs e)
        {
            string xy = richTextBox1.Text;
            int x = int.Parse(xy);
            int v = x * x;
            string answer = v.ToString();
            richTextBox4.Text = answer;
        }

        private void button19_MouseClick(object sender, MouseEventArgs e)
        {
            string xy = richTextBox1.Text;
            int x = int.Parse(xy);
            int v = x * x * x;
            string answer = v.ToString();
            richTextBox4.Text = answer;
        }

        private void button20_MouseClick(object sender, MouseEventArgs e)
        {
           

        }
    }
}
