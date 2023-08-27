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
    public partial class Hop_dong : Form
    {
        public Hop_dong()
        {
            InitializeComponent();
        }
        public void data_show()
        {
            databasecontrol dataprovide = new databasecontrol();
            String stm = "SELECT * FROM HopDong";
            dataGridView1.DataSource = dataprovide.ExecuteQuery(stm);
        }
        private void BTN_insert_Click(object sender, EventArgs e)
        {
            String ten = txt_THD.Text;
            int id = Convert.ToInt32(txt_MNV.Text);
            int MHD = Convert.ToInt32(txt_MHD.Text);
            String th = dateTime_TH.Value.Year.ToString();
            String nl = dateTime_NK.Value.ToShortDateString();
            String nd = txt_ND.Text;
            String gc = txt_GC.Text;
            databasecontrol dataprovide = new databasecontrol();
            string query = "SELECT * FROM NhanVien where MaNhanVien = @id ";
            if (dataprovide.ExecuteQuery(query, new object[] { id }).Rows.Count > 0)
            {
                string query1 = "INSERT INTO HopDong ( MaHopDong , MaNhanVien ,  TenHopDong , NgayKi , ThoiHan , NoiDung , GhiChu ) VALUES ( @MHD , @id , @ten , @nl , @th , @nd , @gc );";
                dataprovide.ExecuteNonQuery(query1, new object[] { MHD, id, ten, nl, th, nd, gc });
                this.data_show();
            }
            else MessageBox.Show("Mã nhân viên không tồn tại");

        }
        private void UpdateData(int MHD, int id, string ten, DateTime nc, DateTime th, String nd , String gc)
        {
            try
            {
                databasecontrol databaseControl = new databasecontrol();
                string query = "UPDATE HopDong SET MaNhanVien = @id , TenHopDong = @ten , NgayKi = @nc , ThoiHan = @th , NoiDung = @nd , GhiChu = @gc WHERE MaHopDong = @MHD";
                databaseControl.ExecuteNonQuery(query, new object[] { id, ten, nc, th, nd , gc , MHD });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void BTN_update_Click(object sender, EventArgs e)
        {
            String ten = txt_THD.Text;
            int id = Convert.ToInt32(txt_MNV.Text);
            int MHD = Convert.ToInt32(txt_MHD.Text);
            DateTime nc = dateTime_NK.Value;
            DateTime th = dateTime_TH.Value;
            String nd = txt_ND.Text;
            String gc = txt_GC.Text;


            UpdateData(MHD, id, ten, nc, th , nd , gc);
            data_show();
        }
        private void DeleteData(int id)
        {
            try
            {
                databasecontrol databaseControl = new databasecontrol();
                string query = "DELETE FROM HopDong WHERE MaHopDong = @MHD";
                databaseControl.ExecuteNonQuery(query, new object[] { id });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void BTN_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int idColumnIndex = 0; // Assuming the ID column is at index 0
                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[idColumnIndex].Value);

                DeleteData(id);

                dataGridView1.Rows.RemoveAt(rowIndex);
            }
        }

        private void BTN_reset_Click(object sender, EventArgs e)
        {
            txt_MHD.Clear();
            txt_MNV.Clear();
            txt_THD.Clear();
            dateTime_NK.Value = DateTime.Now;
            dateTime_TH.Value = DateTime.Now;
            txt_GC.Clear();
            txt_ND.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Hop_dong_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_show();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txt_MNV.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
                txt_THD.Text = selectedRow.Cells["TenHopDong"].Value.ToString();
                txt_MHD.Text = selectedRow.Cells["MaHopDong"].Value.ToString();
                if (DateTime.TryParse(selectedRow.Cells["NgayKi"].Value.ToString(), out DateTime nk))
                {
                    dateTime_NK.Value = nk;
                }
                if (DateTime.TryParse(selectedRow.Cells["ThoiHan"].Value.ToString(), out DateTime th))
                {
                    dateTime_TH.Value = th;
                }
                txt_ND.Text = selectedRow.Cells["NoiDung"].Value.ToString();
                txt_GC.Text = selectedRow.Cells["GhiChu"].Value.ToString();

            }
        }
    }
}
