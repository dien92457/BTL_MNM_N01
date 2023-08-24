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
    public partial class Quan_Ly_Nhan_Su : Form
    {
        public Quan_Ly_Nhan_Su()
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Thong_tin_nhan_vien());
        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Bang_cap());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Chung_chi());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Phong_ban());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Hop_dong());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Bao_hiem());
        }

        private void Quản_Lý_Nhân_Sự_Load(object sender, EventArgs e)
        {

        }
    }
}
