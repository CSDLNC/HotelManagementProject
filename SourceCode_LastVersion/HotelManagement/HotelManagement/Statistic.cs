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
    public partial class Statistic : Form
    {
        String connectionstring = ConfigurationManager.ConnectionStrings["Demo"].ToString();
        SqlConnection connection = null;
        SqlCommand command = null;
        public Statistic()
        {
            InitializeComponent();
            //Tú Anh
            connection = new SqlConnection(connectionstring);
        }

        private void ChonThongKe_Option_Click(object sender, EventArgs e)
        {
            try
            {
                //B1: tạo đối tưỡng kết nối với cơ sở dữ liệu và mở kết nối
                connection = new SqlConnection(connectionstring);
                connection.Open();

                //B2: xây dụng câu lệnh sql để thực hiện chức năng mong muốn
                String procname = "SP_EmptyRoomStatistics";

                //B3: tạo đối tượng thực thi câu lệnh SQL
                command = new SqlCommand(procname);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                //Truyền tham số vào proc
                command.Parameters.Add("@hotelname", SqlDbType.NVarChar);
                command.Parameters.Add("@typeofroomname", SqlDbType.NVarChar);
                command.Parameters.Add("@date", SqlDbType.DateTime);
                command.Parameters.Add("@sortoption", SqlDbType.Int);

                //truyền giá trị cho tham số
                command.Parameters["@hotelname"].Value = tenkstb.Text;
                command.Parameters["@typeofroomname"].Value = tenloaiphongtb.Text;
                if (ngaythongkedt.Text == "") //gia1 trị null
                    command.Parameters["@date"].Value = DBNull.Value; //gán gái trị null
                else
                    command.Parameters["@date"].Value = ngaythongkedt.Text;
                if (sosaocb.Checked && tpcb.Checked)  //nếu chọn sắp xếp theo thành phố, số sao
                {
                    command.Parameters["@sortoption"].Value = 2;

                }
                if (!sosaocb.Checked && tpcb.Checked)  //nếu chọn sắp xếp theo thành phố
                {
                    command.Parameters["@sortoption"].Value = 1;

                }
                if (sosaocb.Checked && !tpcb.Checked)  //nếu chọn sắp xếp theo số sao
                {
                    command.Parameters["@sortoption"].Value = 0;
                }
                if (!sosaocb.Checked && !tpcb.Checked)  //không sắp xếp 
                {
                    command.Parameters["@sortoption"].Value = 3;

                }
                //đưa dữ liệu lên datagridview
                DataTable table = new DataTable();
                //thêm các cột vào table
                table.Columns.Add("Mã khách sạn", typeof(int));
                table.Columns.Add("Tên khách sạn", typeof(String));
                table.Columns.Add("Mã loại phòng", typeof(int));
                table.Columns.Add("Tên loại phòng", typeof(String));
                table.Columns.Add("Thành phố", typeof(String));
                table.Columns.Add("Số sao", typeof(int));
                table.Columns.Add("Số phòng trống", typeof(int));
                SqlDataReader reader = command.ExecuteReader();
                DataRow row = null;
                //đọc dữ liệu từng dòng
                while (reader.Read())
                {
                    row = table.NewRow();
                    row["Mã khách sạn"] = reader["maKS"];
                    row["Tên khách sạn"] = reader["tenKS"];
                    row["Mã loại phòng"] = reader["maLoaiPhong"];
                    row["Tên loại phòng"] = reader["tenLoaiPhong"];
                    row["Thành phố"] = reader["thanhPho"];
                    row["Số sao"] = reader["soSao"];
                    row["Số phòng trống"] = reader["soPhongTrong"];
                    table.Rows.Add(row);
                }
                reader.Close();
                danhsachthongke.DataSource = table;

            }
            catch (SqlException ex) //bắt ngoại lệ
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //B5: đóng kết nối
                connection.Close();
            }
        }

        private void QuayLaisv_Option_Click(object sender, EventArgs e)
        {
            Option_sv option = new Option_sv();
            option.Show();
            this.Hide();
        }
    }
}
