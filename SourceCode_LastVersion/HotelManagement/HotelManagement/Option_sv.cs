using System;
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
    public partial class Option_sv : Form
    {
        public Option_sv()
        {
            InitializeComponent();
        }

        private void TimKiemHoaDon_Click(object sender, EventArgs e)
        {
            InvoiceSearching search = new InvoiceSearching();
            search.Show();
            this.Hide();
        }

        private void QuanLyHoaDon_Click(object sender, EventArgs e)
        {
            InvoiceAdding add = new InvoiceAdding();
            add.Show();
            this.Hide();
        }

        private void QuanLyBaoCao_Click(object sender, EventArgs e)
        {
            Report re = new Report();
            re.Show();
            this.Hide();
        }

        private void QuanLyThongKe_Click(object sender, EventArgs e)
        {
            Statistic st = new Statistic();
            st.Show();
            this.Hide();
        }
    }
}
