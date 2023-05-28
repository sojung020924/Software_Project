namespace POS
{
    partial class pay
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
            this.paypanel = new System.Windows.Forms.Panel();
            this.cardpay = new Guna.UI2.WinForms.Guna2Button();
            this.cashpay = new Guna.UI2.WinForms.Guna2Button();
            this.paycosttxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totcosttxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.totalbtn = new Guna.UI2.WinForms.Guna2Button();
            this.selectcancel = new Guna.UI2.WinForms.Guna2Button();
            this.sellistView = new System.Windows.Forms.ListView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // paypanel
            // 
            this.paypanel.Location = new System.Drawing.Point(0, 0);
            this.paypanel.Name = "paypanel";
            this.paypanel.Size = new System.Drawing.Size(433, 152);
            this.paypanel.TabIndex = 0;
            // 
            // cardpay
            // 
            this.cardpay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cardpay.BorderRadius = 5;
            this.cardpay.BorderThickness = 2;
            this.cardpay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cardpay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cardpay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cardpay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cardpay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cardpay.Font = new System.Drawing.Font("휴먼둥근헤드라인", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cardpay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cardpay.Location = new System.Drawing.Point(225, 287);
            this.cardpay.Name = "cardpay";
            this.cardpay.Size = new System.Drawing.Size(94, 87);
            this.cardpay.TabIndex = 0;
            this.cardpay.Text = "카드";
            this.cardpay.Click += new System.EventHandler(this.cardpay_Click);
            // 
            // cashpay
            // 
            this.cashpay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cashpay.BorderRadius = 5;
            this.cashpay.BorderThickness = 2;
            this.cashpay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cashpay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cashpay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cashpay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cashpay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cashpay.Font = new System.Drawing.Font("휴먼둥근헤드라인", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cashpay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cashpay.Location = new System.Drawing.Point(325, 287);
            this.cashpay.Name = "cashpay";
            this.cashpay.Size = new System.Drawing.Size(93, 87);
            this.cashpay.TabIndex = 1;
            this.cashpay.Text = "현금";
            this.cashpay.Click += new System.EventHandler(this.cashpay_Click);
            // 
            // paycosttxt
            // 
            this.paycosttxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paycosttxt.DefaultText = "";
            this.paycosttxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.paycosttxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.paycosttxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paycosttxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paycosttxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paycosttxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paycosttxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paycosttxt.Location = new System.Drawing.Point(83, 339);
            this.paycosttxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paycosttxt.Name = "paycosttxt";
            this.paycosttxt.PasswordChar = '\0';
            this.paycosttxt.PlaceholderText = "";
            this.paycosttxt.SelectedText = "";
            this.paycosttxt.Size = new System.Drawing.Size(119, 35);
            this.paycosttxt.TabIndex = 2;
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.CausesValidation = false;
            this.cost.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cost.Location = new System.Drawing.Point(2, 347);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(71, 16);
            this.cost.TabIndex = 3;
            this.cost.Text = "결제금액";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("HY견고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(2, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "남은금액";
            // 
            // totcosttxt
            // 
            this.totcosttxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totcosttxt.DefaultText = "";
            this.totcosttxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totcosttxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totcosttxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totcosttxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totcosttxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totcosttxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totcosttxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totcosttxt.Location = new System.Drawing.Point(83, 289);
            this.totcosttxt.Margin = new System.Windows.Forms.Padding(5);
            this.totcosttxt.Name = "totcosttxt";
            this.totcosttxt.PasswordChar = '\0';
            this.totcosttxt.PlaceholderText = "";
            this.totcosttxt.ReadOnly = true;
            this.totcosttxt.SelectedText = "";
            this.totcosttxt.Size = new System.Drawing.Size(119, 37);
            this.totcosttxt.TabIndex = 5;
            // 
            // totalbtn
            // 
            this.totalbtn.BorderRadius = 15;
            this.totalbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.totalbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.totalbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.totalbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.totalbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalbtn.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalbtn.ForeColor = System.Drawing.Color.White;
            this.totalbtn.Location = new System.Drawing.Point(5, 380);
            this.totalbtn.Name = "totalbtn";
            this.totalbtn.Size = new System.Drawing.Size(95, 35);
            this.totalbtn.TabIndex = 6;
            this.totalbtn.Text = "전체 선택";
            this.totalbtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // selectcancel
            // 
            this.selectcancel.BorderRadius = 15;
            this.selectcancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.selectcancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.selectcancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selectcancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.selectcancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.selectcancel.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectcancel.ForeColor = System.Drawing.Color.White;
            this.selectcancel.Location = new System.Drawing.Point(107, 380);
            this.selectcancel.Name = "selectcancel";
            this.selectcancel.Size = new System.Drawing.Size(95, 35);
            this.selectcancel.TabIndex = 7;
            this.selectcancel.Text = "선택 취소";
            this.selectcancel.Click += new System.EventHandler(this.selectcancel_Click);
            // 
            // sellistView
            // 
            this.sellistView.HideSelection = false;
            this.sellistView.Location = new System.Drawing.Point(0, 158);
            this.sellistView.Name = "sellistView";
            this.sellistView.Size = new System.Drawing.Size(433, 123);
            this.sellistView.TabIndex = 0;
            this.sellistView.UseCompatibleStateImageBehavior = false;
            this.sellistView.View = System.Windows.Forms.View.Tile;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(320, 380);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(95, 35);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "뒤로가기";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button2.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(208, 380);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(95, 35);
            this.guna2Button2.TabIndex = 9;
            this.guna2Button2.Text = "주문취소";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 427);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.sellistView);
            this.Controls.Add(this.selectcancel);
            this.Controls.Add(this.totalbtn);
            this.Controls.Add(this.totcosttxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.paycosttxt);
            this.Controls.Add(this.cashpay);
            this.Controls.Add(this.cardpay);
            this.Controls.Add(this.paypanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "pay";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.pay_FormClosed);
            this.Load += new System.EventHandler(this.pay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paypanel;
        private Guna.UI2.WinForms.Guna2Button cardpay;
        private Guna.UI2.WinForms.Guna2Button cashpay;
        private Guna.UI2.WinForms.Guna2TextBox paycosttxt;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox totcosttxt;
        private Guna.UI2.WinForms.Guna2Button totalbtn;
        private Guna.UI2.WinForms.Guna2Button selectcancel;
        private System.Windows.Forms.ListView sellistView;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}