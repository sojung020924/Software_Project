namespace Software_Project
{
    partial class Drink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drink));
            this.choose_drink = new Guna.UI2.WinForms.Guna2Button();
            this.choose_side = new Guna.UI2.WinForms.Guna2Button();
            this.choose_bockbab = new Guna.UI2.WinForms.Guna2Button();
            this.choose_deopbab = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Total_cost = new System.Windows.Forms.TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // choose_drink
            // 
            this.choose_drink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_drink.Checked = true;
            this.choose_drink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.choose_drink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.choose_drink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.choose_drink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.choose_drink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.choose_drink.Font = new System.Drawing.Font("휴먼둥근헤드라인", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.choose_drink.ForeColor = System.Drawing.Color.DimGray;
            this.choose_drink.Location = new System.Drawing.Point(-1, 417);
            this.choose_drink.Name = "choose_drink";
            this.choose_drink.Size = new System.Drawing.Size(176, 133);
            this.choose_drink.TabIndex = 17;
            this.choose_drink.Text = "음료";
            // 
            // choose_side
            // 
            this.choose_side.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_side.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.choose_side.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.choose_side.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.choose_side.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.choose_side.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.choose_side.Font = new System.Drawing.Font("휴먼둥근헤드라인", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.choose_side.ForeColor = System.Drawing.Color.DimGray;
            this.choose_side.Location = new System.Drawing.Point(-1, 278);
            this.choose_side.Name = "choose_side";
            this.choose_side.Size = new System.Drawing.Size(176, 133);
            this.choose_side.TabIndex = 16;
            this.choose_side.Text = "사이드";
            this.choose_side.Click += new System.EventHandler(this.choose_side_Click);
            // 
            // choose_bockbab
            // 
            this.choose_bockbab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_bockbab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.choose_bockbab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.choose_bockbab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.choose_bockbab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.choose_bockbab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.choose_bockbab.Font = new System.Drawing.Font("휴먼둥근헤드라인", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.choose_bockbab.ForeColor = System.Drawing.Color.DimGray;
            this.choose_bockbab.Location = new System.Drawing.Point(-1, 139);
            this.choose_bockbab.Name = "choose_bockbab";
            this.choose_bockbab.Size = new System.Drawing.Size(176, 133);
            this.choose_bockbab.TabIndex = 15;
            this.choose_bockbab.Text = "볶음밥";
            this.choose_bockbab.Click += new System.EventHandler(this.choose_bockbab_Click);
            // 
            // choose_deopbab
            // 
            this.choose_deopbab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_deopbab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.choose_deopbab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.choose_deopbab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.choose_deopbab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.choose_deopbab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.choose_deopbab.Font = new System.Drawing.Font("휴먼둥근헤드라인", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.choose_deopbab.ForeColor = System.Drawing.Color.DimGray;
            this.choose_deopbab.Location = new System.Drawing.Point(-1, 0);
            this.choose_deopbab.Name = "choose_deopbab";
            this.choose_deopbab.Size = new System.Drawing.Size(176, 133);
            this.choose_deopbab.TabIndex = 13;
            this.choose_deopbab.Text = "덮밥";
            this.choose_deopbab.Click += new System.EventHandler(this.choose_deopbab_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(178, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(505, 550);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // Total_cost
            // 
            this.Total_cost.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Total_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total_cost.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Total_cost.Location = new System.Drawing.Point(553, 556);
            this.Total_cost.Multiline = true;
            this.Total_cost.Name = "Total_cost";
            this.Total_cost.Size = new System.Drawing.Size(128, 83);
            this.Total_cost.TabIndex = 26;
            this.Total_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total_cost.TextChanged += new System.EventHandler(this.Total_cost_TextChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Button2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.guna2Button2.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(553, 712);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(128, 41);
            this.guna2Button2.TabIndex = 25;
            this.guna2Button2.Text = "메인으로";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(553, 645);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(128, 65);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "결정하기";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Wheat;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 550);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(551, 204);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // Drink
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.choose_deopbab);
            this.Controls.Add(this.Total_cost);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.choose_drink);
            this.Controls.Add(this.choose_side);
            this.Controls.Add(this.choose_bockbab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Drink";
            this.Text = "DrinkForm1";
            this.Load += new System.EventHandler(this.Drink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button choose_drink;
        private Guna.UI2.WinForms.Guna2Button choose_side;
        private Guna.UI2.WinForms.Guna2Button choose_bockbab;
        private Guna.UI2.WinForms.Guna2Button choose_deopbab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Total_cost;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}