namespace Software_Project
{
    partial class Main_ui
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_ui));
            this.choose_deopbab = new Guna.UI2.WinForms.Guna2Button();
            this.choose_bockbab = new Guna.UI2.WinForms.Guna2Button();
            this.choose_side = new Guna.UI2.WinForms.Guna2Button();
            this.choose_drink = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HScrollBar1 = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.테이블설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리자모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // choose_deopbab
            // 
            this.choose_deopbab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_deopbab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.choose_deopbab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.choose_deopbab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.choose_deopbab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.choose_deopbab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.choose_deopbab.Font = new System.Drawing.Font("휴먼둥근헤드라인", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.choose_deopbab.ForeColor = System.Drawing.Color.DimGray;
            this.choose_deopbab.Location = new System.Drawing.Point(0, -1);
            this.choose_deopbab.Name = "choose_deopbab";
            this.choose_deopbab.Size = new System.Drawing.Size(176, 133);
            this.choose_deopbab.TabIndex = 0;
            this.choose_deopbab.Text = "덮밥";
            this.choose_deopbab.Click += new System.EventHandler(this.choose_deopbab_Click);
            // 
            // choose_bockbab
            // 
            this.choose_bockbab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_bockbab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.choose_bockbab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.choose_bockbab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.choose_bockbab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.choose_bockbab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.choose_bockbab.Font = new System.Drawing.Font("휴먼둥근헤드라인", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.choose_bockbab.ForeColor = System.Drawing.Color.DimGray;
            this.choose_bockbab.Location = new System.Drawing.Point(0, 138);
            this.choose_bockbab.Name = "choose_bockbab";
            this.choose_bockbab.Size = new System.Drawing.Size(176, 133);
            this.choose_bockbab.TabIndex = 4;
            this.choose_bockbab.Text = "볶음밥";
            this.choose_bockbab.Click += new System.EventHandler(this.choose_bockbab_Click);
            // 
            // choose_side
            // 
            this.choose_side.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_side.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.choose_side.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.choose_side.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.choose_side.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.choose_side.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.choose_side.Font = new System.Drawing.Font("휴먼둥근헤드라인", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.choose_side.ForeColor = System.Drawing.Color.DimGray;
            this.choose_side.Location = new System.Drawing.Point(0, 277);
            this.choose_side.Name = "choose_side";
            this.choose_side.Size = new System.Drawing.Size(176, 133);
            this.choose_side.TabIndex = 5;
            this.choose_side.Text = "사이드";
            this.choose_side.Click += new System.EventHandler(this.choose_side_Click);
            // 
            // choose_drink
            // 
            this.choose_drink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.choose_drink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.choose_drink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.choose_drink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.choose_drink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.choose_drink.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.choose_drink.Font = new System.Drawing.Font("휴먼둥근헤드라인", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.choose_drink.ForeColor = System.Drawing.Color.DimGray;
            this.choose_drink.Location = new System.Drawing.Point(0, 416);
            this.choose_drink.Name = "choose_drink";
            this.choose_drink.Size = new System.Drawing.Size(176, 133);
            this.choose_drink.TabIndex = 6;
            this.choose_drink.Text = "음료";
            this.choose_drink.Click += new System.EventHandler(this.choose_drink_Click);
            // 
            // guna2HScrollBar1
            // 
            this.guna2HScrollBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2HScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2HScrollBar1.InUpdate = false;
            this.guna2HScrollBar1.LargeChange = 8;
            this.guna2HScrollBar1.Location = new System.Drawing.Point(12, 568);
            this.guna2HScrollBar1.Maximum = 20;
            this.guna2HScrollBar1.Minimum = 12;
            this.guna2HScrollBar1.Name = "guna2HScrollBar1";
            this.guna2HScrollBar1.ScrollbarSize = 33;
            this.guna2HScrollBar1.Size = new System.Drawing.Size(658, 33);
            this.guna2HScrollBar1.TabIndex = 11;
            this.guna2HScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2HScrollBar1.ThumbSize = 5F;
            this.guna2HScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.guna2HScrollBar1.Value = 12;
            this.guna2HScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2HScrollBar1_Scroll);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(181, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(500, 550);
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // 테이블설정ToolStripMenuItem
            // 
            this.테이블설정ToolStripMenuItem.Name = "테이블설정ToolStripMenuItem";
            this.테이블설정ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리자모드ToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 725);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리자모드ToolStripMenuItem
            // 
            this.관리자모드ToolStripMenuItem.Name = "관리자모드ToolStripMenuItem";
            this.관리자모드ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.관리자모드ToolStripMenuItem.Text = "관리자 모드";
            this.관리자모드ToolStripMenuItem.Click += new System.EventHandler(this.관리자모드ToolStripMenuItem_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Button1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.guna2Button1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Location = new System.Drawing.Point(0, 555);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(682, 198);
            this.guna2Button1.TabIndex = 12;
            // 
            // Main_ui
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.guna2HScrollBar1);
            this.Controls.Add(this.choose_deopbab);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.choose_drink);
            this.Controls.Add(this.choose_side);
            this.Controls.Add(this.choose_bockbab);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_ui";
            this.Text = "Main_ui";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button choose_deopbab;
        private Guna.UI2.WinForms.Guna2Button choose_bockbab;
        private Guna.UI2.WinForms.Guna2Button choose_side;
        private Guna.UI2.WinForms.Guna2Button choose_drink;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 테이블설정ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리자모드ToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HScrollBar guna2HScrollBar1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

