namespace Software_Project
{
    partial class gyeoljae
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
            this.total = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.backbutton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // total
            // 
            this.total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.total.DefaultText = "";
            this.total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total.Location = new System.Drawing.Point(395, 527);
            this.total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.PlaceholderText = "";
            this.total.SelectedText = "";
            this.total.Size = new System.Drawing.Size(229, 48);
            this.total.TabIndex = 6;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(69, 330);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(279, 342);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // backbutton
            // 
            this.backbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backbutton.ForeColor = System.Drawing.Color.White;
            this.backbutton.Location = new System.Drawing.Point(396, 610);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(228, 62);
            this.backbutton.TabIndex = 8;
            this.backbutton.Text = "뒤로가기";
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // gyeoljae
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.total);
            this.Name = "gyeoljae";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.gyeoljae_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox total;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button backbutton;
    }
}