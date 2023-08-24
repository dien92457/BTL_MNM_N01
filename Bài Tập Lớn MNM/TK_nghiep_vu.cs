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
    public partial class TK_nghiep_vu : Form
    {
        public TK_nghiep_vu()
        {
            InitializeComponent();
        }

        private void TK_nghiep_vu_Load(object sender, EventArgs e)
        {
            rdb_TDT.Checked = true;
        }

        private void rdb_TDT_CheckedChanged(object sender, EventArgs e)
        {
            lbl_TK.Text = "Tên đào tạo:";
        }

        private void rdb_TCT_CheckedChanged(object sender, EventArgs e)
        {
            lbl_TK.Text = "Tên công tác:";
        }
    }
}
