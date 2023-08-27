using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_Tập_Lớn_MNM.Backend
{
    public class Dang_Nhap_DAO
    {
        private Dang_Nhap_DAO() { }
        private static Dang_Nhap_DAO instance;

        public static Dang_Nhap_DAO Instance { 
            get => instance ?? (instance = new Dang_Nhap_DAO()); 
            private set => instance = value; 
        }
        public int phanquyen = 0;
        public void get_type(int mnv)
        {
            databasecontrol databasecontrol = new databasecontrol();
            string query = "select phanquyen from TaiKhoan where MNV = @MNV ";
            object result = databasecontrol.ExecuteScalar(query, new object[] { mnv });
            if (result != null)
            {
                result = result.ToString();
                result.ToString();
            }
            phanquyen = Convert.ToInt32(result);
        }
    }
}
