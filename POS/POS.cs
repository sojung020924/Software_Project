
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;



namespace POS
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

    public partial class POS : Form
    {
        public List<location> location_list = new List<location>();
        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();

        public static POS currentinstance; // 뒤로가기를 눌렀을떄 기존의 pos 폼으로 다시 돌아오게 하기 위함.
        private table_setting settingForm;


        private const string ServerIP = "127.0.0.1";
        private const int ServerPort = 1234;

        private TcpListener server;
        private TcpClient client;

        int totcost = 0;
        int maechool = 0;


        public POS()
        {
            InitializeComponent();
            currentinstance = this;

            server = new TcpListener(IPAddress.Any, ServerPort);
            server.Start();

            server.BeginAcceptTcpClient(HandleClientConnection, null);
        }
        private void HandleClientConnection(IAsyncResult result)
        {
            try
            {
                // 클라이언트와의 연결 수락
                client = server.EndAcceptTcpClient(result);

                // 메시지 수신을 위한 스레드 시작
                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                // 예외 처리
                Console.WriteLine("Error: " + ex.Message);
            }

            // 다음 클라이언트 연결을 비동기적으로 수신
            try
            {
                server.BeginAcceptTcpClient(HandleClientConnection, null);
            }catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        private void ReceiveMessages()
        {
            try
            {
                // 클라이언트로부터 메시지를 수신하고 메시지 박스로 표시
                //while (true)
                { for(int i = 0; i <location_list.Count ; i++)
                    {
                        Button targetButton = Controls.OfType<Button>().FirstOrDefault(button => button.Name == i.ToString());
                        if (File.Exists(i.ToString() + ".CSV"))
                        {
                            targetButton.BackColor = Color.Gray;
                        }
                        else
                        {
                            targetButton.BackColor = Color.LightGray;
                        }
                    }
                    // 클라이언트와의 데이터 통신을 위한 네트워크 스트림
                    NetworkStream stream = client.GetStream();

                    // 수신할 데이터를 담을 버퍼
                    byte[] buffer = new byte[1024];

                    // 데이터 수신
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    // 수신된 데이터를 문자열로 변환
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // 수신된 메시지를 메시지 박스로 표시
                    MessageBox.Show(message, "주문 알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // 예외 처리
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // 클라이언트와의 연결 종료
            client?.Close();

            // 서버 소켓 종료
            server?.Stop();
        }


        private void OpenSettingForm()
        {
            if (File.Exists("tablelist.CSV"))
            {
                for(int i = 0; i <location_list.Count ; i++)
                {
                    if(File.Exists(i.ToString() + ".CSV"))
                    {
                        MessageBox.Show("모든 테이블의 결제를 끝내고\n\r다시 실행해주세요.", "실행 실패");
                        return;
                    }
                }
            }
            if (settingForm == null || settingForm.IsDisposed)
            {
                settingForm = new table_setting(this); // SettingForm의 생성자에 PosForm 인스턴스를 전달합니다.

            }
            this.Hide();
            settingForm.Show();
        }

        private Button selectedButton = null;


        //int table_num = 0;
        private void button_click(object sender, EventArgs e)
        {
            totalcost.Text = "";

            // 이전에 선택된 버튼의 색상을 원래대로 되돌립니다.
            if (selectedButton != null)
            {
                if (File.Exists(selectedButton.Name + ".CSV"))
                {
                    selectedButton.BackColor = Color.Gray;
                }
                else
                {
                    selectedButton.BackColor = Color.LightGray;
                }
            }

            // 선택된 버튼에 대한 색상을 변경합니다.
            Button button = (Button)sender;
            button.BackColor = Color.Orange;

            // 선택된 버튼을 추적합니다.        
            selectedButton = button;
            selectedButton.Name = button.Name;

            menupanel.Controls.Clear();
            totalcost.Text = string.Empty;

            ListView menuview = new ListView();
            menuview.Dock = DockStyle.Fill;
            menuview.View = View.Tile;
            menuview.Columns.Add("");
            try
            {
                StreamReader reader = new StreamReader(selectedButton.Name + ".CSV");
                string fline = reader.ReadLine();
                
                List<string[]> mlist = new List<string[]>();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    mlist.Add(values);
                }
                for (int i = 0; i < mlist.Count; i++)
                {
                    totcost += int.Parse(mlist[i][1]);

                    for (int j = 0; j < mlist[0].Length; j++)
                    {

                        string[] m = new string[4];
                        if (j == 3 || j == 4 || j == 5 || j == 6)
                        {
                            m = mlist[i][j].Split('/');
                            if (m[3] == "0")
                                continue;
                            else
                            {
                                //totcost += int.Parse(m[1])*int.Parse(m[3]);
                            }
                        }
                        if (j == 1)
                            continue;
                        else if (j == 0)
                        {
                            ListViewItem item = new ListViewItem("[" + mlist[i][j] + "]");
                            menuview.Items.Add(item);
                        }
                        else if (j == 2)
                        {
                            ListViewItem item = new ListViewItem("메모:" + mlist[i][j]);
                            menuview.Items.Add(item);
                        }
                        else if (j == 7)
                        {
                            ListViewItem item = new ListViewItem("수량: " + mlist[i][j] + "개");
                            menuview.Items.Add(item);
                        }
                        else
                        {
                            ListViewItem item = new ListViewItem(mlist[i][j] + "개");
                            menuview.Items.Add(item);
                        }

                    }
                    menupanel.Controls.Add(menuview);
                    menuview.TileSize = new Size(menuview.ClientSize.Width, menuview.TileSize.Height);
                    menuview.BorderStyle = BorderStyle.None;

                    
                    reader.Close();
                }
                totalcost.Text = (totcost.ToString() + "원");
                totcost = 0;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("빈 테이블 입니다.", "알림");
                Console.WriteLine("File is not exist.");
                menupanel.Controls.Clear();
                totalcost.Text = ("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < location_list.Count; i++)
            {
                RemoveButtonByName(i.ToString());
            }

            try
            {
                location_list.Clear();
                StreamReader streamreader = new StreamReader("tablelist.CSV");

                while (!streamreader.EndOfStream)
                {
                    string line = streamreader.ReadLine();
                    string[] values = line.Split(',');
                    location loc = new location
                    {
                        location_x = int.Parse(values[0]),
                        location_y = int.Parse(values[1]),
                        used = Convert.ToBoolean(values[2])
                    };
                    location_list.Add(loc);
                }
                streamreader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                
            }


            for (int i = 0; i < location_list.Count; i++)
            {

                Button button = new Button();
                button.Size = new Size(131, 62);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("HY견고딕", 10);
                button.Text = "테이블" + (i+1);
                button.Name = i.ToString();
                int x = location_list[i].location_x;
                int y = location_list[i].location_y;
                button.Location = new Point(x, y);
                button.MouseClick += button_click;
                Controls.Add(button);
                if (File.Exists(i.ToString() + ".CSV"))
                {
                    button.BackColor = Color.Gray;
                }
                else
                {
                    button.BackColor = Color.LightGray;
                }
            }

        }

        
        private void RemoveButtonByName(string buttonName)
        {
            Control[] foundButtons = this.Controls.Find(buttonName, true);

            if (foundButtons.Length > 0 && foundButtons[0] is Button)
            {
                Button button = (Button)foundButtons[0];
                this.Controls.Remove(button);
                button.Dispose(); // 선택적으로 버튼을 메모리에서 해제할 수 있습니다.
            }
        }

        private void settablebtn_Click(object sender, EventArgs e)
        {
            OpenSettingForm();
        }

        private void kioskOn_Click(object sender, EventArgs e)
        {
            string kioskpath = Path.Combine("..", "..", "..", "Software_Project", "bin", "Debug") + "\\Software_Project.exe";
            Process.Start(kioskpath);
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (!File.Exists(selectedButton.Name + ".CSV")) //테이블에 내용물이 없는 경우
            {
                return;
            }
            pay Pay = new pay(this, selectedButton.Name, int.Parse(Regex.Replace(totalcost.Text, @"\D", ""))) ;
            Point parentpoint = this.Location;
            Pay.Location = new Point(parentpoint.X, parentpoint.Y);
            Pay.StartPosition = FormStartPosition.Manual;
            //Pay.FormClosed += pay_FormClosed;
            Pay.Show();
            if (!File.Exists(selectedButton.Name + ".CSV"))
            {
                selectedButton.BackColor = Color.LightGray;
                selectedButton = null;

            }
                
        }
        //private void pay_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    // 다른 폼(Form2)이 닫힌 후에 수행할 작업을 여기에 작성합니다.
        //    maechool += int.Parse(Regex.Replace(totalcost.Text, @"\D", ""));
        //    totalmaechool.Text = maechool.ToString() + "원";
        //}

        

        public void Updatemaechool(int value)
        {
            maechool += value;
            totalmaechool.Text = maechool.ToString() + "원";
        }

        private void POS_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sra = new StreamReader(Path.Combine("..", "..", "Properties", "totalmaechool.CSV")))
                {
                    string maechooltext;
                    DateTime dateTime = DateTime.Now;
                    while (!sra.EndOfStream)
                    {
                        string line;
                        line = sra.ReadLine();
                        string[] value = line.Split(',');
                        if (value[0] == dateTime.ToString("yyyy-MM-dd"))
                        {
                            maechooltext = value[1];
                            maechool = int.Parse(Regex.Replace(maechooltext, "[^0-9]", ""));
                            totalmaechool.Text = maechool.ToString() + "원";
                        }
                        else
                        {
                            return;
                        }
                    }
                    sra.Close();
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void POS_FormClosed(object sender, FormClosedEventArgs e)
        {
            string newmaechool = totalmaechool.Text;
            DateTime dateTime = DateTime.Now;

            string text = "";
            if (!File.Exists(Path.Combine("..", "..", "Properties", "totalmaechool.CSV")))
            {
                text = dateTime.ToString("yyyy-MM-dd") + "," + newmaechool.ToString() + '\n';
                StreamWriter sw = new StreamWriter(Path.Combine("..", "..", "Properties", "totalmaechool.CSV"));
                sw.WriteLine(text);
                sw.Close();
            }
            else if (File.Exists(Path.Combine("..", "..", "Properties", "totalmaechool.CSV")))
            {
                
                //try
                {
                    using (StreamReader sr = new StreamReader(Path.Combine("..", "..", "Properties", "totalmaechool.CSV")))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line;
                            line = sr.ReadLine();
                            string[] value = line.Split(',');

                            
                            if (value[0] == dateTime.ToString("yyyy-MM-dd"))
                            {
                                line = value[0] + "," + newmaechool.ToString();
                                text += line;
                                break;
                            }
                            else if (sr.Peek() == -1 && !(value[0] == dateTime.ToString("yyyy-MM-dd")))
                            {
                                text += line;
                                line = dateTime.ToString("yyyy-MM-dd") + "," + newmaechool.ToString() + '\n';
                                text += line;
                                break;
                            }
                            text += line;
                        }
                        sr.Close();
                    }
                    
                    File.Delete((Path.Combine("..", "..", "Properties", "totalmaechool.CSV")));

                    StreamWriter sw = new StreamWriter(Path.Combine("..", "..", "Properties", "totalmaechool.CSV"));
                    sw.WriteLine(text);
                    sw.Close();
                }//catch (Exception ex)
                {

                    //Console.WriteLine(ex.Message);

                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            maechoollist maelist = new maechoollist();
            maelist.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choolgeun geun = new choolgeun();
            geun.ShowDialog();
        }
    }
    public class CsvGenerator
        {
        public void GenerateCsv(List<location> location_list, string filePath)
        {
            
            using (StreamWriter writer = new StreamWriter(filePath))
            {

                // Jangbaguni 리스트의 각 항목을 CSV 파일에 작성
                foreach (location location in location_list)
                {
                    // 각 필드 값을 쉼표로 구분하여 CSV 파일에 작성
                    string line = $"{location.location_x},{location.location_y},{location.used}";
                    writer.WriteLine(line);
                }
                writer.Close();
            }
            
            Console.WriteLine("CSV 파일이 생성되었습니다.");
        }

    }
   
}