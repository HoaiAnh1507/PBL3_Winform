namespace DoHoaC_
{
    partial class FormDangNhap
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
            this.textBoxTenDN = new System.Windows.Forms.TextBox();
            this.textBoxMatkhau = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DangNhapBT = new System.Windows.Forms.Button();
            this.ThoatBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTenDN
            // 
            this.textBoxTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenDN.Location = new System.Drawing.Point(231, 82);
            this.textBoxTenDN.Name = "textBoxTenDN";
            this.textBoxTenDN.Size = new System.Drawing.Size(240, 26);
            this.textBoxTenDN.TabIndex = 0;
            // 
            // textBoxMatkhau
            // 
            this.textBoxMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatkhau.Location = new System.Drawing.Point(231, 148);
            this.textBoxMatkhau.Name = "textBoxMatkhau";
            this.textBoxMatkhau.PasswordChar = '*';
            this.textBoxMatkhau.Size = new System.Drawing.Size(240, 26);
            this.textBoxMatkhau.TabIndex = 1;
            this.textBoxMatkhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMatkhau_KeyDown);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(87, 82);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(124, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu: ";
            // 
            // DangNhapBT
            // 
            this.DangNhapBT.BackColor = System.Drawing.Color.PowderBlue;
            this.DangNhapBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhapBT.Location = new System.Drawing.Point(136, 201);
            this.DangNhapBT.Name = "DangNhapBT";
            this.DangNhapBT.Size = new System.Drawing.Size(129, 62);
            this.DangNhapBT.TabIndex = 4;
            this.DangNhapBT.Text = "Đăng nhập";
            this.DangNhapBT.UseVisualStyleBackColor = false;
            this.DangNhapBT.Click += new System.EventHandler(this.DangNhapBT_Click);
            // 
            // ThoatBT
            // 
            this.ThoatBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ThoatBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoatBT.Location = new System.Drawing.Point(320, 201);
            this.ThoatBT.Name = "ThoatBT";
            this.ThoatBT.Size = new System.Drawing.Size(129, 62);
            this.ThoatBT.TabIndex = 5;
            this.ThoatBT.Text = "Thoát";
            this.ThoatBT.UseVisualStyleBackColor = false;
            this.ThoatBT.Click += new System.EventHandler(this.ThoatBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đăng nhập";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(598, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThoatBT);
            this.Controls.Add(this.DangNhapBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxMatkhau);
            this.Controls.Add(this.textBoxTenDN);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDangNhap_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTenDN;
        private System.Windows.Forms.TextBox textBoxMatkhau;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DangNhapBT;
        private System.Windows.Forms.Button ThoatBT;
        private System.Windows.Forms.Label label1;
    }
}