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
    public partial class Quan_Ly_Nghiep_Vu : Form
    {
        public Quan_Ly_Nghiep_Vu()
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
            OpenFormBody(new Dao_tao());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormBody(new Cong_tac());
        }

        private void Quản_Lý_Nghiệp_Vụ_Load(object sender, EventArgs e)
        {

        }
    }
}
