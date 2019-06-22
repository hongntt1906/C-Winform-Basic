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
            string chu = textBox1.Text;
            int so = int.Parse(chu);

            string[] abc= new string[] {"không","một","hai","ba","bốn","năm","sáu","bảy","tám","chín"};

            if (so / 10 == 0)
                textBox2.Text = abc[so];
            else if (so / 100 == 0)
                textBox2.Text = chuc(so, abc);
            else if (so / 1000 == 0)
                textBox2.Text = tram(so, abc);
            else if (so / 10000 == 0)
                textBox2.Text = abc[so / 1000] + " nghìn " + tram(so % 1000, abc);
            else if (so / 100000 == 0)
                textBox2.Text = chuc(so / 1000, abc) + " nghìn " + tram(so % 1000, abc);
            else if (so / 1000000 == 0)
                textBox2.Text = tramnghin(so, abc);
            else if (so / 10000000 == 0)
                textBox2.Text = abc[so / 1000000] + " triệu " + tramnghin(so % 1000000, abc);
            else if (so / 100000000 == 0)
                textBox2.Text = chuc(so / 1000000, abc) + " triệu " + tramnghin(so % 1000000, abc);
            else if (so / 1000000000 == 0)
                textBox2.Text = tram(so / 1000000, abc) + " triệu " + tramnghin(so % 1000000, abc);
            else textBox2.Text = "!!!!";
        }

        private string chuc(int c, string[] abc)
        {
            if (c == 0)
                return " ";
            if (c / 10 == 0)
            { 
                return " linh " + abc[c%10];
            }
            else if (c / 10 == 1)
            {
                if (c % 10 == 0)
                    return "mười";
                else
                    return " mười " + abc[c % 10];
            }
            else
            {
                if (c % 10 == 0)
                    return abc[c / 10] + " mươi ";
                else
                    return abc[c / 10] + " mươi " + abc[c % 10];
            }
        }
        private string tram(int t, string[] abc)
        {
            if (t == 0)
                return " ";
            return abc[t / 100] + " trăm " + chuc(t % 100, abc);
        }
        private string tramnghin(int tn, string[] abc)
        {
            return tram(tn / 1000, abc) + " nghìn " + tram(tn % 1000, abc);
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
