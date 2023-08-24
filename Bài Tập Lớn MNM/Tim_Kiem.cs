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
    public partial class Tim_Kiem : Form
    {
        public Tim_Kiem()
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
            OpenFormBody(new TK_nhan_su());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormBody(new TK_cham_cong_luong());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFormBody(new TK_nghiep_vu());
        }
    }
}
