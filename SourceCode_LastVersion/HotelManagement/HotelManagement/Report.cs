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
    public partial class Report : Form
    {
        SqlConnection connection = null;
        SqlCommand command = null;
        public Report()
        {
            //Load += Report_Load;
            InitializeComponent();
            //Tú Anh
            namtb.Enabled = false;
        }


        //kiểm tra chuỗi có phải số
        private void ChonBaoCao_Option_Click(object sender, EventArgs e)
        {
            try
            {
                //B1: tạo đối tưỡng kết nối với cơ sở dữ liệu và mở kết nối
                string strConn = ConfigurationManager.ConnectionStrings["Demo"].ToString();
                SqlConnection connection = new SqlConnection(strConn);
                //connection = new SqlConnection(connectionstring);
                connection.Open();

                //B2: xây dụng câu lệnh sql để thực hiện chức năng mong muốn
                String procname = "SP_RevenueReport ";

                //B3: tạo đối tượng thực thi câu lệnh SQL
                command = new SqlCommand(procname);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                //Truyền tham số vào proc
                command.Parameters.Add("@option", SqlDbType.NVarChar);
                command.Parameters.Add("@hotelname", SqlDbType.NVarChar);
                command.Parameters.Add("@m", SqlDbType.Int);
                command.Parameters.Add("@y", SqlDbType.Int);

                //truyền giá trị cho tham số
                if (thangcb.Checked && !namcb.Checked) //chọn thống kê theo tháng
                    command.Parameters["@option"].Value = "Tháng";
                else if (!thangcb.Checked && namcb.Checked) //chọn thống kê theo năm
                    command.Parameters["@option"].Value = "Năm";
                else if (thangcb.Checked && namcb.Checked) //chọn thóng kê theo tháng và năm
                    command.Parameters["@option"].Value = "Tháng, Năm";

                command.Parameters["@hotelname"].Value = tenkstb.Text;
                if (thangtb.Text != "") //tháng đúng định dạng là số vả khác null
                    command.Parameters["@m"].Value = Int32.Parse(thangtb.Text); //chuyển thàng Int vào truyền vào tham số m
                else //nếu là null
                    command.Parameters["@m"].Value = DBNull.Value; //truyền vào giá trị null

                //kiểm tra đk tháng có nghĩa
                if (thangtb.Text != "" && Int32.Parse(thangtb.Text) > 12)
                {
                    MessageBox.Show("Tháng không hợp lệ!!!");
                    return;
                }
                //tương tự như trên
                if (namtb.Text != "")
                    command.Parameters["@y"].Value = Int32.Parse(namtb.Text);
                else
                    command.Parameters["@y"].Value = DBNull.Value;


                //đưa dữ liệu lên datagridview
                DataTable table = new DataTable();
                table.Columns.Add("Mã khách sạn", typeof(int));
                table.Columns.Add("Tên khách sạn", typeof(String));
                SqlDataReader reader = command.ExecuteReader();
                DataRow row = null;
                //tùy loại thống kê mà có bảng dử liệu trả về khác nhau
                //dựa vào proc đã viết để xét các bảng dữ liệu trả về
                if (thangcb.Checked && !namcb.Checked)
                {
                    table.Columns.Add("Tháng", typeof(int));
                    table.Columns.Add("Doanh thu", typeof(decimal));
                    while (reader.Read())
                    {
                        row = table.NewRow();
                        row["Mã khách sạn"] = reader["maKS"];
                        row["Tên khách sạn"] = reader["tenKS"];
                        row["Tháng"] = reader["Thang"];
                        row["Doanh thu"] = reader["DoanhThu"];
                        table.Rows.Add(row);
                    }
                }
                else if (thangcb.Checked && namcb.Checked)//báo cáo theo tháng, năm
                {
                    table.Columns.Add("Tháng", typeof(int));
                    table.Columns.Add("Năm", typeof(int));
                    table.Columns.Add("Doanh thu", typeof(decimal));
                    while (reader.Read())
                    {
                        row = table.NewRow();
                        row["Mã khách sạn"] = reader["maKS"];
                        row["Tên khách sạn"] = reader["tenKS"];
                        row["Tháng"] = reader["Thang"];
                        row["Năm"] = reader["Nam"];
                        row["Doanh thu"] = reader["DoanhThu"];
                        table.Rows.Add(row);
                    }
                }
                else //báo cáo theo năm
                {
                    table.Columns.Add("Năm", typeof(int));
                    table.Columns.Add("Doanh thu", typeof(decimal));
                    while (reader.Read())
                    {
                        row = table.NewRow();
                        row["Mã khách sạn"] = reader["maKS"];
                        row["Tên khách sạn"] = reader["tenKS"];
                        row["Năm"] = reader["Nam"];
                        row["Doanh thu"] = reader["DoanhThu"];
                        table.Rows.Add(row);
                    }
                }
                reader.Close();
                danhsachbaocao.DataSource = null;
                danhsachbaocao.DataSource = table;

                //thay đổi độ rộng cột
                //MessageBox.Show(danhsachbaocao.Columns.Count.ToString());
                if (danhsachbaocao.Columns.Count == 4)
                {
                    danhsachbaocao.Columns[0].Width = 260;
                    danhsachbaocao.Columns[1].Width = 292;
                    danhsachbaocao.Columns[2].Width = 260;
                    danhsachbaocao.Columns[3].Width = 292;
                }
                else
                {
                    danhsachbaocao.Columns[0].Width = 170;
                    danhsachbaocao.Columns[1].Width = 292;
                    danhsachbaocao.Columns[2].Width = 170;
                    danhsachbaocao.Columns[3].Width = 180;
                    danhsachbaocao.Columns[4].Width = 292;
                }

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

        //chỉ cho phép nhập số vào ô Tháng
        private void thangtb_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        //chỉ cho phép nhập số vào ô Năm
        private void namtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void QuayLaisv_Option_Click(object sender, EventArgs e)
        {

        }

        private void thangcb_CheckedChanged(object sender, EventArgs e)
        {
            if (thangcb.Checked && !namcb.Checked)
            {
                namtb.Text = "";
                namtb.Enabled = false;
            }
            if (!thangcb.Checked && namcb.Checked)
            {
                thangtb.Text = "";
                thangtb.Enabled = false;
            }
            if (thangcb.Checked && namcb.Checked)
            {
                namtb.Enabled = true;
                thangtb.Enabled = true;
            }
            if (!thangcb.Checked && !namcb.Checked)
            {
                namtb.Text = "";
                thangcb.Checked = true;
                namcb.Checked = false;
                namtb.Enabled = false;
                thangtb.Enabled = true;

            }

        }

        private void namcb_CheckedChanged(object sender, EventArgs e)
        {
            if (thangcb.Checked && !namcb.Checked)
            {
                namtb.Text = "";
                namtb.Enabled = false;
            }
            if (!thangcb.Checked && namcb.Checked)
            {
                thangtb.Text = "";
                thangtb.Enabled = false;
            }
            if (thangcb.Checked && namcb.Checked)
            {
                namtb.Enabled = true;
                thangtb.Enabled = true;
            }
            if (!thangcb.Checked && !namcb.Checked)
            {
                namtb.Text = "";
                thangcb.Checked = true;
                namcb.Checked = false;
                namtb.Enabled = false;
                thangtb.Enabled = true;

            }

        }





    }
}

