using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        //Sting maso
        string maSo;

        public string MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }
        string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        string noiSinh;

        public string NoiSinh
        {
            get { return noiSinh; }
            set { noiSinh = value; }
        }
    }
}
