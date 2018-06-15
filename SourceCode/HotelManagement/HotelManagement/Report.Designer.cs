namespace HotelManagement
{
    partial class Report
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
            this.quanlybaocaogb = new System.Windows.Forms.GroupBox();
            this.baocaogb = new System.Windows.Forms.GroupBox();
            this.thangcb = new System.Windows.Forms.CheckBox();
            this.namcb = new System.Windows.Forms.CheckBox();
            this.ChonBaoCao_Option = new System.Windows.Forms.Button();
            this.namtb = new System.Windows.Forms.TextBox();
            this.thangtb = new System.Windows.Forms.TextBox();
            this.tenkstb = new System.Windows.Forms.TextBox();
            this.thanglb = new System.Windows.Forms.Label();
            this.namlb = new System.Windows.Forms.Label();
            this.tenkslb = new System.Windows.Forms.Label();
            this.danhsachbaocaogb = new System.Windows.Forms.GroupBox();
            this.danhsachbaocao = new System.Windows.Forms.DataGridView();
            this.QuayLaisv_Option = new System.Windows.Forms.Button();
            this.quanlybaocaogb.SuspendLayout();
            this.baocaogb.SuspendLayout();
            this.danhsachbaocaogb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachbaocao)).BeginInit();
            this.SuspendLayout();
            // 
            // quanlybaocaogb
            // 
            this.quanlybaocaogb.Controls.Add(this.baocaogb);
            this.quanlybaocaogb.Controls.Add(this.ChonBaoCao_Option);
            this.quanlybaocaogb.Controls.Add(this.namtb);
            this.quanlybaocaogb.Controls.Add(this.thangtb);
            this.quanlybaocaogb.Controls.Add(this.tenkstb);
            this.quanlybaocaogb.Controls.Add(this.thanglb);
            this.quanlybaocaogb.Controls.Add(this.namlb);
            this.quanlybaocaogb.Controls.Add(this.tenkslb);
            this.quanlybaocaogb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlybaocaogb.Location = new System.Drawing.Point(44, 43);
            this.quanlybaocaogb.Name = "quanlybaocaogb";
            this.quanlybaocaogb.Size = new System.Drawing.Size(903, 123);
            this.quanlybaocaogb.TabIndex = 28;
            this.quanlybaocaogb.TabStop = false;
            this.quanlybaocaogb.Text = "QUẢN LÝ BÁO CÁO";
            // 
            // baocaogb
            // 
            this.baocaogb.Controls.Add(this.thangcb);
            this.baocaogb.Controls.Add(this.namcb);
            this.baocaogb.Location = new System.Drawing.Point(19, 25);
            this.baocaogb.Name = "baocaogb";
            this.baocaogb.Size = new System.Drawing.Size(209, 79);
            this.baocaogb.TabIndex = 34;
            this.baocaogb.TabStop = false;
            this.baocaogb.Text = "Báo cáo theo";
            // 
            // thangcb
            // 
            this.thangcb.AutoSize = true;
            this.thangcb.Checked = true;
            this.thangcb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thangcb.Location = new System.Drawing.Point(20, 35);
            this.thangcb.Name = "thangcb";
            this.thangcb.Size = new System.Drawing.Size(70, 22);
            this.thangcb.TabIndex = 0;
            this.thangcb.Text = "Tháng";
            this.thangcb.UseVisualStyleBackColor = true;
            this.thangcb.CheckedChanged += new System.EventHandler(this.thangcb_CheckedChanged);
            // 
            // namcb
            // 
            this.namcb.AutoSize = true;
            this.namcb.Location = new System.Drawing.Point(129, 35);
            this.namcb.Name = "namcb";
            this.namcb.Size = new System.Drawing.Size(60, 22);
            this.namcb.TabIndex = 1;
            this.namcb.Text = "Năm";
            this.namcb.UseVisualStyleBackColor = true;
            this.namcb.CheckedChanged += new System.EventHandler(this.namcb_CheckedChanged);
            // 
            // ChonBaoCao_Option
            // 
            this.ChonBaoCao_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.ChonBaoCao_Option.FlatAppearance.BorderSize = 0;
            this.ChonBaoCao_Option.Font = new System.Drawing.Font("Arial", 12F);
            this.ChonBaoCao_Option.ForeColor = System.Drawing.Color.White;
            this.ChonBaoCao_Option.Location = new System.Drawing.Point(797, 55);
            this.ChonBaoCao_Option.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ChonBaoCao_Option.Name = "ChonBaoCao_Option";
            this.ChonBaoCao_Option.Size = new System.Drawing.Size(100, 30);
            this.ChonBaoCao_Option.TabIndex = 29;
            this.ChonBaoCao_Option.Text = "Chọn";
            this.ChonBaoCao_Option.UseVisualStyleBackColor = false;
            this.ChonBaoCao_Option.Click += new System.EventHandler(this.ChonBaoCao_Option_Click);
            // 
            // namtb
            // 
            this.namtb.Location = new System.Drawing.Point(624, 59);
            this.namtb.Name = "namtb";
            this.namtb.Size = new System.Drawing.Size(130, 26);
            this.namtb.TabIndex = 21;
            this.namtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.namtb_KeyPress);
            // 
            // thangtb
            // 
            this.thangtb.Location = new System.Drawing.Point(454, 59);
            this.thangtb.Name = "thangtb";
            this.thangtb.Size = new System.Drawing.Size(130, 26);
            this.thangtb.TabIndex = 20;
            this.thangtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thangtb_KeyPress);
            // 
            // tenkstb
            // 
            this.tenkstb.Location = new System.Drawing.Point(268, 59);
            this.tenkstb.Name = "tenkstb";
            this.tenkstb.Size = new System.Drawing.Size(130, 26);
            this.tenkstb.TabIndex = 19;
            // 
            // thanglb
            // 
            this.thanglb.AutoSize = true;
            this.thanglb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanglb.Location = new System.Drawing.Point(451, 33);
            this.thanglb.Name = "thanglb";
            this.thanglb.Size = new System.Drawing.Size(51, 18);
            this.thanglb.TabIndex = 14;
            this.thanglb.Text = "Tháng";
            // 
            // namlb
            // 
            this.namlb.AutoSize = true;
            this.namlb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namlb.Location = new System.Drawing.Point(621, 38);
            this.namlb.Name = "namlb";
            this.namlb.Size = new System.Drawing.Size(41, 18);
            this.namlb.TabIndex = 16;
            this.namlb.Text = "Năm";
            // 
            // tenkslb
            // 
            this.tenkslb.AutoSize = true;
            this.tenkslb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenkslb.Location = new System.Drawing.Point(265, 33);
            this.tenkslb.Name = "tenkslb";
            this.tenkslb.Size = new System.Drawing.Size(108, 18);
            this.tenkslb.TabIndex = 18;
            this.tenkslb.Text = "Tên khách sạn";
            // 
            // danhsachbaocaogb
            // 
            this.danhsachbaocaogb.Controls.Add(this.danhsachbaocao);
            this.danhsachbaocaogb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachbaocaogb.Location = new System.Drawing.Point(44, 172);
            this.danhsachbaocaogb.Name = "danhsachbaocaogb";
            this.danhsachbaocaogb.Size = new System.Drawing.Size(1203, 495);
            this.danhsachbaocaogb.TabIndex = 29;
            this.danhsachbaocaogb.TabStop = false;
            this.danhsachbaocaogb.Text = "DANH SÁCH BÁO CÁO";
            // 
            // danhsachbaocao
            // 
            this.danhsachbaocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachbaocao.Location = new System.Drawing.Point(19, 32);
            this.danhsachbaocao.Name = "danhsachbaocao";
            this.danhsachbaocao.Size = new System.Drawing.Size(1168, 443);
            this.danhsachbaocao.TabIndex = 0;
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
            this.QuayLaisv_Option.TabIndex = 30;
            this.QuayLaisv_Option.Text = "Quay Lại";
            this.QuayLaisv_Option.UseVisualStyleBackColor = false;
            this.QuayLaisv_Option.Click += new System.EventHandler(this.QuayLaisv_Option_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1301, 700);
            this.Controls.Add(this.QuayLaisv_Option);
            this.Controls.Add(this.danhsachbaocaogb);
            this.Controls.Add(this.quanlybaocaogb);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.quanlybaocaogb.ResumeLayout(false);
            this.quanlybaocaogb.PerformLayout();
            this.baocaogb.ResumeLayout(false);
            this.baocaogb.PerformLayout();
            this.danhsachbaocaogb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachbaocao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox quanlybaocaogb;
        private System.Windows.Forms.Label thanglb;
        private System.Windows.Forms.Label namlb;
        private System.Windows.Forms.Label tenkslb;
        private System.Windows.Forms.TextBox namtb;
        private System.Windows.Forms.TextBox thangtb;
        private System.Windows.Forms.TextBox tenkstb;
        private System.Windows.Forms.Button ChonBaoCao_Option;
        private System.Windows.Forms.GroupBox danhsachbaocaogb;
        private System.Windows.Forms.Button QuayLaisv_Option;
        private System.Windows.Forms.DataGridView danhsachbaocao;
        private System.Windows.Forms.GroupBox baocaogb;
        private System.Windows.Forms.CheckBox thangcb;
        private System.Windows.Forms.CheckBox namcb;
    }
}