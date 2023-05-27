namespace POS
{
    partial class table_setting
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
            this.tablechuga = new Guna.UI2.WinForms.Guna2Button();
            this.reset = new Guna.UI2.WinForms.Guna2Button();
            this.backbutton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // tablechuga
            // 
            this.tablechuga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tablechuga.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tablechuga.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tablechuga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tablechuga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tablechuga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tablechuga.ForeColor = System.Drawing.Color.White;
            this.tablechuga.Location = new System.Drawing.Point(625, 49);
            this.tablechuga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablechuga.Name = "tablechuga";
            this.tablechuga.Size = new System.Drawing.Size(143, 78);
            this.tablechuga.TabIndex = 0;
            this.tablechuga.Text = "테이블 추가";
            this.tablechuga.Click += new System.EventHandler(this.tablechuga_Click);
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(625, 174);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(143, 78);
            this.reset.TabIndex = 1;
            this.reset.Text = "초기화";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // backbutton
            // 
            this.backbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backbutton.ForeColor = System.Drawing.Color.White;
            this.backbutton.Location = new System.Drawing.Point(625, 297);
            this.backbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(143, 78);
            this.backbutton.TabIndex = 2;
            this.backbutton.Text = "뒤로가기";
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // table_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.tablechuga);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "table_setting";
            this.Text = "table_setting";
            this.Load += new System.EventHandler(this.table_setting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button tablechuga;
        private Guna.UI2.WinForms.Guna2Button reset;
        private Guna.UI2.WinForms.Guna2Button backbutton;
    }
}