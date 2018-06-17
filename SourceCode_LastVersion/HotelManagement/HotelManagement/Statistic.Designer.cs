namespace HotelManagement
{
    partial class Statistic
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
            this.quanlythongkegb = new System.Windows.Forms.GroupBox();
            this.sapxepgb = new System.Windows.Forms.GroupBox();
            this.tpcb = new System.Windows.Forms.CheckBox();
            this.sosaocb = new System.Windows.Forms.CheckBox();
            this.ngaythongkedt = new System.Windows.Forms.DateTimePicker();
            this.ChonThongKe_Option = new System.Windows.Forms.Button();
            this.tenloaiphongtb = new System.Windows.Forms.TextBox();
            this.tenkstb = new System.Windows.Forms.TextBox();
            this.tenloaiphonglb = new System.Windows.Forms.Label();
            this.ngaythongkelb = new System.Windows.Forms.Label();
            this.tenkslb = new System.Windows.Forms.Label();
            this.danhsachthongkegb = new System.Windows.Forms.GroupBox();
            this.danhsachthongke = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuayLaisv_Option = new System.Windows.Forms.Button();
            this.quanlythongkegb.SuspendLayout();
            this.sapxepgb.SuspendLayout();
            this.danhsachthongkegb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // quanlythongkegb
            // 
            this.quanlythongkegb.Controls.Add(this.sapxepgb);
            this.quanlythongkegb.Controls.Add(this.ngaythongkedt);
            this.quanlythongkegb.Controls.Add(this.ChonThongKe_Option);
            this.quanlythongkegb.Controls.Add(this.tenloaiphongtb);
            this.quanlythongkegb.Controls.Add(this.tenkstb);
            this.quanlythongkegb.Controls.Add(this.tenloaiphonglb);
            this.quanlythongkegb.Controls.Add(this.ngaythongkelb);
            this.quanlythongkegb.Controls.Add(this.tenkslb);
            this.quanlythongkegb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlythongkegb.Location = new System.Drawing.Point(44, 43);
            this.quanlythongkegb.Name = "quanlythongkegb";
            this.quanlythongkegb.Size = new System.Drawing.Size(859, 105);
            this.quanlythongkegb.TabIndex = 29;
            this.quanlythongkegb.TabStop = false;
            this.quanlythongkegb.Text = "QUẢN LÝ THỐNG KÊ";
            // 
            // sapxepgb
            // 
            this.sapxepgb.Controls.Add(this.tpcb);
            this.sapxepgb.Controls.Add(this.sosaocb);
            this.sapxepgb.Location = new System.Drawing.Point(476, 25);
            this.sapxepgb.Name = "sapxepgb";
            this.sapxepgb.Size = new System.Drawing.Size(236, 73);
            this.sapxepgb.TabIndex = 33;
            this.sapxepgb.TabStop = false;
            this.sapxepgb.Text = "Sắp xếp theo";
            // 
            // tpcb
            // 
            this.tpcb.AutoSize = true;
            this.tpcb.Location = new System.Drawing.Point(18, 34);
            this.tpcb.Name = "tpcb";
            this.tpcb.Size = new System.Drawing.Size(99, 22);
            this.tpcb.TabIndex = 32;
            this.tpcb.Text = "Thành phố";
            this.tpcb.UseVisualStyleBackColor = true;
            // 
            // sosaocb
            // 
            this.sosaocb.AutoSize = true;
            this.sosaocb.Location = new System.Drawing.Point(138, 34);
            this.sosaocb.Name = "sosaocb";
            this.sosaocb.Size = new System.Drawing.Size(77, 22);
            this.sosaocb.TabIndex = 31;
            this.sosaocb.Text = "Số sao";
            this.sosaocb.UseVisualStyleBackColor = true;
            // 
            // ngaythongkedt
            // 
            this.ngaythongkedt.Location = new System.Drawing.Point(318, 60);
            this.ngaythongkedt.Name = "ngaythongkedt";
            this.ngaythongkedt.Size = new System.Drawing.Size(130, 26);
            this.ngaythongkedt.TabIndex = 30;
            // 
            // ChonThongKe_Option
            // 
            this.ChonThongKe_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.ChonThongKe_Option.FlatAppearance.BorderSize = 0;
            this.ChonThongKe_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.ChonThongKe_Option.ForeColor = System.Drawing.Color.White;
            this.ChonThongKe_Option.Location = new System.Drawing.Point(743, 51);
            this.ChonThongKe_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ChonThongKe_Option.Name = "ChonThongKe_Option";
            this.ChonThongKe_Option.Size = new System.Drawing.Size(100, 30);
            this.ChonThongKe_Option.TabIndex = 29;
            this.ChonThongKe_Option.Text = "Chọn";
            this.ChonThongKe_Option.UseVisualStyleBackColor = false;
            this.ChonThongKe_Option.Click += new System.EventHandler(this.ChonThongKe_Option_Click);
            // 
            // tenloaiphongtb
            // 
            this.tenloaiphongtb.Location = new System.Drawing.Point(168, 59);
            this.tenloaiphongtb.Name = "tenloaiphongtb";
            this.tenloaiphongtb.Size = new System.Drawing.Size(130, 26);
            this.tenloaiphongtb.TabIndex = 20;
            // 
            // tenkstb
            // 
            this.tenkstb.Location = new System.Drawing.Point(18, 59);
            this.tenkstb.Name = "tenkstb";
            this.tenkstb.Size = new System.Drawing.Size(130, 26);
            this.tenkstb.TabIndex = 19;
            // 
            // tenloaiphonglb
            // 
            this.tenloaiphonglb.AutoSize = true;
            this.tenloaiphonglb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenloaiphonglb.Location = new System.Drawing.Point(165, 39);
            this.tenloaiphonglb.Name = "tenloaiphonglb";
            this.tenloaiphonglb.Size = new System.Drawing.Size(110, 18);
            this.tenloaiphonglb.TabIndex = 14;
            this.tenloaiphonglb.Text = "Tên loại phòng";
            // 
            // ngaythongkelb
            // 
            this.ngaythongkelb.AutoSize = true;
            this.ngaythongkelb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaythongkelb.Location = new System.Drawing.Point(315, 39);
            this.ngaythongkelb.Name = "ngaythongkelb";
            this.ngaythongkelb.Size = new System.Drawing.Size(107, 18);
            this.ngaythongkelb.TabIndex = 16;
            this.ngaythongkelb.Text = "Ngày thống kê";
            // 
            // tenkslb
            // 
            this.tenkslb.AutoSize = true;
            this.tenkslb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenkslb.Location = new System.Drawing.Point(15, 39);
            this.tenkslb.Name = "tenkslb";
            this.tenkslb.Size = new System.Drawing.Size(108, 18);
            this.tenkslb.TabIndex = 18;
            this.tenkslb.Text = "Tên khách sạn";
            // 
            // danhsachthongkegb
            // 
            this.danhsachthongkegb.Controls.Add(this.danhsachthongke);
            this.danhsachthongkegb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachthongkegb.Location = new System.Drawing.Point(44, 172);
            this.danhsachthongkegb.Name = "danhsachthongkegb";
            this.danhsachthongkegb.Size = new System.Drawing.Size(1203, 495);
            this.danhsachthongkegb.TabIndex = 30;
            this.danhsachthongkegb.TabStop = false;
            this.danhsachthongkegb.Text = "DANH SÁCH THỐNG KÊ";
            // 
            // danhsachthongke
            // 
            this.danhsachthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachthongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.danhsachthongke.Location = new System.Drawing.Point(18, 25);
            this.danhsachthongke.Name = "danhsachthongke";
            this.danhsachthongke.Size = new System.Drawing.Size(1168, 455);
            this.danhsachthongke.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Mã khách sạn";
            this.Column1.HeaderText = "Mã khách sạn";
            this.Column1.Name = "Column1";
            this.Column1.Width = 135;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tên khách sạn";
            this.Column2.HeaderText = "Tên khách sạn";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Mã loại phòng";
            this.Column3.HeaderText = "Mã loại phòng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tên loại phòng";
            this.Column4.HeaderText = "Tên loại phòng";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Thành phố";
            this.Column5.HeaderText = "Thành phố";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Số sao";
            this.Column6.HeaderText = "Số sao";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Số phòng trống";
            this.Column7.HeaderText = "Số phòng trống";
            this.Column7.Name = "Column7";
            this.Column7.Width = 140;
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
            this.QuayLaisv_Option.TabIndex = 31;
            this.QuayLaisv_Option.Text = "Quay Lại";
            this.QuayLaisv_Option.UseVisualStyleBackColor = false;
            this.QuayLaisv_Option.Click += new System.EventHandler(this.QuayLaisv_Option_Click);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1301, 700);
            this.Controls.Add(this.QuayLaisv_Option);
            this.Controls.Add(this.danhsachthongkegb);
            this.Controls.Add(this.quanlythongkegb);
            this.Name = "Statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.quanlythongkegb.ResumeLayout(false);
            this.quanlythongkegb.PerformLayout();
            this.sapxepgb.ResumeLayout(false);
            this.sapxepgb.PerformLayout();
            this.danhsachthongkegb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachthongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox quanlythongkegb;
        private System.Windows.Forms.Button ChonThongKe_Option;
        private System.Windows.Forms.TextBox tenloaiphongtb;
        private System.Windows.Forms.TextBox tenkstb;
        private System.Windows.Forms.Label tenloaiphonglb;
        private System.Windows.Forms.Label ngaythongkelb;
        private System.Windows.Forms.Label tenkslb;
        private System.Windows.Forms.GroupBox danhsachthongkegb;
        private System.Windows.Forms.DateTimePicker ngaythongkedt;
        //private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button QuayLaisv_Option;
        private System.Windows.Forms.DataGridView danhsachthongke;
        private System.Windows.Forms.CheckBox tpcb;
        private System.Windows.Forms.CheckBox sosaocb;
        private System.Windows.Forms.GroupBox sapxepgb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}