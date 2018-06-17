namespace HotelManagement
{
    partial class RoomSetting
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
            this.danhsachphongtronggb = new System.Windows.Forms.GroupBox();
            this.danhsachphongtrong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chonPhong = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ngayolai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ngaynhanphongdt = new System.Windows.Forms.DateTimePicker();
            this.dangxuatlink = new System.Windows.Forms.LinkLabel();
            this.usernamelink = new System.Windows.Forms.LinkLabel();
            this.QuayLaicl_Option = new System.Windows.Forms.Button();
            this.danhsachphongtronggb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphongtrong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // danhsachphongtronggb
            // 
            this.danhsachphongtronggb.Controls.Add(this.danhsachphongtrong);
            this.danhsachphongtronggb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachphongtronggb.Location = new System.Drawing.Point(35, 155);
            this.danhsachphongtronggb.Name = "danhsachphongtronggb";
            this.danhsachphongtronggb.Size = new System.Drawing.Size(1243, 611);
            this.danhsachphongtronggb.TabIndex = 29;
            this.danhsachphongtronggb.TabStop = false;
            this.danhsachphongtronggb.Text = "DANH SÁCH PHÒNG TRỐNG";
            // 
            // danhsachphongtrong
            // 
            this.danhsachphongtrong.ColumnHeadersHeight = 30;
            this.danhsachphongtrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.tenKS,
            this.thanhPho,
            this.soSao,
            this.giaTB,
            this.maPhong,
            this.tinhTrang,
            this.chonPhong});
            this.danhsachphongtrong.Location = new System.Drawing.Point(6, 25);
            this.danhsachphongtrong.Name = "danhsachphongtrong";
            this.danhsachphongtrong.Size = new System.Drawing.Size(1214, 569);
            this.danhsachphongtrong.TabIndex = 1;
            this.danhsachphongtrong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhsachphongtrong_CellContentClick_1);
            // 
            // STT
            // 
            this.STT.HeaderText = "Mã khách sạn";
            this.STT.Name = "STT";
            this.STT.Width = 133;
            // 
            // tenKS
            // 
            this.tenKS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tenKS.HeaderText = "Tên khách sạn";
            this.tenKS.Name = "tenKS";
            this.tenKS.Width = 133;
            // 
            // thanhPho
            // 
            this.thanhPho.HeaderText = "Thành Phố";
            this.thanhPho.Name = "thanhPho";
            // 
            // soSao
            // 
            this.soSao.HeaderText = "Hạng sao";
            this.soSao.Name = "soSao";
            // 
            // giaTB
            // 
            this.giaTB.HeaderText = "Giá cả";
            this.giaTB.Name = "giaTB";
            // 
            // maPhong
            // 
            this.maPhong.HeaderText = "Phòng số";
            this.maPhong.Name = "maPhong";
            // 
            // tinhTrang
            // 
            this.tinhTrang.HeaderText = "Tình trạng";
            this.tinhTrang.Name = "tinhTrang";
            // 
            // chonPhong
            // 
            this.chonPhong.HeaderText = "Chọn phòng";
            this.chonPhong.Name = "chonPhong";
            this.chonPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chonPhong.TrueValue = "checkbox()";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ngayolai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ngaynhanphongdt);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN ĐẶT PHÒNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "ngày";
            // 
            // ngayolai
            // 
            this.ngayolai.FormattingEnabled = true;
            this.ngayolai.Location = new System.Drawing.Point(435, 54);
            this.ngayolai.Name = "ngayolai";
            this.ngayolai.Size = new System.Drawing.Size(42, 26);
            this.ngayolai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian ở lại khách sạn ( tính từ lúc nhận phòng ):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn ngày nhận phòng: ";
            // 
            // ngaynhanphongdt
            // 
            this.ngaynhanphongdt.Location = new System.Drawing.Point(230, 19);
            this.ngaynhanphongdt.Name = "ngaynhanphongdt";
            this.ngaynhanphongdt.Size = new System.Drawing.Size(200, 26);
            this.ngaynhanphongdt.TabIndex = 0;
            // 
            // dangxuatlink
            // 
            this.dangxuatlink.ActiveLinkColor = System.Drawing.Color.Black;
            this.dangxuatlink.AutoSize = true;
            this.dangxuatlink.DisabledLinkColor = System.Drawing.Color.Red;
            this.dangxuatlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangxuatlink.Location = new System.Drawing.Point(1207, 9);
            this.dangxuatlink.Name = "dangxuatlink";
            this.dangxuatlink.Size = new System.Drawing.Size(82, 20);
            this.dangxuatlink.TabIndex = 27;
            this.dangxuatlink.TabStop = true;
            this.dangxuatlink.Text = "Đăng xuất";
            this.dangxuatlink.VisitedLinkColor = System.Drawing.Color.Red;
            this.dangxuatlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dangxuatlink_LinkClicked);
            // 
            // usernamelink
            // 
            this.usernamelink.ActiveLinkColor = System.Drawing.Color.Black;
            this.usernamelink.AutoSize = true;
            this.usernamelink.DisabledLinkColor = System.Drawing.Color.Red;
            this.usernamelink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelink.Location = new System.Drawing.Point(1121, 9);
            this.usernamelink.Name = "usernamelink";
            this.usernamelink.Size = new System.Drawing.Size(0, 20);
            this.usernamelink.TabIndex = 26;
            this.usernamelink.TabStop = true;
            this.usernamelink.VisitedLinkColor = System.Drawing.Color.Red;
            this.usernamelink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.usernamelink_LinkClicked);
            // 
            // QuayLaicl_Option
            // 
            this.QuayLaicl_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(3)))), ((int)(((byte)(149)))));
            this.QuayLaicl_Option.FlatAppearance.BorderSize = 0;
            this.QuayLaicl_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.QuayLaicl_Option.ForeColor = System.Drawing.Color.White;
            this.QuayLaicl_Option.Location = new System.Drawing.Point(1178, 107);
            this.QuayLaicl_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.QuayLaicl_Option.Name = "QuayLaicl_Option";
            this.QuayLaicl_Option.Size = new System.Drawing.Size(100, 30);
            this.QuayLaicl_Option.TabIndex = 28;
            this.QuayLaicl_Option.Text = "Quay Lại";
            this.QuayLaicl_Option.UseVisualStyleBackColor = false;
            this.QuayLaicl_Option.Click += new System.EventHandler(this.QuayLaicl_Option_Click);
            // 
            // RoomSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1301, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.QuayLaicl_Option);
            this.Controls.Add(this.dangxuatlink);
            this.Controls.Add(this.usernamelink);
            this.Controls.Add(this.danhsachphongtronggb);
            this.Name = "RoomSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomSetting";
            this.Load += new System.EventHandler(this.RoomSetting_Load);
            this.danhsachphongtronggb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachphongtrong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox danhsachphongtronggb;
        private System.Windows.Forms.DataGridView danhsachphongtrong;
        private System.Windows.Forms.LinkLabel dangxuatlink;
        private System.Windows.Forms.LinkLabel usernamelink;
        private System.Windows.Forms.Button QuayLaicl_Option;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSao;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chonPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngaynhanphongdt;
        private System.Windows.Forms.ComboBox ngayolai;
        private System.Windows.Forms.Label label3;
    }
}