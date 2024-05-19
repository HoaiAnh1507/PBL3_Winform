namespace DoHoaC_
{
    partial class FormDonHangChiTiet
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxIDNV = new System.Windows.Forms.ComboBox();
            this.comboBoxIDKH = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxThanhToan = new System.Windows.Forms.TextBox();
            this.HuyBT = new System.Windows.Forms.Button();
            this.NhapBT = new System.Windows.Forms.Button();
            this.TaoBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTenSP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonThemSP = new System.Windows.Forms.Button();
            this.domainSL = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIDDH = new System.Windows.Forms.TextBox();
            this.comboBoxTenNV = new System.Windows.Forms.ComboBox();
            this.comboBoxTenKH = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxIDSP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainSL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(710, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(710, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID khách hàng";
            // 
            // comboBoxIDNV
            // 
            this.comboBoxIDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIDNV.FormattingEnabled = true;
            this.comboBoxIDNV.Location = new System.Drawing.Point(878, 71);
            this.comboBoxIDNV.Name = "comboBoxIDNV";
            this.comboBoxIDNV.Size = new System.Drawing.Size(127, 33);
            this.comboBoxIDNV.TabIndex = 1;
            // 
            // comboBoxIDKH
            // 
            this.comboBoxIDKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIDKH.FormattingEnabled = true;
            this.comboBoxIDKH.Location = new System.Drawing.Point(878, 24);
            this.comboBoxIDKH.Name = "comboBoxIDKH";
            this.comboBoxIDKH.Size = new System.Drawing.Size(127, 33);
            this.comboBoxIDKH.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1465, 399);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxThanhToan);
            this.panel1.Controls.Add(this.HuyBT);
            this.panel1.Controls.Add(this.NhapBT);
            this.panel1.Controls.Add(this.TaoBT);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(29, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 489);
            this.panel1.TabIndex = 3;
            // 
            // textBoxThanhToan
            // 
            this.textBoxThanhToan.Enabled = false;
            this.textBoxThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxThanhToan.Location = new System.Drawing.Point(1220, 449);
            this.textBoxThanhToan.Name = "textBoxThanhToan";
            this.textBoxThanhToan.Size = new System.Drawing.Size(153, 30);
            this.textBoxThanhToan.TabIndex = 6;
            // 
            // HuyBT
            // 
            this.HuyBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.HuyBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HuyBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuyBT.Location = new System.Drawing.Point(427, 436);
            this.HuyBT.Name = "HuyBT";
            this.HuyBT.Size = new System.Drawing.Size(85, 50);
            this.HuyBT.TabIndex = 3;
            this.HuyBT.Text = "Hủy";
            this.HuyBT.UseVisualStyleBackColor = false;
            this.HuyBT.Click += new System.EventHandler(this.HuyBT_Click);
            // 
            // NhapBT
            // 
            this.NhapBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.NhapBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NhapBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapBT.Location = new System.Drawing.Point(237, 436);
            this.NhapBT.Name = "NhapBT";
            this.NhapBT.Size = new System.Drawing.Size(85, 50);
            this.NhapBT.TabIndex = 3;
            this.NhapBT.Text = "Nháp";
            this.NhapBT.UseVisualStyleBackColor = false;
            this.NhapBT.Click += new System.EventHandler(this.NhapBT_Click);
            // 
            // TaoBT
            // 
            this.TaoBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.TaoBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TaoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaoBT.Location = new System.Drawing.Point(63, 436);
            this.TaoBT.Name = "TaoBT";
            this.TaoBT.Size = new System.Drawing.Size(85, 50);
            this.TaoBT.TabIndex = 3;
            this.TaoBT.Text = "Tạo";
            this.TaoBT.UseVisualStyleBackColor = false;
            this.TaoBT.Click += new System.EventHandler(this.TaoBT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(1002, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng thanh toán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục ";
            // 
            // comboBoxDM
            // 
            this.comboBoxDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDM.FormattingEnabled = true;
            this.comboBoxDM.Location = new System.Drawing.Point(151, 24);
            this.comboBoxDM.Name = "comboBoxDM";
            this.comboBoxDM.Size = new System.Drawing.Size(555, 33);
            this.comboBoxDM.TabIndex = 1;
            this.comboBoxDM.SelectedIndexChanged += new System.EventHandler(this.comboBoxDM_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Sản phẩm";
            // 
            // comboBoxTenSP
            // 
            this.comboBoxTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTenSP.FormattingEnabled = true;
            this.comboBoxTenSP.Location = new System.Drawing.Point(277, 69);
            this.comboBoxTenSP.Name = "comboBoxTenSP";
            this.comboBoxTenSP.Size = new System.Drawing.Size(429, 33);
            this.comboBoxTenSP.TabIndex = 5;
            this.comboBoxTenSP.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenSP_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(726, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // buttonThemSP
            // 
            this.buttonThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.buttonThemSP.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemSP.Location = new System.Drawing.Point(1123, 36);
            this.buttonThemSP.Name = "buttonThemSP";
            this.buttonThemSP.Size = new System.Drawing.Size(239, 49);
            this.buttonThemSP.TabIndex = 3;
            this.buttonThemSP.Text = "Thêm sản phẩm";
            this.buttonThemSP.UseVisualStyleBackColor = false;
            this.buttonThemSP.Click += new System.EventHandler(this.buttonThemSP_Click);
            // 
            // domainSL
            // 
            this.domainSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainSL.Location = new System.Drawing.Point(843, 48);
            this.domainSL.Name = "domainSL";
            this.domainSL.Size = new System.Drawing.Size(114, 30);
            this.domainSL.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxIDDH);
            this.groupBox1.Controls.Add(this.comboBoxTenNV);
            this.groupBox1.Controls.Add(this.comboBoxIDNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxTenKH);
            this.groupBox1.Controls.Add(this.comboBoxIDKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1495, 110);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(176, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "ID Đơn hàng";
            // 
            // textBoxIDDH
            // 
            this.textBoxIDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDDH.Location = new System.Drawing.Point(303, 44);
            this.textBoxIDDH.Name = "textBoxIDDH";
            this.textBoxIDDH.Size = new System.Drawing.Size(181, 30);
            this.textBoxIDDH.TabIndex = 2;
            // 
            // comboBoxTenNV
            // 
            this.comboBoxTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTenNV.FormattingEnabled = true;
            this.comboBoxTenNV.Location = new System.Drawing.Point(1038, 71);
            this.comboBoxTenNV.Name = "comboBoxTenNV";
            this.comboBoxTenNV.Size = new System.Drawing.Size(357, 33);
            this.comboBoxTenNV.TabIndex = 1;
            this.comboBoxTenNV.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenNV_SelectedIndexChanged);
            // 
            // comboBoxTenKH
            // 
            this.comboBoxTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTenKH.FormattingEnabled = true;
            this.comboBoxTenKH.Location = new System.Drawing.Point(1038, 24);
            this.comboBoxTenKH.Name = "comboBoxTenKH";
            this.comboBoxTenKH.Size = new System.Drawing.Size(357, 33);
            this.comboBoxTenKH.TabIndex = 1;
            this.comboBoxTenKH.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenKH_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::DoHoaC_.Properties.Resources.hong;
            this.groupBox2.Controls.Add(this.buttonThemSP);
            this.groupBox2.Controls.Add(this.comboBoxIDSP);
            this.groupBox2.Controls.Add(this.comboBoxTenSP);
            this.groupBox2.Controls.Add(this.domainSL);
            this.groupBox2.Controls.Add(this.comboBoxDM);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1495, 126);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm";
            // 
            // comboBoxIDSP
            // 
            this.comboBoxIDSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIDSP.FormattingEnabled = true;
            this.comboBoxIDSP.Location = new System.Drawing.Point(151, 68);
            this.comboBoxIDSP.Name = "comboBoxIDSP";
            this.comboBoxIDSP.Size = new System.Drawing.Size(106, 33);
            this.comboBoxIDSP.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1176, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nháy chuột 2 lần để xóa sản phẩm";
            // 
            // FormDonHangChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(241)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1549, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Name = "FormDonHangChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainSL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxIDNV;
        private System.Windows.Forms.ComboBox comboBoxIDKH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TaoBT;
        private System.Windows.Forms.Button NhapBT;
        private System.Windows.Forms.Button HuyBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTenSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxThanhToan;
        private System.Windows.Forms.Button buttonThemSP;
        private System.Windows.Forms.NumericUpDown domainSL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxIDSP;
        private System.Windows.Forms.ComboBox comboBoxTenNV;
        private System.Windows.Forms.ComboBox comboBoxTenKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIDDH;
    }
}