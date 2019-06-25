using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2_QuyDoiTien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
             double kq, kqc;
            string chu = textBox1.Text;
            float so = float.Parse(chu);
            string Itemtype = comboBox1.Text;
            string Itemtype1 = comboBox2.Text;
            if (Itemtype != null && Itemtype1 != null)
            {

                if (Itemtype == "USD")
                {
                    kq = 22.772 * so;
                    label5.Text = "22.772";
                }
                else if (Itemtype == "EUR")
                {
                    kq = 28.132 * so;
                    label5.Text = "28.132";
                }
                else if (Itemtype == "GBP")
                {
                    kq = 31.538 * so;
                    label5.Text = "31.538";
                }
                else if (Itemtype == "SGD")
                {
                    kq = 17.286 * so;
                    label5.Text = "17.286";
                }
                else if (Itemtype == "JPY")
                {
                    kq = 214 * so;
                    label5.Text = "214";
                }
                else kq = so;
           
                if (Itemtype1 == "USD")
                {
                    kqc = kq/22.772;
                    label7.Text = "22.772";
                }
                else if (Itemtype1 == "EUR")
                {
                    kqc = kq/28.132;
                    label7.Text = "28.132";
                }
                else if (Itemtype1 == "GBP")
                {
                    kqc = kq/31.538;
                    label7.Text = "31.538";
                }
                else if (Itemtype1 == "SGD")
                {
                    kqc = kq/17.286;
                    label7.Text = "17.286";
                }
                else if (Itemtype1 == "JPY")
                {
                    kqc = kq/214;
                    label7.Text = "214";
                }
                else kqc = kq;

                textBox2.Text = kqc.ToString();
               
            }
            else MessageBox.Show("rỗng rồi ");

        }
    }
}
