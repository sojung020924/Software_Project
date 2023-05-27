using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class admin_register : Form
    {
        string code;
        public admin_register(string code)
        {
            InitializeComponent();
            this.code = code;
        }

        private void button1_Click(object sender, EventArgs e)// 확인 버튼 클릭
        {
            if(code == textBox1.Text)
            {
                this.Visible = false;
                admin_register2 reg2 = new admin_register2();
                Point parentPoint = this.Location;
                reg2.StartPosition = FormStartPosition.Manual;
                reg2.Location = new Point(parentPoint.X, parentPoint.Y);
                reg2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("인증번호가 틀렸습니다.", "알림");
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
