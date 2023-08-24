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
    public partial class He_Thong : Form
    {
        public He_Thong()
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

        private void Hệ_Thống_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFormBody(new Quan_Ly_tai_khoan());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Doi_mat_khau());
        }
    }
}
