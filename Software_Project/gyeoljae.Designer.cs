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
            this.card = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cash = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cancel = new Guna.UI2.WinForms.Guna2CircleButton();
            this.total = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // card
            // 
            this.card.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.card.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.card.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.card.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.card.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.card.ForeColor = System.Drawing.Color.White;
            this.card.Location = new System.Drawing.Point(69, 100);
            this.card.Name = "card";
            this.card.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.card.Size = new System.Drawing.Size(148, 148);
            this.card.TabIndex = 3;
            this.card.Text = "card";
            this.card.Click += new System.EventHandler(this.card_Click);
            // 
            // cash
            // 
            this.cash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cash.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cash.ForeColor = System.Drawing.Color.White;
            this.cash.Location = new System.Drawing.Point(292, 100);
            this.cash.Name = "cash";
            this.cash.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cash.Size = new System.Drawing.Size(148, 148);
            this.cash.TabIndex = 4;
            this.cash.Text = "cash";
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // cancel
            // 
            this.cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(508, 100);
            this.cancel.Name = "cancel";
            this.cancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cancel.Size = new System.Drawing.Size(148, 148);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "cancel";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
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
            this.total.Location = new System.Drawing.Point(391, 445);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(366, 299);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 146);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // gyeoljae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 745);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.card);
            this.Name = "gyeoljae";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.gyeoljae_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton card;
        private Guna.UI2.WinForms.Guna2CircleButton cash;
        private Guna.UI2.WinForms.Guna2CircleButton cancel;
        private Guna.UI2.WinForms.Guna2TextBox total;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}