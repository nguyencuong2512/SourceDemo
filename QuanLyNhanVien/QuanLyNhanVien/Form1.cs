using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using APP;
using DAO;
using DTO;
using BUS;
namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NhanVienBUS bus;
        NhanVienDTO info;
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "Data Source=NGUYENCUONG; Initial Catalog =QuanLyNhanVien; Integrated Security =SSPI";
          //string sql = "Data Source=NGUYENCUONG; Initial Catalog =QuanLyNhanVien; Integrated Security =SSPI";
            DataProvider.Connectionstring1 = sql;
            DataTable tb = new DataTable();
            bus = new NhanVienBUS();
            tb = bus.ListNV();
            dataGridView1.DataSource = tb;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            info = new NhanVienDTO();
            bus = new NhanVienBUS();
            DataTable tb = new DataTable();
            string manv;
            int chiso = -1;
            chiso = dataGridView1.SelectedCells[0].RowIndex;
            tb = (DataTable)dataGridView1.DataSource;
            manv = (string)tb.Rows[chiso].ItemArray[0];
            try
            {
                bus.deleteNV(manv);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tb = bus.ListNV();
            dataGridView1.DataSource = tb;
        }
    }
}
