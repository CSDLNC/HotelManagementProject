namespace HotelManagement
{
    partial class InvoiceDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mahdtb = new System.Windows.Forms.TextBox();
            this.ngaytttb = new System.Windows.Forms.TextBox();
            this.tongtientb = new System.Windows.Forms.TextBox();
            this.madptb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày thanh toán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã đặt phòng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.madptb);
            this.groupBox1.Controls.Add(this.tongtientb);
            this.groupBox1.Controls.Add(this.ngaytttb);
            this.groupBox1.Controls.Add(this.mahdtb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // mahdtb
            // 
            this.mahdtb.Location = new System.Drawing.Point(200, 51);
            this.mahdtb.Name = "mahdtb";
            this.mahdtb.ReadOnly = true;
            this.mahdtb.Size = new System.Drawing.Size(219, 26);
            this.mahdtb.TabIndex = 4;
            // 
            // ngaytttb
            // 
            this.ngaytttb.Location = new System.Drawing.Point(200, 84);
            this.ngaytttb.Name = "ngaytttb";
            this.ngaytttb.ReadOnly = true;
            this.ngaytttb.Size = new System.Drawing.Size(219, 26);
            this.ngaytttb.TabIndex = 4;
            // 
            // tongtientb
            // 
            this.tongtientb.Location = new System.Drawing.Point(200, 117);
            this.tongtientb.Name = "tongtientb";
            this.tongtientb.ReadOnly = true;
            this.tongtientb.Size = new System.Drawing.Size(219, 26);
            this.tongtientb.TabIndex = 4;
            // 
            // madptb
            // 
            this.madptb.Location = new System.Drawing.Point(200, 147);
            this.madptb.Name = "madptb";
            this.madptb.ReadOnly = true;
            this.madptb.Size = new System.Drawing.Size(219, 26);
            this.madptb.TabIndex = 4;
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(124)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "InvoiceDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceDetail";
            this.Load += new System.EventHandler(this.InvoiceDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mahdtb;
        private System.Windows.Forms.TextBox ngaytttb;
        private System.Windows.Forms.TextBox tongtientb;
        private System.Windows.Forms.TextBox madptb;
    }
}