namespace Software_Project
{
    partial class table
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
            this.backbutton = new Guna.UI2.WinForms.Guna2Button();
            this.tablegola = new Guna.UI2.WinForms.Guna2Button();
            this.table_num = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backbutton.ForeColor = System.Drawing.Color.White;
            this.backbutton.Location = new System.Drawing.Point(426, 505);
            this.backbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(159, 69);
            this.backbutton.TabIndex = 1;
            this.backbutton.Text = "뒤로가기";
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // tablegola
            // 
            this.tablegola.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tablegola.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tablegola.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tablegola.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tablegola.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tablegola.ForeColor = System.Drawing.Color.White;
            this.tablegola.Location = new System.Drawing.Point(230, 505);
            this.tablegola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablegola.Name = "tablegola";
            this.tablegola.Size = new System.Drawing.Size(159, 69);
            this.tablegola.TabIndex = 2;
            this.tablegola.Text = "고르기";
            this.tablegola.Click += new System.EventHandler(this.tablegola_Click);
            // 
            // table_num
            // 
            this.table_num.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.table_num.DefaultText = "";
            this.table_num.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.table_num.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.table_num.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.table_num.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.table_num.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.table_num.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.table_num.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.table_num.Location = new System.Drawing.Point(386, 447);
            this.table_num.Name = "table_num";
            this.table_num.PasswordChar = '\0';
            this.table_num.PlaceholderText = "";
            this.table_num.SelectedText = "";
            this.table_num.Size = new System.Drawing.Size(200, 38);
            this.table_num.TabIndex = 4;
            // 
            // table
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.table_num);
            this.Controls.Add(this.tablegola);
            this.Controls.Add(this.backbutton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "table";
            this.Text = "table";
            this.Load += new System.EventHandler(this.table_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button backbutton;
        private Guna.UI2.WinForms.Guna2Button tablegola;
        private Guna.UI2.WinForms.Guna2TextBox table_num;
    }
}