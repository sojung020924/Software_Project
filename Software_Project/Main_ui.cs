using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Software_Project
{
    public struct Jangbaguni_button_set
    {
        public Jangbaguni jangbaguni;
        public Button btn;
    }
    public struct location
    {
        public int location_x;
        public int location_y;
        public bool used; //테이블이 사용 중이 아니면 false, 사용 중이면 true
    }

    public struct Jangbaguni
    {
        public string menu_name;
        public int total_price;
        public string memo;
        public List<List<string>> options;
        public int count;
    }
    public partial class Main_ui : FormBase
    {
        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();

        float fontsize = 10;
        public Main_ui()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeFontSize(fontsize);
        }

        private void choose_deopbab_Click(object sender, EventArgs e)
        {
            this.Visible = false; //현재창 숨김
            Deopbab deopbab = new Deopbab(jan_btn_combi, fontsize); //객체 생성
            deopbab.ChangeFontSize(fontsize);
            Point parentPoint = this.Location; //폼 열리는 위치 설정
            deopbab.StartPosition = FormStartPosition.Manual;
            deopbab.Location = new Point(parentPoint.X, parentPoint.Y);
            deopbab.ShowDialog(); //폼 open
            this.Close();
        }

        private void choose_bockbab_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Bockbab bockbab = new Bockbab(jan_btn_combi, fontsize);
            bockbab.ChangeFontSize(fontsize);
            Point parentPoint = this.Location;
            bockbab.StartPosition = FormStartPosition.Manual;
            bockbab.Location = new Point(parentPoint.X, parentPoint.Y);
            bockbab.ShowDialog();
            this.Close();
        }

        private void choose_side_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Side side = new Side(jan_btn_combi, fontsize);
            side.ChangeFontSize(fontsize);
            Point parentPoint = this.Location;
            side.StartPosition = FormStartPosition.Manual;
            side.Location = new Point(parentPoint.X, parentPoint.Y);
            side.ShowDialog();
            this.Close();
        }

        private void choose_drink_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Drink drink = new Drink(jan_btn_combi, fontsize);
            drink.ChangeFontSize(fontsize);
            Point parentPoint = this.Location;
            drink.StartPosition = FormStartPosition.Manual;
            drink.Location = new Point(parentPoint.X, parentPoint.Y);
            drink.ShowDialog();
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void 관리자모드ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            admin_login login = new admin_login("");
            Point parentPoint = this.Location;
            login.StartPosition = FormStartPosition.Manual;
            login.Location = new Point(parentPoint.X, parentPoint.Y);
            login.ShowDialog();
        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            fontsize = guna2HScrollBar1.Value;
            ChangeFontSize(fontsize);
        }
    }

}
