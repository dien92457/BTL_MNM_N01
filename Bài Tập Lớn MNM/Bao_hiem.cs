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
    public partial class Bao_hiem : Form
    {
        public Bao_hiem()
        {
            InitializeComponent();
        }
        public void data_show()
        {
            databasecontrol dataprovide = new databasecontrol();
            String stm = "SELECT * FROM BaoHiem";
            dataGridView1.DataSource = dataprovide.ExecuteQuery(stm);
        }
        private void BTN_insert_Click(object sender, EventArgs e)
        {
            String ten = txt_TBH.Text;
            int id = Convert.ToInt32(txt_MNV.Text);
            int MSBH = Convert.ToInt32(txt_MSBH.Text);
            int SBH = Convert.ToInt32(txt_SBH.Text);
            String th = dateTime_TH.Value.Year.ToString();
            String nl = dateTime_NL.Value.ToShortDateString();
            databasecontrol dataprovide = new databasecontrol();
            string query = "SELECT * FROM NhanVien where MaNhanVien = @id ";
            if (dataprovide.ExecuteQuery(query, new object[] { id }).Rows.Count > 0)
            {
                string query1 = "INSERT INTO BaoHiem ( MaBaoHiem , MaNhanVien , SoBaoHiem , TenBaoHiem , NgayLap , ThoiHan) VALUES ( @MBH , @id , @SBH , @ten , @nl , @th );";
                dataprovide.ExecuteNonQuery(query1, new object[] { MSBH , id , SBH , ten , nl , th });
                this.data_show();
            }
            else MessageBox.Show("Mã nhân viên không tồn tại");

        }
        private void UpdateData(int MSBH, int id, int SBH ,string ten, DateTime nc, DateTime th)
        {
            try
            {
                databasecontrol databaseControl = new databasecontrol();
                string query = "UPDATE BaoHiem SET MaNhanVien = @id , SoBaoHiem = @SBH , TenBaoHiem = @ten , NgayCap = @nc , ThoiHan = @th  WHERE MaBaoHiem = @MBH";
                databaseControl.ExecuteNonQuery(query, new object[] { id, SBH , ten, nc, th, MSBH });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BTN_update_Click(object sender, EventArgs e)
        {
            String ten = txt_TBH.Text;
            int id = Convert.ToInt32(txt_MNV.Text);
            int MSBH = Convert.ToInt32(txt_MSBH.Text);
            int SBH = Convert.ToInt32(txt_SBH.Text);
            DateTime nc = dateTime_NL.Value;
            DateTime th = dateTime_TH.Value;


            UpdateData(MSBH, id, SBH, ten, nc, th);
            data_show();
        }
        private void DeleteData(int id)
        {
            try
            {
                databasecontrol databaseControl = new databasecontrol();
                string query = "DELETE FROM BaoHiem WHERE MaBaoHiem = @MBH";
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
            txt_MSBH.Clear();
            txt_MNV.Clear();
            txt_SBH.Clear();
            txt_TBH.Clear();
            dateTime_NL.Value = DateTime.Now;
            dateTime_TH.Value = DateTime.Now;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txt_MNV.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
                txt_TBH.Text = selectedRow.Cells["TenBaoHiem"].Value.ToString();
                txt_MSBH.Text = selectedRow.Cells["MaBaoHiem"].Value.ToString();
                txt_SBH.Text = selectedRow.Cells["SoBaoHiem"].Value.ToString();

                if (DateTime.TryParse(selectedRow.Cells["NgayLap"].Value.ToString(), out DateTime nl))
                {
                    dateTime_NL.Value = nl;
                }
                if (DateTime.TryParse(selectedRow.Cells["ThoiHan"].Value.ToString(), out DateTime th))
                {
                    dateTime_NL.Value = th;
                }

            }
        }

        private void Bao_hiem_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_show();
        }


    }
}
