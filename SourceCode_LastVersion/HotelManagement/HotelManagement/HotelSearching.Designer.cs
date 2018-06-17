namespace HotelManagement
{
    partial class HotelSearching
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
            this.usernamelink = new System.Windows.Forms.LinkLabel();
            this.giatblb = new System.Windows.Forms.Label();
            this.hangsaolb = new System.Windows.Forms.Label();
            this.thanhpholb = new System.Windows.Forms.Label();
            this.TimTheoTP_Option = new System.Windows.Forms.Button();
            this.QuayLaicl_Option = new System.Windows.Forms.Button();
            this.dangxuatlink = new System.Windows.Forms.LinkLabel();
            this.timkiemkhachsangb = new System.Windows.Forms.GroupBox();
            this.TimTheoTPGC_Option = new System.Windows.Forms.Button();
            this.TimTheoTPHS_Option = new System.Windows.Forms.Button();
            this.hangsaotb = new System.Windows.Forms.TextBox();
            this.giatbtb = new System.Windows.Forms.TextBox();
            this.danhsachkhachsangb = new System.Windows.Forms.GroupBox();
            this.danhsachkhachsan = new System.Windows.Forms.DataGridView();
            this.DatPhongKhachSan_Option = new System.Windows.Forms.Button();
            this.thanhphotb = new System.Windows.Forms.ComboBox();
            this.timkiemkhachsangb.SuspendLayout();
            this.danhsachkhachsangb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachkhachsan)).BeginInit();
            this.SuspendLayout();
            // 
            // usernamelink
            // 
            this.usernamelink.ActiveLinkColor = System.Drawing.Color.Black;
            this.usernamelink.AutoSize = true;
            this.usernamelink.DisabledLinkColor = System.Drawing.Color.Red;
            this.usernamelink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelink.Location = new System.Drawing.Point(1120, 9);
            this.usernamelink.Name = "usernamelink";
            this.usernamelink.Size = new System.Drawing.Size(0, 20);
            this.usernamelink.TabIndex = 12;
            this.usernamelink.Text = Login.username.ToString();
            this.usernamelink.TabStop = true;
            this.usernamelink.VisitedLinkColor = System.Drawing.Color.Red;
            this.usernamelink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usernamelink_LinkClicked);
            // 
            // giatblb
            // 
            this.giatblb.AutoSize = true;
            this.giatblb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giatblb.Location = new System.Drawing.Point(240, 40);
            this.giatblb.Name = "giatblb";
            this.giatblb.Size = new System.Drawing.Size(54, 18);
            this.giatblb.TabIndex = 14;
            this.giatblb.Text = "Giá cả";
            // 
            // hangsaolb
            // 
            this.hangsaolb.AutoSize = true;
            this.hangsaolb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hangsaolb.Location = new System.Drawing.Point(123, 39);
            this.hangsaolb.Name = "hangsaolb";
            this.hangsaolb.Size = new System.Drawing.Size(75, 18);
            this.hangsaolb.TabIndex = 18;
            this.hangsaolb.Text = "Hạng sao";
            // 
            // thanhpholb
            // 
            this.thanhpholb.AutoSize = true;
            this.thanhpholb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhpholb.Location = new System.Drawing.Point(8, 39);
            this.thanhpholb.Name = "thanhpholb";
            this.thanhpholb.Size = new System.Drawing.Size(80, 18);
            this.thanhpholb.TabIndex = 20;
            this.thanhpholb.Text = "Thành phố";
            // 
            // TimTheoTP_Option
            // 
            this.TimTheoTP_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.TimTheoTP_Option.FlatAppearance.BorderSize = 0;
            this.TimTheoTP_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.TimTheoTP_Option.ForeColor = System.Drawing.Color.White;
            this.TimTheoTP_Option.Location = new System.Drawing.Point(681, 24);
            this.TimTheoTP_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TimTheoTP_Option.Name = "TimTheoTP_Option";
            this.TimTheoTP_Option.Size = new System.Drawing.Size(201, 30);
            this.TimTheoTP_Option.TabIndex = 22;
            this.TimTheoTP_Option.Text = "Tìm Theo Thành Phố";
            this.TimTheoTP_Option.UseVisualStyleBackColor = false;
            this.TimTheoTP_Option.Click += new System.EventHandler(this.TimTheoTP_Option_Click);
            // 
            // QuayLaicl_Option
            // 
            this.QuayLaicl_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(149)))));
            this.QuayLaicl_Option.FlatAppearance.BorderSize = 0;
            this.QuayLaicl_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.QuayLaicl_Option.ForeColor = System.Drawing.Color.White;
            this.QuayLaicl_Option.Location = new System.Drawing.Point(1147, 118);
            this.QuayLaicl_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.QuayLaicl_Option.Name = "QuayLaicl_Option";
            this.QuayLaicl_Option.Size = new System.Drawing.Size(100, 30);
            this.QuayLaicl_Option.TabIndex = 23;
            this.QuayLaicl_Option.Text = "Quay Lại";
            this.QuayLaicl_Option.UseVisualStyleBackColor = false;
            this.QuayLaicl_Option.Click += new System.EventHandler(this.QuayLaicl_Option_Click);
            // 
            // dangxuatlink
            // 
            this.dangxuatlink.ActiveLinkColor = System.Drawing.Color.Black;
            this.dangxuatlink.AutoSize = true;
            this.dangxuatlink.DisabledLinkColor = System.Drawing.Color.Red;
            this.dangxuatlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangxuatlink.Location = new System.Drawing.Point(1206, 9);
            this.dangxuatlink.Name = "dangxuatlink";
            this.dangxuatlink.Size = new System.Drawing.Size(82, 20);
            this.dangxuatlink.TabIndex = 25;
            this.dangxuatlink.TabStop = true;
            this.dangxuatlink.Text = "Đăng xuất";
            this.dangxuatlink.VisitedLinkColor = System.Drawing.Color.Red;
            this.dangxuatlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dangxuatlink_LinkClicked);
            // 
            // timkiemkhachsangb
            // 
            this.timkiemkhachsangb.Controls.Add(this.thanhphotb);
            this.timkiemkhachsangb.Controls.Add(this.TimTheoTPGC_Option);
            this.timkiemkhachsangb.Controls.Add(this.TimTheoTPHS_Option);
            this.timkiemkhachsangb.Controls.Add(this.hangsaotb);
            this.timkiemkhachsangb.Controls.Add(this.giatbtb);
            this.timkiemkhachsangb.Controls.Add(this.giatblb);
            this.timkiemkhachsangb.Controls.Add(this.TimTheoTP_Option);
            this.timkiemkhachsangb.Controls.Add(this.hangsaolb);
            this.timkiemkhachsangb.Controls.Add(this.thanhpholb);
            this.timkiemkhachsangb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiemkhachsangb.Location = new System.Drawing.Point(44, 43);
            this.timkiemkhachsangb.Name = "timkiemkhachsangb";
            this.timkiemkhachsangb.Size = new System.Drawing.Size(920, 105);
            this.timkiemkhachsangb.TabIndex = 26;
            this.timkiemkhachsangb.TabStop = false;
            this.timkiemkhachsangb.Text = "TÌM KIẾM KHÁCH SẠN";
            // 
            // TimTheoTPGC_Option
            // 
            this.TimTheoTPGC_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.TimTheoTPGC_Option.FlatAppearance.BorderSize = 0;
            this.TimTheoTPGC_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.TimTheoTPGC_Option.ForeColor = System.Drawing.Color.White;
            this.TimTheoTPGC_Option.Location = new System.Drawing.Point(372, 58);
            this.TimTheoTPGC_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TimTheoTPGC_Option.Name = "TimTheoTPGC_Option";
            this.TimTheoTPGC_Option.Size = new System.Drawing.Size(291, 30);
            this.TimTheoTPGC_Option.TabIndex = 26;
            this.TimTheoTPGC_Option.Text = "Tìm Theo Thành Phố Và Giá Cả";
            this.TimTheoTPGC_Option.UseVisualStyleBackColor = false;
            this.TimTheoTPGC_Option.Click += new System.EventHandler(this.TimTheoTPGC_Option_Click);
            // 
            // TimTheoTPHS_Option
            // 
            this.TimTheoTPHS_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.TimTheoTPHS_Option.FlatAppearance.BorderSize = 0;
            this.TimTheoTPHS_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.TimTheoTPHS_Option.ForeColor = System.Drawing.Color.White;
            this.TimTheoTPHS_Option.Location = new System.Drawing.Point(372, 25);
            this.TimTheoTPHS_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.TimTheoTPHS_Option.Name = "TimTheoTPHS_Option";
            this.TimTheoTPHS_Option.Size = new System.Drawing.Size(291, 30);
            this.TimTheoTPHS_Option.TabIndex = 25;
            this.TimTheoTPHS_Option.Text = "Tìm Theo Thành Phố Và Hạng Sao";
            this.TimTheoTPHS_Option.UseVisualStyleBackColor = false;
            this.TimTheoTPHS_Option.Click += new System.EventHandler(this.TimTheoTPHS_Option_Click);
            // 
            // hangsaotb
            // 
            this.hangsaotb.Location = new System.Drawing.Point(127, 61);
            this.hangsaotb.Name = "hangsaotb";
            this.hangsaotb.Size = new System.Drawing.Size(100, 26);
            this.hangsaotb.TabIndex = 24;
            // 
            // giatbtb
            // 
            this.giatbtb.Location = new System.Drawing.Point(243, 61);
            this.giatbtb.Name = "giatbtb";
            this.giatbtb.Size = new System.Drawing.Size(100, 26);
            this.giatbtb.TabIndex = 23;
            // 
            // danhsachkhachsangb
            // 
            this.danhsachkhachsangb.Controls.Add(this.danhsachkhachsan);
            this.danhsachkhachsangb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachkhachsangb.Location = new System.Drawing.Point(44, 172);
            this.danhsachkhachsangb.Name = "danhsachkhachsangb";
            this.danhsachkhachsangb.Size = new System.Drawing.Size(1203, 495);
            this.danhsachkhachsangb.TabIndex = 27;
            this.danhsachkhachsangb.TabStop = false;
            this.danhsachkhachsangb.Text = "DANH SÁCH KHÁCH SẠN";
            // 
            // danhsachkhachsan
            // 
            this.danhsachkhachsan.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.danhsachkhachsan.ColumnHeadersHeight = 30;
            this.danhsachkhachsan.Location = new System.Drawing.Point(11, 25);
            this.danhsachkhachsan.Name = "danhsachkhachsan";
            this.danhsachkhachsan.RowHeadersWidth = 90;
            this.danhsachkhachsan.Size = new System.Drawing.Size(1181, 459);
            this.danhsachkhachsan.TabIndex = 0;
            // 
            // DatPhongKhachSan_Option
            // 
            this.DatPhongKhachSan_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.DatPhongKhachSan_Option.FlatAppearance.BorderSize = 0;
            this.DatPhongKhachSan_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.DatPhongKhachSan_Option.ForeColor = System.Drawing.Color.White;
            this.DatPhongKhachSan_Option.Location = new System.Drawing.Point(1023, 118);
            this.DatPhongKhachSan_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.DatPhongKhachSan_Option.Name = "DatPhongKhachSan_Option";
            this.DatPhongKhachSan_Option.Size = new System.Drawing.Size(100, 30);
            this.DatPhongKhachSan_Option.TabIndex = 28;
            this.DatPhongKhachSan_Option.Text = "Đặt Phòng";
            this.DatPhongKhachSan_Option.UseVisualStyleBackColor = false;
            this.DatPhongKhachSan_Option.Click += new System.EventHandler(this.DatPhongKhachSan_Option_Click);
            // 
            // thanhphotb
            // 
            this.thanhphotb.FormattingEnabled = true;
            this.thanhphotb.Location = new System.Drawing.Point(11, 61);
            this.thanhphotb.Name = "thanhphotb";
            this.thanhphotb.Size = new System.Drawing.Size(96, 26);
            this.thanhphotb.TabIndex = 27;
            // 
            // HotelSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.DatPhongKhachSan_Option);
            this.Controls.Add(this.danhsachkhachsangb);
            this.Controls.Add(this.timkiemkhachsangb);
            this.Controls.Add(this.dangxuatlink);
            this.Controls.Add(this.QuayLaicl_Option);
            this.Controls.Add(this.usernamelink);
            this.Name = "HotelSearching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelSearching";
            this.Load += new System.EventHandler(this.HotelSearching_Load);
            this.timkiemkhachsangb.ResumeLayout(false);
            this.timkiemkhachsangb.PerformLayout();
            this.danhsachkhachsangb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachkhachsan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel usernamelink;
        private System.Windows.Forms.Label giatblb;
        private System.Windows.Forms.Label hangsaolb;
        private System.Windows.Forms.Label thanhpholb;
        private System.Windows.Forms.Button TimTheoTP_Option;
        private System.Windows.Forms.Button QuayLaicl_Option;
        private System.Windows.Forms.LinkLabel dangxuatlink;
        private System.Windows.Forms.GroupBox timkiemkhachsangb;
        private System.Windows.Forms.GroupBox danhsachkhachsangb;
        private System.Windows.Forms.DataGridView danhsachkhachsan;
        private System.Windows.Forms.Button DatPhongKhachSan_Option;
        private System.Windows.Forms.TextBox hangsaotb;
        private System.Windows.Forms.TextBox giatbtb;
        private System.Windows.Forms.Button TimTheoTPGC_Option;
        private System.Windows.Forms.Button TimTheoTPHS_Option;
        private System.Windows.Forms.ComboBox thanhphotb;
    }
}