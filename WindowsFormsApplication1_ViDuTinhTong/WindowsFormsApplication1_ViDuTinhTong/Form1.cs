using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1_ViDuTinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            string s3 = textBox3.Text;

            int s1int = int.Parse(s1);
            int s2int = int.Parse(s2);
            int s3int = int.Parse(s3);

            if (s1int > s2int)
            {
                if (s2int > s3int)
                {
                    textBox5.Text = s1int.ToString();
                    textBox4.Text = s3int.ToString();
                }
                else if (s1int > s3int)
                {
                    textBox5.Text = s1int.ToString();
                    textBox4.Text = s2int.ToString();
                }
                else
                {
                    textBox5.Text = s3int.ToString();
                    textBox4.Text = s2int.ToString();
                }
            }
            else
            {
                if (s1int > s3int)
                {
                    textBox5.Text = s2int.ToString();
                    textBox4.Text = s3int.ToString();
                }
                else if(s2int > s3int)
                {
                    textBox5.Text = s2int.ToString();
                    textBox4.Text = s1int.ToString();
                }
                else
                {
                    textBox5.Text = s3int.ToString();
                    textBox4.Text = s1int.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
