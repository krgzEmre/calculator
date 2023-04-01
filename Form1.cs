using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        char islem;
        bool ekran;
        int ilksayı;
        int ikincisayı;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ekran)
            {
                txtgöster.Text = "";
                ekran = false;
            }
            if (txtgöster.Text == "0")
            {
                txtgöster.Text = "";
            }
            txtgöster.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ekran)
            {
                txtgöster.Text = "";
                ekran = false;
            }
            if (txtgöster.Text == "0")
            {
                txtgöster.Text = "";
            }
            txtgöster.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ekran)
            {
                txtgöster.Text = "";
                ekran = false;
            }
            if (txtgöster.Text == "0")
            {
                txtgöster.Text = "";
            }
            txtgöster.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ekran)
            {
                txtgöster.Text = "";
                ekran = false;
            }
            if (txtgöster.Text == "0")
            {
                txtgöster.Text = "";
            }
            txtgöster.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ekran)
            {
                txtgöster.Text = "";
                ekran = false;
            }
            if (txtgöster.Text == "0")
            {
                txtgöster.Text = "";
            }
            txtgöster.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ekran)
            {
                txtgöster.Text = "";
                ekran = false;
            }
            if (txtgöster.Text == "0")
            {
                txtgöster.Text = "";
            }
            txtgöster.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (ekran)
            {
                txtgöster.Text = "";
                ekran = false;
            }
            if (txtgöster.Text == "0")
            {
                txtgöster.Text = "";
            }
            txtgöster.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ekran)
            {
                txtgöster.Text = "";
                ekran = false;
            }
            if (txtgöster.Text == "0")
            {
                txtgöster.Text = "";
            }
            txtgöster.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (ekran)
            {
                txtgöster.Text = "";
                ekran= false;
            }
            if (txtgöster.Text == "0")
            {
                txtgöster.Text = "";
            }
            txtgöster.Text += "9";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (ekran)
            {
                txtgöster.Text = "";
                ekran = false;
            }
            if (txtgöster.Text == "0")
            {
                txtgöster.Text = "";
            }
            txtgöster.Text += "0";
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekran = true;
            ilksayı = int.Parse(txtgöster.Text);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekran = true;
            ilksayı = int.Parse(txtgöster.Text);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekran = true;
            ilksayı = int.Parse(txtgöster.Text);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekran = true;
            ilksayı = int.Parse(txtgöster.Text);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            int ikincisayı = int.Parse(txtgöster.Text);
            int sonuc = 0;

            switch (islem)
            {
                case '+':
                         sonuc = ilksayı + ikincisayı;
                    break;
                case '-':
                    sonuc = ilksayı + ikincisayı;
                    break;
                case '*':
                    sonuc = ilksayı + ikincisayı;
                    break;
                case '/':
                    sonuc = ilksayı + ikincisayı;
                    break;
                default:
                    break;
            }
            txtgöster.Text = sonuc.ToString();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            ilksayı = 0;
            ikincisayı = 0;
            txtgöster.Text = "0";
            
        }
    }
}
