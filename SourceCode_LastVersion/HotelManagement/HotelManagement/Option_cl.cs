﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Option_cl : Form
    {
        public Option_cl()
        {
            InitializeComponent();
        }
        

        private void Option_cl_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TimKiemKhachSan_Click(object sender, EventArgs e)
        {
            HotelSearching search = new HotelSearching();
            search.Show();
            this.Hide();
        }

        private void DatPhongKhachSan_Click(object sender, EventArgs e)
        {

        }


        private void usernamelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void dangxuatlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new MainMenu().Show();
        }
    }
}
