using Bài_Tập_Lớn_MNM.Backend;
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
    public partial class Dang_Nhap : Form
    {
        public Dang_Nhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int mnv = Convert.ToInt32(text_mnv.Text);
                string pass = text_pass.Text;
                databasecontrol databasecontrol = new databasecontrol();
                string query = "SELECT * FROM TaiKhoan WHERE MNV = @MNV AND pass = @pass ";
                if (databasecontrol.ExecuteQuery(query, new object[] {mnv, pass}).Rows.Count>0)
                {
                    Giao_Dien f1 = new Giao_Dien();
                    f1.Show();
                    this.Hide();
                    Dang_Nhap_DAO.Instance.get_type(mnv);
                }
                

            } catch
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
