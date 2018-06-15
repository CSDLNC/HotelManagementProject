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

namespace HotelManagement
{
    public partial class RoomSetting : Form
    {
        public RoomSetting()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            ConnectData.Connect();
            string sql = "SELECT ks.maKS,ks.tenKS,ks.thanhPho,ks.soSao,ks.giaTB,tt.maPhong,tt.tinhTrang FROM ((KhachSan ks JOIN LoaiPhong lp ON ks.maKS=lp.maKS) JOIN Phong p ON lp.maLoaiPhong=p.LoaiPhong) JOIN TrangThaiPhong tt ON p.maPhong=tt.maPhong";
            DataTable dsKS = new DataTable();
            dsKS = ConnectData.LoadData(string.Format(sql));
            for (int i = 0; i < dsKS.Rows.Count; i++)
                danhsachphongtrong.Rows.Add(dsKS.Rows[i][0], dsKS.Rows[i][1], dsKS.Rows[i][2], dsKS.Rows[i][3], dsKS.Rows[i][4], dsKS.Rows[i][5], dsKS.Rows[i][6]);


        }
        
        private void InsertData(int index)
        {
            ConnectData.Connect();
            //
            string user = "anguyen";
            //string user = usernamelink.Name;
            //
            string numRoom = danhsachphongtrong.Rows[index].Cells[5].Value.ToString();
            int num;
            int.TryParse(numRoom, out num);
            DateTime dateIn = DateTime.Now;
            DateTime dateOut = dateIn.AddDays(3);
            
            string sql = "sp_booking";
            
            int result;
            //+  user +"," + numRoom + "," + checkIn + "," + checkOut + "," + result
            result = ConnectData.ExcuteProcedure(sql, user, num, dateIn, dateOut);
            if (result == 1)
            {
                MessageBox.Show("We're sorry about this !! \n This room is booked. Please try book the another!", "Error");
                danhsachphongtrong.CancelEdit();
            }
            else
            {
                MessageBox.Show("Successfull !!");
                ConnectData.Connect();
                Application.Restart();
            }
        }
        private void danhsachphongtrong_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            var result = MessageBox.Show("Are you really agree book room?", "Warning !!!", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                sender = danhsachphongtrong.CancelEdit();
            }
            else
            {
                int rowIndex = -1;
                foreach (DataGridViewRow row in danhsachphongtrong.Rows)
                {
                    if (row.Cells[7].Selected == true)
                    {
                        rowIndex = row.Cells[7].RowIndex;
                        InsertData(rowIndex);
                        break;
                    }
                }

                
            }
           
        }

        private void QuayLaicl_Option_Click(object sender, EventArgs e)
        {
            HotelSearching search = new HotelSearching();
            search.Show();
            this.Hide();
        }

        private void usernamelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void dangxuatlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

    }
}
