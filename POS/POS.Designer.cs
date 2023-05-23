namespace POS
{

    partial class POS
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
            this.loadtablebtn = new System.Windows.Forms.Button();
            this.settablebtn = new System.Windows.Forms.Button();
            this.kioskOn = new Guna.UI2.WinForms.Guna2Button();
            this.totalcost = new Guna.UI2.WinForms.Guna2TextBox();
            this.menupanel = new Guna.UI2.WinForms.Guna2Panel();
            this.paybtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // loadtablebtn
            // 
            this.loadtablebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadtablebtn.Location = new System.Drawing.Point(605, 12);
            this.loadtablebtn.Name = "loadtablebtn";
            this.loadtablebtn.Size = new System.Drawing.Size(174, 75);
            this.loadtablebtn.TabIndex = 0;
            this.loadtablebtn.Text = "테이블 불러오기";
            this.loadtablebtn.UseVisualStyleBackColor = true;
            this.loadtablebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // settablebtn
            // 
            this.settablebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settablebtn.Location = new System.Drawing.Point(605, 93);
            this.settablebtn.Name = "settablebtn";
            this.settablebtn.Size = new System.Drawing.Size(174, 67);
            this.settablebtn.TabIndex = 2;
            this.settablebtn.Text = "테이블 설정";
            this.settablebtn.UseVisualStyleBackColor = true;
            this.settablebtn.Click += new System.EventHandler(this.settablebtn_Click);
            // 
            // kioskOn
            // 
            this.kioskOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kioskOn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kioskOn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kioskOn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kioskOn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kioskOn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kioskOn.ForeColor = System.Drawing.Color.White;
            this.kioskOn.Location = new System.Drawing.Point(605, 166);
            this.kioskOn.Name = "kioskOn";
            this.kioskOn.Size = new System.Drawing.Size(174, 34);
            this.kioskOn.TabIndex = 5;
            this.kioskOn.Text = "키오스크 실행";
            this.kioskOn.Click += new System.EventHandler(this.kioskOn_Click);
            // 
            // totalcost
            // 
            this.totalcost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalcost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalcost.DefaultText = "";
            this.totalcost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalcost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalcost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalcost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalcost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalcost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.totalcost.ForeColor = System.Drawing.Color.Black;
            this.totalcost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalcost.Location = new System.Drawing.Point(605, 348);
            this.totalcost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalcost.Name = "totalcost";
            this.totalcost.PasswordChar = '\0';
            this.totalcost.PlaceholderText = "";
            this.totalcost.SelectedText = "";
            this.totalcost.Size = new System.Drawing.Size(174, 36);
            this.totalcost.TabIndex = 7;
            // 
            // menupanel
            // 
            this.menupanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menupanel.AutoScroll = true;
            this.menupanel.Location = new System.Drawing.Point(605, 206);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(174, 136);
            this.menupanel.TabIndex = 8;
            // 
            // paybtn
            // 
            this.paybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paybtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.paybtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.paybtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.paybtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.paybtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paybtn.ForeColor = System.Drawing.Color.White;
            this.paybtn.Location = new System.Drawing.Point(605, 393);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(174, 45);
            this.paybtn.TabIndex = 0;
            this.paybtn.Text = "결제";
            this.paybtn.Click += new System.EventHandler(this.pay_Click);
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paybtn);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.totalcost);
            this.Controls.Add(this.kioskOn);
            this.Controls.Add(this.settablebtn);
            this.Controls.Add(this.loadtablebtn);
            this.Name = "POS";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadtablebtn;
        private System.Windows.Forms.Button settablebtn;
        private Guna.UI2.WinForms.Guna2Button kioskOn;
        private Guna.UI2.WinForms.Guna2TextBox totalcost;
        private Guna.UI2.WinForms.Guna2Panel menupanel;
        private Guna.UI2.WinForms.Guna2Button paybtn;
    }
}