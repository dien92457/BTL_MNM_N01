using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_Lớn_MNM
{
    public partial class Giao_Dien : Form
    {
        public Giao_Dien()
        {
            InitializeComponent();
        }

        private Form currentFormBody;

        private void OpenFormBody(Form FormBody)
        {
            if (currentFormBody != null)
            {
                currentFormBody.Close();
            }
            currentFormBody = FormBody;
            FormBody.TopLevel = false;
            FormBody.FormBorderStyle = FormBorderStyle.None;
            FormBody.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(FormBody);
            panel_Body.Tag = FormBody;
            FormBody.BringToFront();
            FormBody.Show();
        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormBody(new He_Thong());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Quan_Ly_Nhan_Su());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Cham_Cong_Va_Luong());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Quan_Ly_Nghiep_Vu());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Tim_Kiem());
        }

        private void Giao_Diện_Load(object sender, EventArgs e)
        {
            this.Size = new Size(750, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
    }
}
