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
            this.choose_drink = new Guna.UI2.WinForms.Guna2Button();
            this.choose_side = new Guna.UI2.WinForms.Guna2Button();
            this.choose_bockbab = new Guna.UI2.WinForms.Guna2Button();
            this.bag = new Guna.UI2.WinForms.Guna2TextBox();
            this.choose_deopbab = new Guna.UI2.WinForms.Guna2Button();
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
            // bag
            // 
            this.bag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bag.DefaultText = "";
            this.bag.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bag.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bag.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bag.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bag.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bag.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bag.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bag.Location = new System.Drawing.Point(-1, 549);
            this.bag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bag.Name = "bag";
            this.bag.PasswordChar = '\0';
            this.bag.PlaceholderText = "";
            this.bag.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.bag.SelectedText = "";
            this.bag.Size = new System.Drawing.Size(684, 204);
            this.bag.TabIndex = 14;
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
            // Drink
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.choose_drink);
            this.Controls.Add(this.choose_side);
            this.Controls.Add(this.choose_bockbab);
            this.Controls.Add(this.bag);
            this.Controls.Add(this.choose_deopbab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Drink";
            this.Text = "DrinkForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button choose_drink;
        private Guna.UI2.WinForms.Guna2Button choose_side;
        private Guna.UI2.WinForms.Guna2Button choose_bockbab;
        private Guna.UI2.WinForms.Guna2TextBox bag;
        private Guna.UI2.WinForms.Guna2Button choose_deopbab;
    }
}