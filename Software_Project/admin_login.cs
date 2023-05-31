using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class admin_login : Form
    {
        string code = "";
        public admin_login(string code)
        {
            InitializeComponent();
            this.code = code;

            textBox1.PasswordChar = '*';
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// 암호초기화버튼 클릭
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            code = "";

            for (int i = 0; i < 5; i++)
            {
                code += chars[random.Next(chars.Length)];
            }

            string serverIP = "127.0.0.1";
            int serverPort = 1234;

            try
            {
                // 소켓 생성 및 서버에 연결
                using (TcpClient client = new TcpClient(serverIP, serverPort))
                {
                    // 전송할 메시지
                    string message = code;

                    // 메시지를 UTF-8로 인코딩하여 바이트 배열로 변환
                    byte[] buffer = Encoding.UTF8.GetBytes(message);

                    // 서버로 메시지 전송
                    NetworkStream stream = client.GetStream();
                    stream.Write(buffer, 0, buffer.Length);
                    stream.Flush();

                    // 메시지 전송 후, pos.cs에서 메시지 박스 표시
                    //MessageBox.Show(message, "주문 알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // 예외 처리
                Console.WriteLine("Error: " + ex.Message);
            }
            this.Visible = false;
            admin_register reg = new admin_register(code);
            Point parentPoint = this.Location;
            reg.StartPosition = FormStartPosition.Manual;
            reg.Location = new Point(parentPoint.X, parentPoint.Y);
            reg.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pw;
            using (StreamReader reader = new StreamReader("pw.CSV"))
            {
                pw = reader.ReadLine();

                if (pw == textBox1.Text)
                {
                    admin admin = new admin();
                    Point parentPoint = this.Location;
                    admin.StartPosition = FormStartPosition.Manual;
                    admin.Location = new Point(parentPoint.X, parentPoint.Y);
                    admin.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("암호가 틀렸습니다.", "알림");
                }
                reader.Close();
            }


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }
    }
}
