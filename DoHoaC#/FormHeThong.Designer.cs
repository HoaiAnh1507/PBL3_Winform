namespace DoHoaC_
{
    partial class FormHeThong
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTSanPham = new System.Windows.Forms.Button();
            this.BTdonhang = new System.Windows.Forms.Button();
            this.BTkhachhang = new System.Windows.Forms.Button();
            this.BTnhanvien = new System.Windows.Forms.Button();
            this.BThethong = new System.Windows.Forms.Button();
            this.BTncc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTthongke = new System.Windows.Forms.Button();
            this.thongKe1 = new DoHoaC_.ThongKe();
            this.donHang1 = new DoHoaC_.DonHang();
            this.nhanVien1 = new DoHoaC_.NhanVien();
            this.ncc1 = new DoHoaC_.NCC();
            this.khachHang1 = new DoHoaC_.KhachHang();
            this.sanPham1 = new DoHoaC_.SanPham();
            this.heThong1 = new DoHoaC_.HeThong();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::DoHoaC_.Properties.Resources.hong;
            this.panel2.Controls.Add(this.thongKe1);
            this.panel2.Controls.Add(this.donHang1);
            this.panel2.Controls.Add(this.nhanVien1);
            this.panel2.Controls.Add(this.ncc1);
            this.panel2.Controls.Add(this.khachHang1);
            this.panel2.Controls.Add(this.sanPham1);
            this.panel2.Controls.Add(this.heThong1);
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1549, 685);
            this.panel2.TabIndex = 19;
            // 
            // BTSanPham
            // 
            this.BTSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.BTSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTSanPham.Location = new System.Drawing.Point(221, 0);
            this.BTSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTSanPham.Name = "BTSanPham";
            this.BTSanPham.Size = new System.Drawing.Size(221, 76);
            this.BTSanPham.TabIndex = 12;
            this.BTSanPham.Text = "Sản phẩm";
            this.BTSanPham.UseVisualStyleBackColor = false;
            this.BTSanPham.Click += new System.EventHandler(this.BTSanPham_Click);
            // 
            // BTdonhang
            // 
            this.BTdonhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.BTdonhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTdonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdonhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTdonhang.Location = new System.Drawing.Point(442, 0);
            this.BTdonhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTdonhang.Name = "BTdonhang";
            this.BTdonhang.Size = new System.Drawing.Size(221, 76);
            this.BTdonhang.TabIndex = 11;
            this.BTdonhang.Text = "Đơn hàng";
            this.BTdonhang.UseVisualStyleBackColor = false;
            this.BTdonhang.Click += new System.EventHandler(this.BTdonhang_Click);
            // 
            // BTkhachhang
            // 
            this.BTkhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.BTkhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTkhachhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTkhachhang.Location = new System.Drawing.Point(663, 0);
            this.BTkhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTkhachhang.Name = "BTkhachhang";
            this.BTkhachhang.Size = new System.Drawing.Size(221, 76);
            this.BTkhachhang.TabIndex = 10;
            this.BTkhachhang.Text = "Khách hàng";
            this.BTkhachhang.UseVisualStyleBackColor = false;
            this.BTkhachhang.Click += new System.EventHandler(this.BTkhachhang_Click);
            // 
            // BTnhanvien
            // 
            this.BTnhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.BTnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTnhanvien.Location = new System.Drawing.Point(1105, 0);
            this.BTnhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTnhanvien.Name = "BTnhanvien";
            this.BTnhanvien.Size = new System.Drawing.Size(221, 76);
            this.BTnhanvien.TabIndex = 8;
            this.BTnhanvien.Text = "Nhân viên";
            this.BTnhanvien.UseVisualStyleBackColor = false;
            this.BTnhanvien.Click += new System.EventHandler(this.BTnhanvien_Click);
            // 
            // BThethong
            // 
            this.BThethong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.BThethong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BThethong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BThethong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BThethong.Location = new System.Drawing.Point(0, 0);
            this.BThethong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BThethong.Name = "BThethong";
            this.BThethong.Size = new System.Drawing.Size(221, 76);
            this.BThethong.TabIndex = 7;
            this.BThethong.Text = "Hệ thống";
            this.BThethong.UseVisualStyleBackColor = false;
            this.BThethong.Click += new System.EventHandler(this.BThethong_Click);
            // 
            // BTncc
            // 
            this.BTncc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.BTncc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTncc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTncc.Location = new System.Drawing.Point(884, 0);
            this.BTncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTncc.Name = "BTncc";
            this.BTncc.Size = new System.Drawing.Size(221, 76);
            this.BTncc.TabIndex = 9;
            this.BTncc.Text = "Nhà cung cấp";
            this.BTncc.UseVisualStyleBackColor = false;
            this.BTncc.Click += new System.EventHandler(this.BTncc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.BTthongke);
            this.panel1.Controls.Add(this.BTncc);
            this.panel1.Controls.Add(this.BThethong);
            this.panel1.Controls.Add(this.BTnhanvien);
            this.panel1.Controls.Add(this.BTkhachhang);
            this.panel1.Controls.Add(this.BTdonhang);
            this.panel1.Controls.Add(this.BTSanPham);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 76);
            this.panel1.TabIndex = 18;
            // 
            // BTthongke
            // 
            this.BTthongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.BTthongke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTthongke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTthongke.Location = new System.Drawing.Point(1326, 0);
            this.BTthongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTthongke.Name = "BTthongke";
            this.BTthongke.Size = new System.Drawing.Size(221, 76);
            this.BTthongke.TabIndex = 13;
            this.BTthongke.Text = "Thống kê";
            this.BTthongke.UseVisualStyleBackColor = false;
            this.BTthongke.Click += new System.EventHandler(this.BTthongke_Click);
            // 
            // thongKe1
            // 
            this.thongKe1.Location = new System.Drawing.Point(0, 0);
            this.thongKe1.Name = "thongKe1";
            this.thongKe1.Size = new System.Drawing.Size(1549, 685);
            this.thongKe1.TabIndex = 6;
            // 
            // donHang1
            // 
            this.donHang1.Location = new System.Drawing.Point(0, -2);
            this.donHang1.Name = "donHang1";
            this.donHang1.Size = new System.Drawing.Size(1549, 687);
            this.donHang1.TabIndex = 5;
            // 
            // nhanVien1
            // 
            this.nhanVien1.Location = new System.Drawing.Point(0, 0);
            this.nhanVien1.Name = "nhanVien1";
            this.nhanVien1.Size = new System.Drawing.Size(1549, 685);
            this.nhanVien1.TabIndex = 4;
            // 
            // ncc1
            // 
            this.ncc1.Location = new System.Drawing.Point(0, -2);
            this.ncc1.Name = "ncc1";
            this.ncc1.Size = new System.Drawing.Size(1549, 687);
            this.ncc1.TabIndex = 3;
            // 
            // khachHang1
            // 
            this.khachHang1.Location = new System.Drawing.Point(0, -3);
            this.khachHang1.Name = "khachHang1";
            this.khachHang1.Size = new System.Drawing.Size(1549, 685);
            this.khachHang1.TabIndex = 2;
            // 
            // sanPham1
            // 
            this.sanPham1.BackColor = System.Drawing.Color.AliceBlue;
            this.sanPham1.Location = new System.Drawing.Point(0, -2);
            this.sanPham1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sanPham1.Name = "sanPham1";
            this.sanPham1.Size = new System.Drawing.Size(1549, 685);
            this.sanPham1.TabIndex = 1;
            // 
            // heThong1
            // 
            this.heThong1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.heThong1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.heThong1.Location = new System.Drawing.Point(0, 0);
            this.heThong1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heThong1.Name = "heThong1";
            this.heThong1.Size = new System.Drawing.Size(1549, 685);
            this.heThong1.TabIndex = 0;
            // 
            // FormHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1549, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHeThong";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng quản lí bán hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHeThong_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHeThong_FormClosed);
            this.Load += new System.EventHandler(this.FormHeThong_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTncc;
        private System.Windows.Forms.Button BThethong;
        private System.Windows.Forms.Button BTnhanvien;
        private System.Windows.Forms.Button BTkhachhang;
        private System.Windows.Forms.Button BTdonhang;
        private System.Windows.Forms.Button BTSanPham;
        private System.Windows.Forms.Panel panel1;
        private DonHang donHang1;
        private NhanVien nhanVien1;
        private NCC ncc1;
        private KhachHang khachHang1;
        private SanPham sanPham1;
        private HeThong heThong1;
        private System.Windows.Forms.Button BTthongke;
        private ThongKe thongKe1;
        //Add main panel
        //private System.Windows.Forms.Panel cardLayoutPanel;
        //this.cardLayoutPanel = new System.Windows.Forms.Panel();

        ////Add properties
        //this.cardLayoutPanel.BackColor = System.Drawing.Color.White;
        //this.cardLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        //this.cardLayoutPanel.Size = new System.Drawing.Size(800, 450);

        ////Add to card layout
        //this.cardLayout1.ContainerControl = cardLayoutPanel;
    }
}

