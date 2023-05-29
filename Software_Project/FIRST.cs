using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class FIRST : Form
    {
        public FIRST()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e) //관리자모드
        {
            this.Visible = false;
            admin_login login = new admin_login("");
            Point parentPoint = this.Location;
            login.StartPosition = FormStartPosition.Manual;
            login.Location = new Point(parentPoint.X, parentPoint.Y);
            login.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main_ui main = new Main_ui();
            Point parentPoint = this.Location; //폼 열리는 위치 설정
            main.StartPosition = FormStartPosition.Manual;
            main.Location = new Point(parentPoint.X, parentPoint.Y);
            main.ShowDialog();
        }
    }
}
