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
    public partial class Chung_chi : Form
    {
        public Chung_chi()
        {
            InitializeComponent();
        }
        public void data_show()
        {
            databasecontrol dataprovide = new databasecontrol();
            String stm = "SELECT * FROM ChungChi";
            dataGridView1.DataSource = dataprovide.ExecuteQuery(stm);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTN_reset_Click(object sender, EventArgs e)
        {
            txt_MCC.Clear();
            txt_MNV.Clear();         
            txt_NC.Clear();
            dateTime_NC.Value = DateTime.Now;
            dateTime_TH.Value = DateTime.Now;
        }

        private void BTN_insert_Click(object sender, EventArgs e)
        {
            string ten = txt_NC.Text;
            int id = Convert.ToInt32(txt_MNV.Text);
            int MCC = Convert.ToInt32(txt_MCC.Text);
            //string th = dateTime_TH.Value.ToString();
            //string nc = dateTime_NC.Value.Year.ToString();
            string th = dateTime_TH.Value.ToShortDateString();
            string nc = dateTime_NC.Value.Year.ToString();
            databasecontrol dataprovide = new databasecontrol();
            string query = "SELECT * FROM NhanVien where MaNhanVien = @id ";
            if (dataprovide.ExecuteQuery(query, new object[] {id}).Rows.Count > 0)
            {
                string query1 = "INSERT INTO ChungChi ( MaChungChi , MaNhanVien , TenChungChi , NgayCap , ThoiHan ) VALUES ( @MCC , @id , @ten , @nc, @th );";
                dataprovide.ExecuteNonQuery(query1, new object[] { MCC, id, txt_NC.Text, nc, th });
                this.data_show();   
            }
            else MessageBox.Show("Mã nhân viên không tồn tại");
            
        }
        
        private void UpdateData(int MCC, int id, string ten, DateTime nc, DateTime th)
        {
            try
            {
                databasecontrol databaseControl = new databasecontrol();
                string query = "UPDATE ChungChi SET MaNhanVien = @id , TenChungChi = @ten , NgayCap = @nc , ThoiHan = @th  WHERE MaChungChi = @MCC";
                databaseControl.ExecuteNonQuery(query, new object[] {  id , ten , nc, th, MCC });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BTN_update_Click(object sender, EventArgs e)
        {
            String ten = txt_NC.Text;
            int id = Convert.ToInt32(txt_MNV.Text);
            int MCC = Convert.ToInt32(txt_MCC.Text);
            DateTime nc = dateTime_NC.Value;
            DateTime th = dateTime_TH.Value;


            UpdateData(MCC, id, ten, nc, th);
            data_show();

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
        private void DeleteData(int id)
        {
            try
            {
                databasecontrol databaseControl = new databasecontrol();
                string query = "DELETE FROM ChungChi WHERE MaChungChi = @MCC";
                databaseControl.ExecuteNonQuery(query, new object[] { id });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txt_MNV.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
                txt_NC.Text = selectedRow.Cells["TenChungChi"].Value.ToString();
                txt_MCC.Text = selectedRow.Cells["MaChungChi"].Value.ToString();
                if (DateTime.TryParse(selectedRow.Cells["NgayCap"].Value.ToString(), out DateTime nc))
                {
                    dateTime_NC.Value = nc;
                }
                if (DateTime.TryParse(selectedRow.Cells["ThoiHan"].Value.ToString(), out DateTime th))
                {
                    dateTime_TH.Value = th;
                }
            }
        }

        private void Chung_chi_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_show();
        }
    }
}
