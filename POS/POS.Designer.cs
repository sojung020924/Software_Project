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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.loadtablebtn = new System.Windows.Forms.Button();
            this.settablebtn = new System.Windows.Forms.Button();
            this.kioskOn = new Guna.UI2.WinForms.Guna2Button();
            this.totalcost = new Guna.UI2.WinForms.Guna2TextBox();
            this.menupanel = new Guna.UI2.WinForms.Guna2Panel();
            this.paybtn = new Guna.UI2.WinForms.Guna2Button();
            this.totalmaechool = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadtablebtn
            // 
            this.loadtablebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.loadtablebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loadtablebtn.FlatAppearance.BorderSize = 2;
            this.loadtablebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadtablebtn.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loadtablebtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loadtablebtn.Location = new System.Drawing.Point(691, 15);
            this.loadtablebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadtablebtn.Name = "loadtablebtn";
            this.loadtablebtn.Size = new System.Drawing.Size(199, 94);
            this.loadtablebtn.TabIndex = 0;
            this.loadtablebtn.Text = "테이블 불러오기";
            this.loadtablebtn.UseVisualStyleBackColor = false;
            this.loadtablebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // settablebtn
            // 
            this.settablebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settablebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.settablebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.settablebtn.FlatAppearance.BorderSize = 2;
            this.settablebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settablebtn.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.settablebtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settablebtn.Location = new System.Drawing.Point(691, 116);
            this.settablebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settablebtn.Name = "settablebtn";
            this.settablebtn.Size = new System.Drawing.Size(199, 84);
            this.settablebtn.TabIndex = 2;
            this.settablebtn.Text = "테이블 설정";
            this.settablebtn.UseVisualStyleBackColor = false;
            this.settablebtn.Click += new System.EventHandler(this.settablebtn_Click);
            // 
            // kioskOn
            // 
            this.kioskOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kioskOn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kioskOn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kioskOn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kioskOn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kioskOn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kioskOn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kioskOn.ForeColor = System.Drawing.Color.White;
            this.kioskOn.Location = new System.Drawing.Point(691, 208);
            this.kioskOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kioskOn.Name = "kioskOn";
            this.kioskOn.Size = new System.Drawing.Size(199, 42);
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
            this.totalcost.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalcost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalcost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalcost.Location = new System.Drawing.Point(691, 435);
            this.totalcost.Margin = new System.Windows.Forms.Padding(5);
            this.totalcost.Name = "totalcost";
            this.totalcost.PasswordChar = '\0';
            this.totalcost.PlaceholderText = "";
            this.totalcost.SelectedText = "";
            this.totalcost.Size = new System.Drawing.Size(199, 45);
            this.totalcost.TabIndex = 7;
            // 
            // menupanel
            // 
            this.menupanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menupanel.AutoScroll = true;
            this.menupanel.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menupanel.Location = new System.Drawing.Point(691, 258);
            this.menupanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(199, 170);
            this.menupanel.TabIndex = 8;
            // 
            // paybtn
            // 
            this.paybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paybtn.BorderRadius = 10;
            this.paybtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.paybtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.paybtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.paybtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.paybtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.paybtn.Font = new System.Drawing.Font("HY견고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.paybtn.ForeColor = System.Drawing.Color.White;
            this.paybtn.Location = new System.Drawing.Point(691, 491);
            this.paybtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(199, 56);
            this.paybtn.TabIndex = 0;
            this.paybtn.Text = "결제";
            this.paybtn.Click += new System.EventHandler(this.pay_Click);
            // 
            // totalmaechool
            // 
            this.totalmaechool.Location = new System.Drawing.Point(570, 521);
            this.totalmaechool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalmaechool.Name = "totalmaechool";
            this.totalmaechool.ReadOnly = true;
            this.totalmaechool.Size = new System.Drawing.Size(114, 25);
            this.totalmaechool.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "매출 총액";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalmaechool);
            this.Controls.Add(this.paybtn);
            this.Controls.Add(this.menupanel);
            this.Controls.Add(this.totalcost);
            this.Controls.Add(this.kioskOn);
            this.Controls.Add(this.settablebtn);
            this.Controls.Add(this.loadtablebtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "POS";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.POS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadtablebtn;
        private System.Windows.Forms.Button settablebtn;
        private Guna.UI2.WinForms.Guna2Button kioskOn;
        private Guna.UI2.WinForms.Guna2TextBox totalcost;
        private Guna.UI2.WinForms.Guna2Panel menupanel;
        private Guna.UI2.WinForms.Guna2Button paybtn;
        private System.Windows.Forms.TextBox totalmaechool;
        private System.Windows.Forms.Label label1;
    }
}