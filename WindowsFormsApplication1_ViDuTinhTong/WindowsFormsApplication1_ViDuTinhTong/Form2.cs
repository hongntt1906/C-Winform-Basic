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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string so = textBox1.Text;
            int chu = int.Parse(so);
            switch (chu)
            { 
                case 0:
                    textBox2.Text = "Không";
                    break;
                case 1:
                    textBox2.Text = "Một";
                    break;
                case 2:
                    textBox2.Text = "Hai";
                    break;
                case 3:
                    textBox2.Text = "Ba";
                    break;
                case 4:
                    textBox2.Text = "Bốn";
                    break;
                case 5:
                    textBox2.Text = "Năm";
                    break;
                case 6:
                    textBox2.Text = "Sáu";
                    break;
                case 7:
                    textBox2.Text = "Bảy";
                    break;
                case 8:
                    textBox2.Text = "Tám";
                    break;
                case 9:
                    textBox2.Text = "Chín";
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
