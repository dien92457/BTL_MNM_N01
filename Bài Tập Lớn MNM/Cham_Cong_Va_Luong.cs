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
    public partial class Cham_Cong_Va_Luong : Form
    {
        public Cham_Cong_Va_Luong()
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
            OpenFormBody(new Bang_cham_cong());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Khen_thuong());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Ky_luat());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Tien_bao_hiem());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Phu_cap());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Bang_luong());
        }
    }
}
