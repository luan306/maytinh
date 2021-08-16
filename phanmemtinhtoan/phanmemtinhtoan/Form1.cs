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
        int a, b;
        public MayTinh()
        {
            InitializeComponent();
        }

        private void reset_btn(object sender, EventArgs e)
        {
            tb_a.ResetText();
            tb_b.ResetText();
            tb_kq.ResetText();
        }

        private void total_btn(object sender, EventArgs e)
        {
            a = Convert.ToInt32(tb_a.Text);
            b = Convert.ToInt32(tb_b.Text);
            tb_kq.Text = Convert.ToString(a + b);

        }

        private void tru_btn(object sender, EventArgs e)
        {
            a = Convert.ToInt32(tb_a.Text);
            b = Convert.ToInt32(tb_b.Text);
            tb_kq.Text = Convert.ToString(a - b);

        }

        private void nhan_btn(object sender, EventArgs e)
        {
            a = Convert.ToInt32(tb_a.Text);
            b = Convert.ToInt32(tb_b.Text);
            tb_kq.Text = Convert.ToString(a * b);
        }

        private void chia_btn(object sender, EventArgs e)
        {
            a = Convert.ToInt32(tb_a.Text);
            b = Convert.ToInt32(tb_b.Text);
            tb_kq.Text = Convert.ToString(a / b);
        }

        private void Thoat_btn(object sender, EventArgs e)
        {
            DialogResult help;
            help = (MessageBox.Show("Bạn có muốn thoát hay không ?" ,"Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (help == DialogResult.Yes)
                Application.Exit();
        }
    }
}
