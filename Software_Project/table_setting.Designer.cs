namespace Software_Project
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
            this.table_save = new Guna.UI2.WinForms.Guna2Button();
            this.backbutton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // tablechuga
            // 
            this.tablechuga.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tablechuga.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tablechuga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tablechuga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tablechuga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tablechuga.ForeColor = System.Drawing.Color.White;
            this.tablechuga.Location = new System.Drawing.Point(486, 646);
            this.tablechuga.Name = "tablechuga";
            this.tablechuga.Size = new System.Drawing.Size(162, 95);
            this.tablechuga.TabIndex = 0;
            this.tablechuga.Text = "테이블 추가";
            this.tablechuga.Click += new System.EventHandler(this.tablechuga_Click);
            // 
            // table_save
            // 
            this.table_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.table_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.table_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.table_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.table_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.table_save.ForeColor = System.Drawing.Color.White;
            this.table_save.Location = new System.Drawing.Point(306, 644);
            this.table_save.Name = "table_save";
            this.table_save.Size = new System.Drawing.Size(163, 97);
            this.table_save.TabIndex = 1;
            this.table_save.Text = "저장하기";
            this.table_save.Click += new System.EventHandler(this.table_save_Click);
            // 
            // backbutton
            // 
            this.backbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backbutton.ForeColor = System.Drawing.Color.White;
            this.backbutton.Location = new System.Drawing.Point(125, 644);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(163, 97);
            this.backbutton.TabIndex = 2;
            this.backbutton.Text = "뒤로가기";
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // table_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.table_save);
            this.Controls.Add(this.tablechuga);
            this.Name = "table_setting";
            this.Text = "table_setting";
            this.Load += new System.EventHandler(this.table_setting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button tablechuga;
        private Guna.UI2.WinForms.Guna2Button table_save;
        private Guna.UI2.WinForms.Guna2Button backbutton;
    }
}