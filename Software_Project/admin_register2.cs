using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class admin_register2 : Form
    {
        public admin_register2()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "pw.CSV";

            File.Delete(filePath);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(textBox1.Text);
                writer.Close();
            }
            MessageBox.Show("암호 등록 완료.\n 키오스크에서 다시 로그인 해주세요.", "알림");
            Main_ui main = new Main_ui();
            Point parentPoint = new Point();
            parentPoint = this.Location;
            main.StartPosition = FormStartPosition.Manual;
            main.Location = new Point(parentPoint.X, parentPoint.Y);
            this.Hide();
            main.ShowDialog();
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
