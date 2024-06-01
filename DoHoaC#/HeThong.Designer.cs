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
            this.BTdoimk = new System.Windows.Forms.Button();
            this.BTdangxuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTdoimk
            // 
            this.BTdoimk.BackColor = System.Drawing.SystemColors.Info;
            this.BTdoimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdoimk.Location = new System.Drawing.Point(424, 403);
            this.BTdoimk.Margin = new System.Windows.Forms.Padding(2);
            this.BTdoimk.Name = "BTdoimk";
            this.BTdoimk.Size = new System.Drawing.Size(155, 57);
            this.BTdoimk.TabIndex = 19;
            this.BTdoimk.Text = "Đổi mật khẩu";
            this.BTdoimk.UseVisualStyleBackColor = false;
            this.BTdoimk.Click += new System.EventHandler(this.BTdoimk_Click);
            // 
            // BTdangxuat
            // 
            this.BTdangxuat.BackColor = System.Drawing.SystemColors.Info;
            this.BTdangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdangxuat.Location = new System.Drawing.Point(633, 403);
            this.BTdangxuat.Margin = new System.Windows.Forms.Padding(2);
            this.BTdangxuat.Name = "BTdangxuat";
            this.BTdangxuat.Size = new System.Drawing.Size(155, 57);
            this.BTdangxuat.TabIndex = 20;
            this.BTdangxuat.Text = "Đăng xuất";
            this.BTdangxuat.UseVisualStyleBackColor = false;
            this.BTdangxuat.Click += new System.EventHandler(this.BTdangxuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Pristina", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(241, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 90);
            this.label1.TabIndex = 24;
            this.label1.Text = "Welcome to Hanami Pet Shop";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BackgroundImage = global::DoHoaC_.Properties.Resources._23085108_9b1b_4448_a3f4_3d19f55de095;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTdangxuat);
            this.panel1.Controls.Add(this.BTdoimk);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 557);
            this.panel1.TabIndex = 25;
            // 
            // HeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::DoHoaC_.Properties.Resources.hong;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HeThong";
            this.Size = new System.Drawing.Size(1162, 557);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTdoimk;
        private System.Windows.Forms.Button BTdangxuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
