using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class admin_register2 : Form
    {
        public admin_register2()
        {
            InitializeComponent();
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
    }
}
