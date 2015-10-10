using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAO dataaccess = new NhanVienDAO();
        public DataTable ListNV()
        {
            return dataaccess.ListNhanVien();
        }
       public void deleteNV(string ma )
        {
            dataaccess.deleteNhanVien(ma);
        }
    }
}
