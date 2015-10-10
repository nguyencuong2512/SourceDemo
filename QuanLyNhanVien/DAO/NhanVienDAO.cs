using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using APP;
namespace DAO
{
    public class NhanVienDAO
    {
        DataProvider dataprovider = new DataProvider();
        public NhanVienDAO()
        {
            dataprovider.OpenConnec();
        }
        public DataTable ListNhanVien()
        {
            DataTable listNV = new DataTable();
            string sql = "select*from NHANVIEN";
            listNV = dataprovider.executeReader(sql);
            return listNV;

        }
        public void deleteNhanVien(string ma)
        {
            /*
            string sql = "delete from NHANVIEN where [maSo]='" + ma + "'";
            dataprovider.executeNonQuery(sql);
         */
            string sql = "delete from NHANVIEN where [maSo]='" + ma + "'"; 
            dataprovider.executeNonQuery(sql); 
            
        }
    }
}
