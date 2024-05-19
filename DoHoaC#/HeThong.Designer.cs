namespace DoHoaC_
{
    partial class HeThong
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
            this.label2 = new System.Windows.Forms.Label();
            this.BTdoimk = new System.Windows.Forms.Button();
            this.BTdangxuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(677, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bạn đang sử dụng với tư cách là admin";
            // 
            // BTdoimk
            // 
            this.BTdoimk.BackColor = System.Drawing.Color.PowderBlue;
            this.BTdoimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdoimk.Location = new System.Drawing.Point(565, 496);
            this.BTdoimk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTdoimk.Name = "BTdoimk";
            this.BTdoimk.Size = new System.Drawing.Size(207, 70);
            this.BTdoimk.TabIndex = 19;
            this.BTdoimk.Text = "Đổi mật khẩu";
            this.BTdoimk.UseVisualStyleBackColor = false;
            // 
            // BTdangxuat
            // 
            this.BTdangxuat.BackColor = System.Drawing.Color.PowderBlue;
            this.BTdangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdangxuat.Location = new System.Drawing.Point(844, 496);
            this.BTdangxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTdangxuat.Name = "BTdangxuat";
            this.BTdangxuat.Size = new System.Drawing.Size(207, 70);
            this.BTdangxuat.TabIndex = 20;
            this.BTdangxuat.Text = "Đăng xuất";
            this.BTdangxuat.UseVisualStyleBackColor = false;
            this.BTdangxuat.Click += new System.EventHandler(this.BTdangxuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoHoaC_.Properties.Resources.logomoi;
            this.pictureBox1.Location = new System.Drawing.Point(0, 207);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 478);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Pristina", 39F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(452, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 87);
            this.label1.TabIndex = 24;
            this.label1.Text = "Welcome to Hanami Pet Shop";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTdangxuat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BTdoimk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 685);
            this.panel1.TabIndex = 25;
            // 
            // HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::DoHoaC_.Properties.Resources.hong;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HeThong";
            this.Size = new System.Drawing.Size(1549, 685);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTdoimk;
        private System.Windows.Forms.Button BTdangxuat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
