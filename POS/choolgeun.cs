using System;
using System.IO;
using System.Windows.Forms;

namespace POS
{
    public partial class choolgeun : Form
    {
        public choolgeun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//출근 버튼
        {
            DateTime dateTime = DateTime.Now;
            string text = "";
            string line = dateTime.ToString("MM-dd-HH-mm") + "," + textBox1.Text + "," + "출근";
            if (File.Exists(Path.Combine("..", "..", "Properties", "geunmoo.CSV")))
            {
                using (StreamReader sr = new StreamReader(Path.Combine("..", "..", "Properties", "geunmoo.CSV")))
                {
                    while (!sr.EndOfStream)
                    {
                        string line2 = sr.ReadLine();
                        string[] value = line2.Split(',');
                        string[] value2 = value[0].Split('-');
                        string line3 = value2[0] + "-" + value2[1];
                        if (dateTime.ToString("MM-dd") == line3 && value[1] == textBox1.Text && value[2] == "출근")
                        {
                            MessageBox.Show("이미 출근 상태입니다.", "알림");
                            sr.Close();
                            this.Close();
                            return;
                        }
                    }
                }

                using (StreamWriter sw = File.AppendText(Path.Combine("..", "..", "Properties", "geunmoo.CSV")))
                {

                    sw.WriteLine(line);
                    sw.Close();
                    MessageBox.Show("출근 완료!", "알림");
                    this.Close();
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine("..", "..", "Properties", "geunmoo.CSV")))
                {
                    sw.WriteLine(line);
                    sw.Close();
                    MessageBox.Show("출근 완료!", "알림");
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//퇴근 버튼
        {
            DateTime dateTime = DateTime.Now;
            string line = dateTime.ToString("MM-dd-HH-mm") + "," + textBox1.Text + "," + "퇴근";
            if (File.Exists(Path.Combine("..", "..", "Properties", "geunmoo.CSV")))
            {
                bool chool = false; //true면 출근 상태, false 면 퇴근상태
                using (StreamReader sr = new StreamReader(Path.Combine("..", "..", "Properties", "geunmoo.CSV")))
                {
                    while (!sr.EndOfStream)
                    {
                        string line2 = sr.ReadLine();
                        string[] value = line2.Split(',');
                        string[] value2 = value[0].Split('-');
                        string line3 = value2[0] + "-" + value2[1];
                        if (dateTime.ToString("MM-dd") == line3 && value[1] == textBox1.Text)
                        {
                            if (value[2] == "퇴근")
                            {
                                chool = false;
                                //MessageBox.Show("이미 퇴근 처리 되었습니다.", "알림");
                            }
                            else
                            {
                                chool = true;
                            }
                        }
                        if (sr.Peek() == -1 && chool == false)
                        {
                            MessageBox.Show("출근 처리가 필요합니다.", "알림");
                            sr.Close();
                            this.Close();
                        }
                    }
                }

                using (StreamWriter sw = File.AppendText(Path.Combine("..", "..", "Properties", "geunmoo.CSV")))
                {
                    sw.WriteLine(line);
                    sw.Close();
                    MessageBox.Show("퇴근 완료!", "알림");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("저장된 출/퇴근 기록이 없습니다.", "알림");
            }
        }
    }

}
