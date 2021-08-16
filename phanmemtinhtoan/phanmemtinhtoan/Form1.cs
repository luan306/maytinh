using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phanmemtinhtoan
{
    
    public partial class MayTinh : Form
    {
        string kq;
        double a;
        double b;
        
        public MayTinh()
        {
            InitializeComponent();
        }

        private void reset_btn(object sender, EventArgs e)
        {
            textBox1.ResetText();
           
        }

        private void total_btn(object sender, EventArgs e)
        {
            kq = "+";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void tru_btn(object sender, EventArgs e)
        {

            kq = "-";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void nhan_btn(object sender, EventArgs e)
        {
            kq = "*";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void chia_btn(object sender, EventArgs e)
        {
            kq = "/";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void btn_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void btn_2(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void btn_3(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void btn_4(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void btn_5(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button12.Text;
        }

        private void btn_6(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void btn_7(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button13.Text;
        }

        private void btn_8(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button15.Text;
        }

        private void btn_9(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button14.Text;
        }

        private void btn_0(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button16.Text;
        }

        private void Thoat_btn(object sender, EventArgs e)
        {
            DialogResult help;
            help = (MessageBox.Show("Bạn có muốn thoát hay không ?" ,"Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (help == DialogResult.Yes)
                Application.Exit();
        }

        private void bang_btn(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);
            double result;
            if (kq == "+")
            {
                result = a + b;
                textBox1.Text = result.ToString();
            }
            else if (kq == "-")
            {
                result = a - b;
                textBox1.Text = result.ToString();
            }
            else if (kq == "*")
            {
                result = a * b;
                textBox1.Text = result.ToString();
            }
            else
            {
                result = a / b;
                textBox1.Text = result.ToString();
            }
        }
    }
}
