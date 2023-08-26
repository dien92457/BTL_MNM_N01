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
    public partial class Phong_ban : Form
    {
        public Phong_ban()
        {
            InitializeComponent();
        }
        public void data_show()
        {
            databasecontrol dataprovide = new databasecontrol();
            String stm = "SELECT * FROM PhongBan";
            dataGridView1.DataSource = dataprovide.ExecuteQuery(stm);
        }

       

       
        private void BTN_reset_Click(object sender, EventArgs e)
        {
            txt_TPB.Clear();
            txt_MNV.Clear();
            txt_MPB.Clear();
           
        }


        private void DeleteData(int id)
        {
            try
            {
                databasecontrol databaseControl = new databasecontrol();
                string query = "DELETE FROM PhongBan WHERE MaPhongBan = @id";
                databaseControl.ExecuteNonQuery(query, new object[] { id });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        
        private void UpdateData(int MPB , int id, string ten )
        {
            try
            {
                databasecontrol databaseControl = new databasecontrol();
                string query = "UPDATE PhongBan SET TenPhongBan = @ten , MaNhanVien = @id  WHERE MaPhongBan = @MPB";
                databaseControl.ExecuteNonQuery(query, new object[] { ten,  id , MPB});
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BTN_INSERT_Click_1(object sender, EventArgs e)
        {
            String ten = txt_TPB.Text;
            int id = Convert.ToInt32(txt_MNV.Text);
            int MPB = Convert.ToInt32(txt_MPB.Text);


            databasecontrol dataprovide = new databasecontrol();
            string query = "INSERT INTO PhongBan ( MaPhongBan , MaNhanVien , TenPhongBan) VALUES ( @MPB , @id , @ten );";
            dataprovide.ExecuteNonQuery(query, new object[] { MPB, id, ten });
            this.data_show();

        }

        private void BTN_update_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_MNV.Text);
            int MPB = Convert.ToInt32(txt_MPB.Text);
            String ten = txt_TPB.Text;


            UpdateData(MPB, id, ten);
            data_show();

        }

        private void BTN_delete_Click_1(object sender, EventArgs e)
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
                txt_TPB.Text = selectedRow.Cells["TenPhongBan"].Value.ToString();
                txt_MPB.Text = selectedRow.Cells["MaPhongBan"].Value.ToString();

            }
        }

        private void Phong_ban_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_show();
        }
    }
    
}
