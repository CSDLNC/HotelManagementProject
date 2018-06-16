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
using System.Configuration;
namespace HotelManagement
{
    public partial class InvoiceDetail : Form
    {
        public InvoiceDetail()
        {
            InitializeComponent();
        }

        private void InvoiceDetail_Load(object sender, EventArgs e)
        {
            //tạo kết nối
            string strConn = ConfigurationManager.ConnectionStrings["Demo"].ToString();
            SqlConnection conn = new SqlConnection(strConn);

            // Truy vấn
            string maHD = SelectedMaHD.StrmaHD; //maHD  
            string query = "SELECT maHD, ngayThanhToan, tongTien, maDP FROM HOADON WHERE maHD= " + maHD; //Cau truy van
            conn.Open();
            // Lấy kq
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable ds = new DataTable();
            da.Fill(ds);
            conn.Close();
            // Set vào từng ô chi tiêt hóa đơn
            string SmaHD = ds.Rows[0]["maHD"].ToString();
            mahdtb.Text = SmaHD;
            string SngayTT = ds.Rows[0]["ngayThanhToan"].ToString();
            ngaytttb.Text = SngayTT;
            string StongTien = ds.Rows[0]["tongTien"].ToString();
            tongtientb.Text = StongTien;
            string SmaDP = ds.Rows[0]["maDP"].ToString();
            madptb.Text = SmaDP;

        }
    }
}
