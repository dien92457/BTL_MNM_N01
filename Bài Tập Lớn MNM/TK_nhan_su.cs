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
    public partial class TK_nhan_su : Form
    {
        public TK_nhan_su()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_TK.Text = "Mã nhân viên:";
            txt_TK.ResetText();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_TK.Text = "Tên nhân viên:";
            txt_TK.ResetText();
        }

        private void txt_TK_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdb_TPB_CheckedChanged(object sender, EventArgs e)
        {
            lbl_TK.Text = "Tên phòng ban:";
            txt_TK.ResetText();
        }

        private void rdb_TCC_CheckedChanged(object sender, EventArgs e)
        {
            lbl_TK.Text = "Tên chứng chỉ:";
            txt_TK.ResetText();
        }

        private void TK_nhan_su_Load(object sender, EventArgs e)
        {
            rdb_MNV.Checked = true;
        }
    }
}
