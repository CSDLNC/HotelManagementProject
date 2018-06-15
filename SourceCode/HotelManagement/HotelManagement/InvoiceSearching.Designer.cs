namespace HotelManagement
{
    partial class InvoiceSearching
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timkiemhoadonggb = new System.Windows.Forms.GroupBox();
            this.ngayttcb = new System.Windows.Forms.CheckBox();
            this.ngaythanhtoandt = new System.Windows.Forms.DateTimePicker();
            this.tientucbb = new System.Windows.Forms.ComboBox();
            this.tientulb = new System.Windows.Forms.Label();
            this.dentiencbb = new System.Windows.Forms.ComboBox();
            this.dentienlb = new System.Windows.Forms.Label();
            this.TimKiemHoaDon_Option = new System.Windows.Forms.Button();
            this.makhcbb = new System.Windows.Forms.ComboBox();
            this.makhlb = new System.Windows.Forms.Label();
            this.ngaythanhtoanlb = new System.Windows.Forms.Label();
            this.danhsachtimhoadon = new System.Windows.Forms.DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTietHD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.danhsachtimhoadonggb = new System.Windows.Forms.GroupBox();
            this.QuayLaisv_Option = new System.Windows.Forms.Button();
            this.timkiemhoadonggb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachtimhoadon)).BeginInit();
            this.danhsachtimhoadonggb.SuspendLayout();
            this.SuspendLayout();
            // 
            // timkiemhoadonggb
            // 
            this.timkiemhoadonggb.Controls.Add(this.ngayttcb);
            this.timkiemhoadonggb.Controls.Add(this.ngaythanhtoandt);
            this.timkiemhoadonggb.Controls.Add(this.tientucbb);
            this.timkiemhoadonggb.Controls.Add(this.tientulb);
            this.timkiemhoadonggb.Controls.Add(this.dentiencbb);
            this.timkiemhoadonggb.Controls.Add(this.dentienlb);
            this.timkiemhoadonggb.Controls.Add(this.TimKiemHoaDon_Option);
            this.timkiemhoadonggb.Controls.Add(this.makhcbb);
            this.timkiemhoadonggb.Controls.Add(this.makhlb);
            this.timkiemhoadonggb.Controls.Add(this.ngaythanhtoanlb);
            this.timkiemhoadonggb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiemhoadonggb.Location = new System.Drawing.Point(44, 43);
            this.timkiemhoadonggb.Name = "timkiemhoadonggb";
            this.timkiemhoadonggb.Size = new System.Drawing.Size(829, 105);
            this.timkiemhoadonggb.TabIndex = 27;
            this.timkiemhoadonggb.TabStop = false;
            this.timkiemhoadonggb.Text = "TÌM KIẾM HÓA ĐƠN";
            // 
            // ngayttcb
            // 
            this.ngayttcb.AutoSize = true;
            this.ngayttcb.Location = new System.Drawing.Point(640, 65);
            this.ngayttcb.Name = "ngayttcb";
            this.ngayttcb.Size = new System.Drawing.Size(15, 14);
            this.ngayttcb.TabIndex = 24;
            this.ngayttcb.UseVisualStyleBackColor = true;
            // 
            // ngaythanhtoandt
            // 
            this.ngaythanhtoandt.CustomFormat = " ";
            this.ngaythanhtoandt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaythanhtoandt.Location = new System.Drawing.Point(468, 59);
            this.ngaythanhtoandt.Name = "ngaythanhtoandt";
            this.ngaythanhtoandt.Size = new System.Drawing.Size(220, 26);
            this.ngaythanhtoandt.TabIndex = 23;
            this.ngaythanhtoandt.ValueChanged += new System.EventHandler(this.ngaythanhtoandt_ValueChanged);
            // 
            // tientucbb
            // 
            this.tientucbb.FormattingEnabled = true;
            this.tientucbb.Items.AddRange(new object[] {
            "0",
            "500000",
            "1000000",
            "1500000",
            "2000000",
            "2500000",
            "3000000"});
            this.tientucbb.Location = new System.Drawing.Point(168, 59);
            this.tientucbb.Name = "tientucbb";
            this.tientucbb.Size = new System.Drawing.Size(130, 26);
            this.tientucbb.TabIndex = 13;
            // 
            // tientulb
            // 
            this.tientulb.AutoSize = true;
            this.tientulb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tientulb.Location = new System.Drawing.Point(165, 39);
            this.tientulb.Name = "tientulb";
            this.tientulb.Size = new System.Drawing.Size(52, 18);
            this.tientulb.TabIndex = 14;
            this.tientulb.Text = "Giá từ";
            // 
            // dentiencbb
            // 
            this.dentiencbb.FormattingEnabled = true;
            this.dentiencbb.Items.AddRange(new object[] {
            "0",
            "1000000",
            "1500000",
            "2000000",
            "2500000",
            "3000000",
            "3500000",
            "4000000"});
            this.dentiencbb.Location = new System.Drawing.Point(318, 59);
            this.dentiencbb.Name = "dentiencbb";
            this.dentiencbb.Size = new System.Drawing.Size(130, 26);
            this.dentiencbb.TabIndex = 15;
            // 
            // dentienlb
            // 
            this.dentienlb.AutoSize = true;
            this.dentienlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dentienlb.Location = new System.Drawing.Point(315, 39);
            this.dentienlb.Name = "dentienlb";
            this.dentienlb.Size = new System.Drawing.Size(37, 18);
            this.dentienlb.TabIndex = 16;
            this.dentienlb.Text = "Đến";
            // 
            // TimKiemHoaDon_Option
            // 
            this.TimKiemHoaDon_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.TimKiemHoaDon_Option.FlatAppearance.BorderSize = 0;
            this.TimKiemHoaDon_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.TimKiemHoaDon_Option.ForeColor = System.Drawing.Color.White;
            this.TimKiemHoaDon_Option.Location = new System.Drawing.Point(711, 56);
            this.TimKiemHoaDon_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TimKiemHoaDon_Option.Name = "TimKiemHoaDon_Option";
            this.TimKiemHoaDon_Option.Size = new System.Drawing.Size(100, 30);
            this.TimKiemHoaDon_Option.TabIndex = 22;
            this.TimKiemHoaDon_Option.Text = "Tìm Kiếm";
            this.TimKiemHoaDon_Option.UseVisualStyleBackColor = false;
            this.TimKiemHoaDon_Option.Click += new System.EventHandler(this.TimKiemHoaDon_Option_Click);
            // 
            // makhcbb
            // 
            this.makhcbb.FormattingEnabled = true;
            this.makhcbb.Location = new System.Drawing.Point(18, 59);
            this.makhcbb.Name = "makhcbb";
            this.makhcbb.Size = new System.Drawing.Size(130, 26);
            this.makhcbb.TabIndex = 17;
            // 
            // makhlb
            // 
            this.makhlb.AutoSize = true;
            this.makhlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makhlb.Location = new System.Drawing.Point(15, 39);
            this.makhlb.Name = "makhlb";
            this.makhlb.Size = new System.Drawing.Size(113, 18);
            this.makhlb.TabIndex = 18;
            this.makhlb.Text = "Mã khách hàng";
            // 
            // ngaythanhtoanlb
            // 
            this.ngaythanhtoanlb.AutoSize = true;
            this.ngaythanhtoanlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaythanhtoanlb.Location = new System.Drawing.Point(465, 39);
            this.ngaythanhtoanlb.Name = "ngaythanhtoanlb";
            this.ngaythanhtoanlb.Size = new System.Drawing.Size(119, 18);
            this.ngaythanhtoanlb.TabIndex = 20;
            this.ngaythanhtoanlb.Text = "Ngày thanh toán";
            // 
            // danhsachtimhoadon
            // 
            this.danhsachtimhoadon.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.danhsachtimhoadon.ColumnHeadersHeight = 30;
            this.danhsachtimhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.ngayThanhToan,
            this.tongTien,
            this.ChiTietHD});
            this.danhsachtimhoadon.Location = new System.Drawing.Point(54, 52);
            this.danhsachtimhoadon.Name = "danhsachtimhoadon";
            this.danhsachtimhoadon.RowHeadersWidth = 90;
            this.danhsachtimhoadon.Size = new System.Drawing.Size(994, 369);
            this.danhsachtimhoadon.TabIndex = 0;
            this.danhsachtimhoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachtimhoadon_CellContentClick);
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "maHD";
            this.maHD.Frozen = true;
            this.maHD.HeaderText = "Mã hóa đơn";
            this.maHD.Name = "maHD";
            this.maHD.Width = 200;
            // 
            // ngayThanhToan
            // 
            this.ngayThanhToan.DataPropertyName = "ngayThanhToan";
            this.ngayThanhToan.Frozen = true;
            this.ngayThanhToan.HeaderText = "Ngày thanh toán";
            this.ngayThanhToan.Name = "ngayThanhToan";
            this.ngayThanhToan.Width = 300;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongTien";
            this.tongTien.Frozen = true;
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.Name = "tongTien";
            this.tongTien.Width = 300;
            // 
            // ChiTietHD
            // 
            this.ChiTietHD.HeaderText = "Chi Tiết";
            this.ChiTietHD.Name = "ChiTietHD";
            // 
            // danhsachtimhoadonggb
            // 
            this.danhsachtimhoadonggb.Controls.Add(this.danhsachtimhoadon);
            this.danhsachtimhoadonggb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachtimhoadonggb.Location = new System.Drawing.Point(44, 172);
            this.danhsachtimhoadonggb.Name = "danhsachtimhoadonggb";
            this.danhsachtimhoadonggb.Size = new System.Drawing.Size(1203, 495);
            this.danhsachtimhoadonggb.TabIndex = 28;
            this.danhsachtimhoadonggb.TabStop = false;
            this.danhsachtimhoadonggb.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // QuayLaisv_Option
            // 
            this.QuayLaisv_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(149)))));
            this.QuayLaisv_Option.FlatAppearance.BorderSize = 0;
            this.QuayLaisv_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.QuayLaisv_Option.ForeColor = System.Drawing.Color.White;
            this.QuayLaisv_Option.Location = new System.Drawing.Point(1147, 118);
            this.QuayLaisv_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.QuayLaisv_Option.Name = "QuayLaisv_Option";
            this.QuayLaisv_Option.Size = new System.Drawing.Size(100, 30);
            this.QuayLaisv_Option.TabIndex = 29;
            this.QuayLaisv_Option.Text = "Quay Lại";
            this.QuayLaisv_Option.UseVisualStyleBackColor = false;
            // 
            // InvoiceSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1301, 700);
            this.Controls.Add(this.QuayLaisv_Option);
            this.Controls.Add(this.danhsachtimhoadonggb);
            this.Controls.Add(this.timkiemhoadonggb);
            this.Name = "InvoiceSearching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceSearching";
            this.Load += new System.EventHandler(this.InvoiceSearching_Load);
            this.timkiemhoadonggb.ResumeLayout(false);
            this.timkiemhoadonggb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachtimhoadon)).EndInit();
            this.danhsachtimhoadonggb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox timkiemhoadonggb;
        private System.Windows.Forms.Label tientulb;
        private System.Windows.Forms.ComboBox dentiencbb;
        private System.Windows.Forms.Label dentienlb;
        private System.Windows.Forms.Button TimKiemHoaDon_Option;
        private System.Windows.Forms.ComboBox makhcbb;
        private System.Windows.Forms.Label makhlb;
        private System.Windows.Forms.Label ngaythanhtoanlb;
        private System.Windows.Forms.ComboBox tientucbb;
        private System.Windows.Forms.DateTimePicker ngaythanhtoandt;
        private System.Windows.Forms.DataGridView danhsachtimhoadon;
        private System.Windows.Forms.GroupBox danhsachtimhoadonggb;
        private System.Windows.Forms.Button QuayLaisv_Option;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.DataGridViewButtonColumn ChiTietHD;
        private System.Windows.Forms.CheckBox ngayttcb;
    }
}