namespace Software_Project
{
    partial class pos
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
            this.cardbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.kioskOn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // loadtablebtn
            // 
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
            this.settablebtn.Location = new System.Drawing.Point(605, 93);
            this.settablebtn.Name = "settablebtn";
            this.settablebtn.Size = new System.Drawing.Size(174, 67);
            this.settablebtn.TabIndex = 2;
            this.settablebtn.Text = "테이블 설정";
            this.settablebtn.UseVisualStyleBackColor = true;
            this.settablebtn.Click += new System.EventHandler(this.settablebtn_Click);
            // 
            // cardbtn
            // 
            this.cardbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cardbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cardbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cardbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cardbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cardbtn.ForeColor = System.Drawing.Color.White;
            this.cardbtn.Location = new System.Drawing.Point(603, 390);
            this.cardbtn.Name = "cardbtn";
            this.cardbtn.Size = new System.Drawing.Size(81, 51);
            this.cardbtn.TabIndex = 3;
            this.cardbtn.Text = "카드";
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(698, 390);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(81, 51);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "현금";
            // 
            // kioskOn
            // 
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
            // pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kioskOn);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.cardbtn);
            this.Controls.Add(this.settablebtn);
            this.Controls.Add(this.loadtablebtn);
            this.Name = "pos";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadtablebtn;
        private System.Windows.Forms.Button settablebtn;
        private Guna.UI2.WinForms.Guna2Button cardbtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button kioskOn;
    }
}