namespace DoHoaC_
{
    partial class DonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RBTChuaTT = new System.Windows.Forms.RadioButton();
            this.RBTDaTT = new System.Windows.Forms.RadioButton();
            this.textBoxTenNV = new System.Windows.Forms.TextBox();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(26, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1497, 412);
            this.panel3.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1466, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.buttonSua);
            this.panel2.Controls.Add(this.buttonXoa);
            this.panel2.Controls.Add(this.buttonThem);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(26, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1501, 99);
            this.panel2.TabIndex = 38;
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSua.Location = new System.Drawing.Point(271, 26);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(152, 49);
            this.buttonSua.TabIndex = 6;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonXoa.Location = new System.Drawing.Point(491, 26);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(152, 49);
            this.buttonXoa.TabIndex = 5;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonThem.Location = new System.Drawing.Point(44, 26);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(152, 49);
            this.buttonThem.TabIndex = 4;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.ThemBT_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.panel4.Controls.Add(this.textBoxFind);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(772, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(707, 51);
            this.panel4.TabIndex = 0;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(128, 7);
            this.textBoxFind.Multiline = true;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(562, 32);
            this.textBoxFind.TabIndex = 1;
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm kiếm";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.RBTChuaTT);
            this.panel5.Controls.Add(this.RBTDaTT);
            this.panel5.Controls.Add(this.textBoxTenNV);
            this.panel5.Controls.Add(this.textBoxTenKH);
            this.panel5.Controls.Add(this.textBoxTongTien);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(26, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1499, 102);
            this.panel5.TabIndex = 41;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(527, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(336, 30);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // RBTChuaTT
            // 
            this.RBTChuaTT.AutoSize = true;
            this.RBTChuaTT.Enabled = false;
            this.RBTChuaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTChuaTT.Location = new System.Drawing.Point(1301, 50);
            this.RBTChuaTT.Name = "RBTChuaTT";
            this.RBTChuaTT.Size = new System.Drawing.Size(178, 29);
            this.RBTChuaTT.TabIndex = 27;
            this.RBTChuaTT.TabStop = true;
            this.RBTChuaTT.Text = "Chưa thanh toán";
            this.RBTChuaTT.UseVisualStyleBackColor = true;
            // 
            // RBTDaTT
            // 
            this.RBTDaTT.AutoSize = true;
            this.RBTDaTT.Enabled = false;
            this.RBTDaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTDaTT.Location = new System.Drawing.Point(1125, 49);
            this.RBTDaTT.Name = "RBTDaTT";
            this.RBTDaTT.Size = new System.Drawing.Size(155, 29);
            this.RBTDaTT.TabIndex = 27;
            this.RBTDaTT.TabStop = true;
            this.RBTDaTT.Text = "Đã thanh toán";
            this.RBTDaTT.UseVisualStyleBackColor = true;
            // 
            // textBoxTenNV
            // 
            this.textBoxTenNV.Enabled = false;
            this.textBoxTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenNV.Location = new System.Drawing.Point(271, 49);
            this.textBoxTenNV.Multiline = true;
            this.textBoxTenNV.Name = "textBoxTenNV";
            this.textBoxTenNV.Size = new System.Drawing.Size(239, 30);
            this.textBoxTenNV.TabIndex = 23;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Enabled = false;
            this.textBoxTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenKH.Location = new System.Drawing.Point(35, 49);
            this.textBoxTenKH.Multiline = true;
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(212, 30);
            this.textBoxTenKH.TabIndex = 23;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Enabled = false;
            this.textBoxTongTien.Location = new System.Drawing.Point(881, 49);
            this.textBoxTongTien.Multiline = true;
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(224, 29);
            this.textBoxTongTien.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1242, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(876, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(522, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên khách hàng";
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "DonHang";
            this.Size = new System.Drawing.Size(1549, 685);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton RBTChuaTT;
        private System.Windows.Forms.RadioButton RBTDaTT;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxTenNV;
        private System.Windows.Forms.Label label2;
    }
}
