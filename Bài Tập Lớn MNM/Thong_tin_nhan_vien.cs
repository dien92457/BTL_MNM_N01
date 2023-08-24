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
    public partial class Thong_tin_nhan_vien : Form
    {
        public Thong_tin_nhan_vien()
        {
            InitializeComponent();
        }
        public void data_show()
        {
            databasecontrol dataprovide = new databasecontrol();
            String stm = "SELECT * FROM NhanVien";
            dataGridView1.DataSource = dataprovide.ExecuteQuery(stm);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

     

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     
        private void BTN_INSERT_Click(object sender, EventArgs e)
        {
            String ten = txt_Ten.Text;
            int id = Convert.ToInt32(txt_MNV.Text);
            String gioitinh = txt_GT.Text;
            DateTime ngaySinh = dateTime_NS.Value;
            String CCCD = txt_CCCD.Text;
            String DT = txt_SDT.Text;
            String chucvu = txt_CV.Text;
            String thanhpho = txt_TP.Text;
            String huyen = txt_Huyen.Text;
            String xa = txt_Xa.Text;
            databasecontrol dataprovide = new databasecontrol();
            string query = "INSERT INTO NhanVien ( MaNhanVien , HoTen , GioiTinh , NgaySinh , SoCCCD, SoDienThoai , ChucVu , ThanhPho , Huyen , Xa) VALUES ( @id , @ten , @gioitinh , @ngaySinh , @CCCD , @DT , @chucvu , @thanhpho , @huyen , @xa );";
            dataprovide.ExecuteNonQuery(query, new object[] { id, ten, gioitinh, ngaySinh, CCCD, DT, chucvu, thanhpho, huyen, xa });
            this.data_show();
        }

        private void BTN_reset_Click(object sender, EventArgs e)
        {
            txt_Ten.Clear();
            txt_MNV.Clear();
            txt_GT.Clear();
            dateTime_NS.Value = DateTime.Now; // Đặt giá trị mặc định cho DatePicker
            txt_CCCD.Clear();
            txt_SDT.Clear();
            txt_CV.Clear();
            txt_TP.Clear();
            txt_Huyen.Clear();
            txt_Xa.Clear();
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
                string query = "DELETE FROM NhanVien WHERE MaNhanVien = @id";
                databaseControl.ExecuteNonQuery(query, new object[] { id });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txt_MNV.Text = selectedRow.Cells["MaNhanVien"].Value.ToString();
                txt_Ten.Text = selectedRow.Cells["HoTen"].Value.ToString();
                txt_GT.Text = selectedRow.Cells["GioiTinh"].Value.ToString();
                // và tiếp tục gán dữ liệu cho các TextBox khác tương ứng với cột trong bảng

                // Gán ngày sinh từ cột NgaySinh, giả sử NgaySinh nằm trong cột thứ 3
                if (DateTime.TryParse(selectedRow.Cells["NgaySinh"].Value.ToString(), out DateTime ngaySinh))
                {
                    dateTime_NS.Value = ngaySinh;
                }

                txt_CCCD.Text = selectedRow.Cells["SoCCCD"].Value.ToString();
                txt_SDT.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                txt_CV.Text = selectedRow.Cells["ChucVu"].Value.ToString();
                txt_TP.Text = selectedRow.Cells["ThanhPho"].Value.ToString();
                txt_Huyen.Text = selectedRow.Cells["Huyen"].Value.ToString();
                txt_Xa.Text = selectedRow.Cells["Xa"].Value.ToString();
            }
        }

        private void BTN_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_MNV.Text);
            String ten = txt_Ten.Text;
            String gioitinh = txt_GT.Text;
            DateTime ngaySinh = dateTime_NS.Value;
            String CCCD = txt_CCCD.Text;
            String DT = txt_SDT.Text;
            String chucvu = txt_CV.Text;
            String thanhpho = txt_TP.Text;
            String huyen = txt_Huyen.Text;
            String xa = txt_Xa.Text;

            UpdateData(id, ten, gioitinh, ngaySinh, CCCD, DT, chucvu, thanhpho, huyen, xa);
            data_show(); 
        }
        private void UpdateData(int id, string ten, string gioitinh, DateTime ngaySinh, string CCCD, string DT, string chucvu, string thanhpho, string huyen, string xa)
        {
            try
            {
                databasecontrol databaseControl = new databasecontrol();
                string query = "UPDATE NhanVien SET HoTen = @ten , GioiTinh = @gioitinh , NgaySinh = @ngaySinh , SoCCCD = @CCCD , SoDienThoai = @DT , ChucVu = @chucvu , ThanhPho = @thanhpho , Huyen = @huyen , Xa = @xa WHERE MaNhanVien = @id";
                databaseControl.ExecuteNonQuery(query, new object[] { ten , gioitinh , ngaySinh , CCCD , DT , chucvu , thanhpho , huyen , xa , id  });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
