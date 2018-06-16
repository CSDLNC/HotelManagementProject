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
    public static class SelectedMaHD
    {
        public static string StrmaHD { get; set; }
    }
    public partial class InvoiceSearching : Form
    {
        public string smaHD;
        public InvoiceSearching()
        {
            InitializeComponent();
        }
        private void loadMaKH(SqlConnection conn)
        {
            // Load ma KH
            string query = "SELECT maKH FROM KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "maKH");
            makhcbb.DisplayMember = "maKH";
            makhcbb.DataSource = ds.Tables["maKH"];
        }
        private void InvoiceSearching_Load(object sender, EventArgs e)
        {
            // tao chuoi ket noi
            string strConn = ConfigurationManager.ConnectionStrings["Demo"].ToString();
            SqlConnection conn = new SqlConnection(strConn);

            using (conn)
            {
                try
                {
                    conn.Open(); // mo ket noi
                    // Load Lua chon MaKH can tim trong combo box
                    loadMaKH(conn);
                    conn.Close(); // dong ket noi
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void TimKiemHoaDon_Option_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = ConfigurationManager.ConnectionStrings["Demo"].ToString();
                SqlConnection conn = new SqlConnection(strConn);
                // kết nối
                conn.Open();

                String procname = "SP_SearchBill";
                SqlDataAdapter adapter = new SqlDataAdapter(procname, conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                //Truyền tham số 
                //Ma KH
                if (makhcbb.Text != "") //kiem tra <> NULL
                    adapter.SelectCommand.Parameters.Add("@ConsID", SqlDbType.Int).Value = Int32.Parse(makhcbb.Text);
                else
                    adapter.SelectCommand.Parameters.Add("@ConsID", SqlDbType.Int).Value = DBNull.Value;
                // Ngay
                if (ngayttcb.Checked == true) // Co tim theo ngay
                    adapter.SelectCommand.Parameters.Add("@Day", SqlDbType.DateTime).Value = DateTime.Parse(ngaythanhtoandt.Value.ToShortDateString());
                else
                    adapter.SelectCommand.Parameters.Add("@Day", SqlDbType.DateTime).Value = DBNull.Value;
                // Tien
                if (tientucbb.Text != "")
                    adapter.SelectCommand.Parameters.Add("@minTotal", SqlDbType.Money).Value = Int32.Parse(tientucbb.Text);
                else
                    adapter.SelectCommand.Parameters.Add("@minTotal", SqlDbType.Money).Value = DBNull.Value;

                if (dentiencbb.Text != "")
                    adapter.SelectCommand.Parameters.Add("@maxTotal", SqlDbType.Money).Value = Int32.Parse(dentiencbb.Text);
                else
                    adapter.SelectCommand.Parameters.Add("@maxTotal", SqlDbType.Money).Value = DBNull.Value;

                //load dữ liệu lên datagridview
                DataTable table = new DataTable();
                adapter.Fill(table);
                danhsachtimhoadon.DataSource = table;

            }
            catch (Exception ex)
            {
                throw ex;
                //          MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void ngaythanhtoandt_ValueChanged(object sender, EventArgs e)
        {
            ngaythanhtoandt.Format = DateTimePickerFormat.Short;
        }


        private void danhsachtimhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy mã HD đang chọn
            SelectedMaHD.StrmaHD = danhsachtimhoadon.Rows[e.RowIndex].Cells[1].Value.ToString();
            // mở form Chi tiết
            new InvoiceDetail().Show();

        }

    }

}
