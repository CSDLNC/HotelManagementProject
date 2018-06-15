using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
namespace HotelManagement
{
    class ConnectData
    {
        public static SqlConnection conn;
        public static void Connect()
        {

            try
            {

                string strConn = ConfigurationManager.ConnectionStrings["Demo"].ToString();
                conn = new SqlConnection(strConn);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }

        public static void DisConnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                conn.Dispose();
            }
        }

        public static int ExcuteQuery(string query)
        {
            int result = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
            finally
            {
                DisConnect();
            }
            return result;
        }
        public static int ExcuteProcedure(string query, string user, int numRoom, DateTime checkIn, DateTime checkOut)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@num_Room", numRoom);
                cmd.Parameters.AddWithValue("@check_In", checkIn);
                cmd.Parameters.AddWithValue("@check_Out", checkOut);
                SqlParameter result = new SqlParameter();
                result.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(result);
                cmd.ExecuteNonQuery();
                int returnValue = (int)result.Value;
                return returnValue;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
            finally
            {
                DisConnect();
            }
            return 0;
        }
        public static DataTable LoadData(string strLenh)
        {
            DataTable ds = new DataTable();
            SqlCommand cmd = new SqlCommand(strLenh, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            DisConnect();
            return ds;
        }


    }
}
