using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace HotelManagement
{
    public partial class HotelSearching : Form
    {
        public HotelSearching()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimTheoTP_Option_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);


            connection.Open();

            SqlCommand cmd_tp = new SqlCommand();
            cmd_tp.CommandType = CommandType.StoredProcedure;
            cmd_tp.Connection = connection;
            cmd_tp.CommandText = "SP_SearchHotelByCity";

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd_tp.Parameters.Add("@City", SqlDbType.NVarChar, 30).Value = Convert.ToString(thanhphotb.Text);


            SqlDataReader dtReader = cmd_tp.ExecuteReader();
            dt.Load(dtReader);

            ////
            //dt.Columns.Add("Mã khách sạn", typeof(String));
            //dt.Columns.Add("Tên khách sạn", typeof(String));
            //dt.Columns.Add("Số sao", typeof(Int32));
            //dt.Columns.Add("Số nhà", typeof(Int32));
            //dt.Columns.Add("Đường", typeof(String));
            //dt.Columns.Add("Quận", typeof(String));
            //dt.Columns.Add("Thành Phố", typeof(String));
            //dt.Columns.Add("Giá cả", typeof(SqlMoney));
            //dt.Columns.Add("Mô tả", typeof(String));
            //DataRow row = null;
            ////
            //while (dtReader.Read())
            //{
            //    row = dt.NewRow();
            //    row["Mã khách sạn"] = dtReader["maKS"];
            //    row["Tên khách sạn"] = dtReader["tenKS"];
            //    row["Số sao"] = dtReader["soSao"];
            //    row["Số nhà"] = dtReader["soNha"];
            //    row["Đường"] = dtReader["duong"];
            //    row["Quận"] = dtReader["quan"];
            //    row["Thành Phố"] = dtReader["thanhPho"];
            //    row["Giá cả"] = dtReader["giaTB"];
            //    row["Mô tả"] = dtReader["moTa"];
            //    dt.Rows.Add(row);
            //}
            //dtReader.Close();

            ////danhsachkhachsan.DataSource = dt;
            ////


            if (dt.Rows.Count > 0)
            {
                danhsachkhachsan.DataSource = dt;
            }

            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách sạn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            connection.Dispose();

            //danhsachkhachsan.Columns[0].Width = 150;
            //danhsachkhachsan.Columns[1].Width = 200;
            //danhsachkhachsan.Columns[2].Width = 150;
            //danhsachkhachsan.Columns[3].Width = 150;
            //danhsachkhachsan.Columns[4].Width = 150;
            //danhsachkhachsan.Columns[5].Width = 200;
            //danhsachkhachsan.Columns[6].Width = 150;
            //danhsachkhachsan.Columns[7].Width = 150;
            //danhsachkhachsan.Columns[8].Width = 150;
        }

        private void TimTheoTPHS_Option_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);


            connection.Open();

            SqlCommand cmd_tp_hs = new SqlCommand();
            cmd_tp_hs.CommandType = CommandType.StoredProcedure;
            cmd_tp_hs.Connection = connection;
            cmd_tp_hs.CommandText = "SP_SearchHotelByCity_voteStar";

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd_tp_hs.Parameters.Add("@City", SqlDbType.NVarChar, 30).Value = Convert.ToString(thanhphotb.Text);
            cmd_tp_hs.Parameters.Add("@voteStar", SqlDbType.Int).Value = Convert.ToString(hangsaotb.Text);


            SqlDataReader dtReader = cmd_tp_hs.ExecuteReader();
            dt.Load(dtReader);

            ////
            //dt.Columns.Add("Mã khách sạn", typeof(String));
            //dt.Columns.Add("Tên khách sạn", typeof(String));
            //dt.Columns.Add("Số sao", typeof(Int32));
            //dt.Columns.Add("Số nhà", typeof(Int32));
            //dt.Columns.Add("Đường", typeof(String));
            //dt.Columns.Add("Quận", typeof(String));
            //dt.Columns.Add("Thành Phố", typeof(String));
            //dt.Columns.Add("Giá cả", typeof(SqlMoney));
            //dt.Columns.Add("Mô tả", typeof(String));
            //DataRow row = null;
            ////
            //while (dtReader.Read())
            //{
            //    row = dt.NewRow();
            //    row["Mã khách sạn"] = dtReader["maKS"];
            //    row["Tên khách sạn"] = dtReader["tenKS"];
            //    row["Số sao"] = dtReader["soSao"];
            //    row["Số nhà"] = dtReader["soNha"];
            //    row["Đường"] = dtReader["duong"];
            //    row["Quận"] = dtReader["quan"];
            //    row["Thành Phố"] = dtReader["thanhPho"];
            //    row["Giá cả"] = dtReader["giaTB"];
            //    row["Mô tả"] = dtReader["moTa"];
            //    dt.Rows.Add(row);
            //}
            //dtReader.Close();

            ////danhsachkhachsan.DataSource = dt;
            ////


            if (dt.Rows.Count > 0)
            {
                danhsachkhachsan.DataSource = dt;
            }

            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách sạn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            connection.Dispose();

            //danhsachkhachsan.Columns[0].Width = 150;
            //danhsachkhachsan.Columns[1].Width = 200;
            //danhsachkhachsan.Columns[2].Width = 150;
            //danhsachkhachsan.Columns[3].Width = 150;
            //danhsachkhachsan.Columns[4].Width = 150;
            //danhsachkhachsan.Columns[5].Width = 200;
            //danhsachkhachsan.Columns[6].Width = 150;
            //danhsachkhachsan.Columns[7].Width = 150;
            //danhsachkhachsan.Columns[8].Width = 150;
        }

        private void TimTheoTPGC_Option_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Demo"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);


            connection.Open();

            SqlCommand cmd_tp_gc = new SqlCommand();
            cmd_tp_gc.CommandType = CommandType.StoredProcedure;
            cmd_tp_gc.Connection = connection;
            cmd_tp_gc.CommandText = "SP_SearchHotelByCity_Price";

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cmd_tp_gc.Parameters.Add("@City", SqlDbType.NVarChar, 30).Value = Convert.ToString(thanhphotb.Text);
            cmd_tp_gc.Parameters.Add("@Price", SqlDbType.Money).Value = Convert.ToString(giatbtb.Text);


            SqlDataReader dtReader = cmd_tp_gc.ExecuteReader();
            dt.Load(dtReader);

            ////
            //dt.Columns.Add("Mã khách sạn", typeof(String));
            //dt.Columns.Add("Tên khách sạn", typeof(String));
            //dt.Columns.Add("Số sao", typeof(Int32));
            //dt.Columns.Add("Số nhà", typeof(Int32));
            //dt.Columns.Add("Đường", typeof(String));
            //dt.Columns.Add("Quận", typeof(String));
            //dt.Columns.Add("Thành Phố", typeof(String));
            //dt.Columns.Add("Giá cả", typeof(SqlMoney));
            //dt.Columns.Add("Mô tả", typeof(String));
            //DataRow row = null;
            ////
            //while (dtReader.Read())
            //{
            //    row = dt.NewRow();
            //    row["Mã khách sạn"] = dtReader["maKS"];
            //    row["Tên khách sạn"] = dtReader["tenKS"];
            //    row["Số sao"] = dtReader["soSao"];
            //    row["Số nhà"] = dtReader["soNha"];
            //    row["Đường"] = dtReader["duong"];
            //    row["Quận"] = dtReader["quan"];
            //    row["Thành Phố"] = dtReader["thanhPho"];
            //    row["Giá cả"] = dtReader["giaTB"];
            //    row["Mô tả"] = dtReader["moTa"];
            //    dt.Rows.Add(row);
            //}
            //dtReader.Close();

            ////danhsachkhachsan.DataSource = dt;
            ////


            if (dt.Rows.Count > 0)
            {
                danhsachkhachsan.DataSource = dt;
            }

            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách sạn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            connection.Dispose();

            //danhsachkhachsan.Columns[0].Width = 150;
            //danhsachkhachsan.Columns[1].Width = 200;
            //danhsachkhachsan.Columns[2].Width = 150;
            //danhsachkhachsan.Columns[3].Width = 150;
            //danhsachkhachsan.Columns[4].Width = 150;
            //danhsachkhachsan.Columns[5].Width = 200;
            //danhsachkhachsan.Columns[6].Width = 150;
            //danhsachkhachsan.Columns[7].Width = 150;
            //danhsachkhachsan.Columns[8].Width = 150;
        }

        private void DatPhongKhachSan_Option_Click(object sender, EventArgs e)
        {
            RoomSetting book = new RoomSetting();
            book.Show();
            this.Hide();
        }

        private void QuayLaicl_Option_Click(object sender, EventArgs e)
        {
            Option_cl option = new Option_cl();
            option.Show();
            this.Hide();
        }
    }
}
