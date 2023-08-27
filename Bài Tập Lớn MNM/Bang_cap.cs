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
    public partial class Bang_cap : Form
    {
        public Bang_cap()
        {
            InitializeComponent();
        }
        public void data_show()
        {
            databasecontrol dataprovide = new databasecontrol();
            String stm = "SELECT * FROM BangCap";
            dataGridView1.DataSource = dataprovide.ExecuteQuery(stm);
        }

        private void BTN_insert_Click(object sender, EventArgs e)
        {
            String ten = txt_TBC.Text;
            int id = Convert.ToInt32(txt_MNV.Text);
            int MBC = Convert.ToInt32(txt_MBC.Text);
            String xl = txt_XL.Text;


            databasecontrol dataprovide = new databasecontrol();
            string query = "SELECT * FROM NhanVien where MaNhanVien = @id ";         
            if (dataprovide.ExecuteQuery(query, new object[] { id }).Rows.Count > 0)
            {
                string query1 = "INSERT INTO BangCap ( MaBangCap , MaNhanVien , TenBangCap , XepLoai) VALUES ( @MBC , @id , @ten , @xl );";
                dataprovide.ExecuteNonQuery(query1, new object[] { MBC, id, ten, xl });
                this.data_show();
            }
            else MessageBox.Show("Mã nhân viên không tồn tại");

        }

        private void BTN_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_MNV.Text);
            int MBC = Convert.ToInt32(txt_MBC.Text);
            String ten = txt_TBC.Text;
            string xl = txt_XL.Text;


            UpdateData(MBC, id , ten, xl);
            data_show();

        }
        private void UpdateData(int MBC, int id, string ten, string xl)
        {
            try
            {
                databasecontrol databaseControl = new databasecontrol();
                string query = "UPDATE BangCap SET MaNhanVien = @id ,  TenBangCap = @ten ,  XepLoai = @xl WHERE MaBangCap = @MBC";
                databaseControl.ExecuteNonQuery(query, new object[] { id , ten , xl , MBC });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void DeleteData(int id)
        {
            try
            {
                databasecontrol databaseControl = new databasecontrol();
                string query = "DELETE FROM BangCap WHERE MaBangCap = @id";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txt_MNV.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
                txt_TBC.Text = selectedRow.Cells["TenBangCap"].Value.ToString();
                txt_MBC.Text = selectedRow.Cells["MaBangCap"].Value.ToString();
                txt_XL.Text = selectedRow.Cells["XepLoai"].Value.ToString();

            }
        }

        private void Bang_cap_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_show();
        }

        private void BTN_reset_Click(object sender, EventArgs e)
        {
            txt_TBC.Clear();
            txt_MNV.Clear();
            txt_MBC.Clear();
            txt_XL.Clear();

        }
    }
}
