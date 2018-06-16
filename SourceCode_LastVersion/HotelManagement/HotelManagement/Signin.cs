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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();

            HoanTat_Option.Click += new EventHandler(this.HoanTat_Option_Click);
        }

        private void Signin_Load(object sender, EventArgs e)
        {

        }

        private void HoanTat_Option_Click(object sender, EventArgs e)
        {
            string name = hotentb.Text;
            string username = textBox2.Text;
            string pass = matkhautb.Text;
            string repass = nhaplaimatkhautb.Text;
            string cmnd = cmndtb.Text;
            string address = diachitb.Text;
            string phone = sdttb.Text;
            string mail = emailtb.Text;
            string description = motatb.Text;

            if (pass == repass)
            {
                string strConn = ConfigurationManager.ConnectionStrings["Demo"].ToString();
                SqlConnection conn = new SqlConnection(strConn);

                try
                {


                    using (SqlCommand cmd = new SqlCommand("SP_RegisterAccount", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = name;
                        cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar).Value = username;
                        cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = pass;
                        cmd.Parameters.Add("@soCMND", SqlDbType.VarChar).Value = cmnd;
                        cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = address;
                        cmd.Parameters.Add("@soDienThoai", SqlDbType.VarChar).Value = phone;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = mail;
                        cmd.Parameters.Add("@moTa", SqlDbType.VarChar).Value = description;
                        cmd.Parameters.Add("@RESULT", SqlDbType.TinyInt).Direction = ParameterDirection.Output;

                        conn.Open();

                        cmd.ExecuteNonQuery();
                        string retunvalue = cmd.Parameters["@RESULT"].Value.ToString();

                        switch (retunvalue)
                        {
                            case "0":
                                MessageBox.Show("Bạn Chưa Điền Đầy Đủ Thông Tin Đăng Ký.");
                                break;
                            case "1":
                                MessageBox.Show("Đăng Ký Thành Công.");
                                MainMenu menu = new MainMenu();
                                menu.Show();
                                this.Hide();
                                break;
                            case "2":
                                MessageBox.Show("Tên Đăng Nhập Đã Tồn Tại.");
                                break;
                            case "3":
                                MessageBox.Show("Số CMND Đã Tồn Tại.");
                                break;
                            case "4":
                                MessageBox.Show("Số Điện Thoại Đã Tồn Tại.");
                                break;
                            case "5":
                                MessageBox.Show("Địa Chỉ Email Đã Tồn Tại.");
                                break;

                        }

                    }


                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mật Khẩu Xác Nhận Không Khớp !!!.");
            }

        }

    }
}
