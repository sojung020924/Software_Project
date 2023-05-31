using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class table : FormBase
    {
        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();

        public List<location> location_list = new List<location>();


        float fontsize = 10;
        //private pos posform;
        public table(List<Jangbaguni_button_set> list, List<location> loc_list, float fontsize)
        {
            InitializeComponent();
            jan_btn_combi = list;
            location_list = loc_list;
            this.fontsize = fontsize;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 폼의 테두리 스타일을 고정으로 설정
            this.MinimumSize = new Size(698, 792);
            this.MaximumSize = new Size(698, 792);
            this.MinimumSize = this.MaximumSize = this.Size; // 최소 크기와 최대 크기를 현재 크기로 설정

            ChangeFontSize(fontsize);
        }

        private void table_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader streamreader = new StreamReader(Path.Combine("..", "..", "..", "POS", "bin", "Debug", "tablelist.CSV"));

                while (!streamreader.EndOfStream)
                {
                    string line = streamreader.ReadLine();
                    string[] values = line.Split(',');
                    location loc = new location
                    {
                        location_x = int.Parse(values[0]),
                        location_y = int.Parse(values[1]),
                        used = bool.Parse(values[2]),
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
                if (location_list[i].used == true)
                {
                    button.BackColor = Color.Red;
                }
                button.BackColor = Color.Gray;
                button.Size = new Size(131, 62);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("HY견고딕", 10);
                button.Text = "테이블" + (i + 1).ToString();
                button.Name = i.ToString();
                int x = location_list[i].location_x;
                int y = location_list[i].location_y;
                button.Location = new Point(x, y + 80);
                button.MouseClick += button_click;
                if (location_list[i].used == true)
                    button.BackColor = Color.Red;
                Controls.Add(button);
            }

        }
        private Button selectedButton = null;
        private void button_click(object sender, EventArgs e)
        {

            // 이전에 선택된 버튼의 색상을 원래대로 되돌립니다.
            if (selectedButton != null)
            {
                if (selectedButton.BackColor == Color.Blue)
                {
                    selectedButton.BackColor = Color.Gray;
                }
            }

            // 선택된 버튼에 대한 색상을 변경합니다.
            Button button = (Button)sender;
            if (button.BackColor == Color.Red)
            {
                if (MessageBox.Show("기존에 주문한 내역이 있는 테이블입니다. \n\r추가하시겠습니까?", "사용 중인 테이블", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

            }
            else
            {
                button.BackColor = Color.Blue;
            }

            // 선택된 버튼을 추적합니다.
            table_num.Font = new Font("HY견고딕", 15);
            table_num.Text = "고른 테이블: " + button.Text + " 번";
            selectedButton = button;
            selectedButton.Name = button.Name;
        }
        private void backbutton_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            gyeoljae g = new gyeoljae(jan_btn_combi, location_list, fontsize);
            Point parentPoint = this.Location;
            g.StartPosition = FormStartPosition.Manual;
            g.Location = new Point(parentPoint.X, parentPoint.Y);
            g.ShowDialog();
        }
        public List<Jangbaguni> menulist = new List<Jangbaguni>();



        private void tablegola_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < jan_btn_combi.Count; i++)
            {
                menulist.Add(jan_btn_combi[i].jangbaguni);
            }
            if (selectedButton == null)
            {
                MessageBox.Show("테이블을 선택해주세요.", "테이블 선택은 필수!");
                return;
            }


            location loc = new location
            {
                location_x = selectedButton.Location.X,
                location_y = selectedButton.Location.Y,
                used = true
            };
            location_list[int.Parse(selectedButton.Name)] = loc;

            string serverIP = "127.0.0.1";
            int serverPort = 1234;

            try
            {
                // 소켓 생성 및 서버에 연결
                using (TcpClient client = new TcpClient(serverIP, serverPort))
                {
                    // 전송할 메시지
                    string message = (int.Parse(selectedButton.Name) + 1).ToString() + "번 테이블에서 주문이 들어왔습니다!";

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



            CsvGenerator menucsv = new CsvGenerator();
            menucsv.GenerateCsv(menulist, Path.Combine("..", "..", "..", "POS", "bin", "Debug", selectedButton.Name + ".CSV"));
            CsvGenerator tablecsv = new CsvGenerator();
            tablecsv.bGenerateCsv(location_list, Path.Combine("..", "..", "..", "POS", "bin", "Debug", "tablelist.CSV"), int.Parse(selectedButton.Name));
            location_list[int.Parse(selectedButton.Name)] = loc;


            //메뉴 화면으로 돌아가기
            this.Visible = false;
            Main_ui main_ui = new Main_ui();
            Point parentPoint = this.Location;
            main_ui.StartPosition = FormStartPosition.Manual;
            main_ui.Location = new Point(parentPoint.X, parentPoint.Y);
            main_ui.ShowDialog();
            this.Close();
        }
    }
    public class CsvGenerator
    {
        public void GenerateCsv(List<Jangbaguni> jangbaguniList, string filePath)
        {
            if (File.Exists(filePath)) //테이블에 기존 내용이 있을 때
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();
                foreach (Jangbaguni jangbaguni in jangbaguniList) //추가한 메뉴를 넣기
                {
                    lines.Add($"{jangbaguni.menu_name},{jangbaguni.total_price},{jangbaguni.memo},{OptionsToString(jangbaguni.options)},{jangbaguni.count}");
                }
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    // CSV 파일의 헤더 작성
                    writer.WriteLine("Menu Name,Total Price,Memo,Options,Count");

                    // Jangbaguni 리스트의 각 항목을 CSV 파일에 작성
                    foreach (Jangbaguni jangbaguni in jangbaguniList)
                    {
                        // 각 필드 값을 쉼표로 구분하여 CSV 파일에 작성
                        string line = $"{jangbaguni.menu_name},{jangbaguni.total_price},{jangbaguni.memo},{OptionsToString(jangbaguni.options)},{jangbaguni.count}";
                        writer.WriteLine(line);
                    }
                    writer.Close();

                }
            }

            Console.WriteLine("CSV 파일이 생성되었습니다.");
        }
        public void bGenerateCsv(List<location> location_list, string filePath, int currentline) //테이블 메뉴 수정
        {
            currentline++;
            int lineCount = 1;
            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    lines.Add(line);
                    if (lineCount == currentline)
                    {
                        // 수정해야 할 줄을 찾았을 때, 새로운 값을 준비합니다.
                        string newLine = $"{location_list[currentline - 1].location_x.ToString()},{location_list[currentline - 1].location_y.ToString()},{location_list[currentline - 1].used.ToString()}";
                        lines[lineCount - 1] = newLine;
                    }
                    lineCount++;
                }
                reader.Close();
            }

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
                writer.Close();
            }


        }
        private string OptionsToString(List<List<string>> options)
        {
            // Options 리스트의 각 항목을 쉼표로 구분하여 하나의 문자열로 만듦
            List<string> optionStrings = new List<string>();
            foreach (List<string> option in options)
            {
                string optionString = string.Join("/", option);
                optionStrings.Add(optionString);
            }

            return string.Join(",", optionStrings);
        }
    }

}
