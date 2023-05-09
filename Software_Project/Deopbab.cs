using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;
using System.Net;


namespace Software_Project
{
    public partial class Deopbab : Form
    {
        public Jangbaguni jangbaguni;
        public Deopbab()
        {
            InitializeComponent();
        }

        private void Deopbab_Load(object sender, EventArgs e)
        {
            ReadCsvFile("menu.csv",flowLayoutPanel1);

        }

        private void choose_bockbab_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Bockbab bockbab = new Bockbab();
            Point parentPoint = this.Location;
            bockbab.StartPosition = FormStartPosition.Manual;
            bockbab.Location = new Point(parentPoint.X, parentPoint.Y);
            bockbab.ShowDialog();
        }

        private void choose_side_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Side side = new Side();
            Point parentPoint = this.Location;
            side.StartPosition = FormStartPosition.Manual;
            side.Location = new Point(parentPoint.X, parentPoint.Y);
            side.ShowDialog();
        }

        private void choose_drink_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Drink drink = new Drink();
            Point parentPoint = this.Location;
            drink.StartPosition = FormStartPosition.Manual;
            drink.Location = new Point(parentPoint.X, parentPoint.Y);
            drink.ShowDialog();
        }
        public void ReadCsvFile(string filePath, FlowLayoutPanel panel) //메뉴 csv 파일 읽기
        {
            List<List<string>> data = new List<List<string>>();
            try
            {
                var reader = new StreamReader(filePath, Encoding.Default);
                
                string[] headers = reader.ReadLine().Split(','); //앞부분은 스키마이므로 생략
                int numColumns = headers.Length;
                while (!reader.EndOfStream)
                {
                    string[] row = reader.ReadLine().Split(',');
                    List<string> rowData = new List<string>(row);
                    if (row[2] == "덮밥")
                    {
                       data.Add(rowData);
                    }
                    
                }
            }
            catch
            {
                Console.WriteLine($"Error reading CSV file: 오류입니다. ");
                return;
            }
            Make_menu_button(data,panel);
        }
        public void Make_menu_button(List<List<string>> list, FlowLayoutPanel panel) //동적으로 메뉴 버튼 만들기
        {
            int num = list.Count;
            List<Guna2Button> buttonList = new List<Guna2Button>();

            // 버튼 생성 및 속성 설정 후 리스트에 추가
            for (int i = 0; i < num; i++)
            {
                //버튼 생성
                Guna2Button button = new Guna2Button();
                button.Name = list[i][0];
                button.Text = list[i][0] + "\n[" + list[i][1] + "원]";
                button.Size = new Size(237, 180);
                button.BorderThickness = 1;

                //폰트 설정
                button.ForeColor = Color.DimGray;
                button.FillColor = Color.AntiqueWhite;
                button.Font = new Font("휴먼둥근헤드라인", 10);
                button.TextAlign = HorizontalAlignment.Center;


                //이미지 설정
                button.Image = Image.FromFile(list[i][0] + ".jpg");
                button.ImageSize = new Size(150, 90);
                button.ImageOffset = new Point(35, -15);
                button.TextOffset = new Point(0, 55);
                button.ImageAlign = HorizontalAlignment.Left;
                panel.Controls.Add(button);
                button.Click += button_Click;
            }
        }
        public void button_Click(object sender, EventArgs e)
        {
            //현재 메뉴 탐색
            Guna2Button btn = (Guna2Button)sender;
            string name = btn.Name;
            Choose choose= new Choose(name);
            choose.chooseSendEvent += new Choose.FormSendDataHandler(add_Choose);
            Point parentPoint = this.Location;
            choose.StartPosition = FormStartPosition.Manual;
            choose.Location = new Point(parentPoint.X, parentPoint.Y);
            choose.ShowDialog();
        }

        public void add_Choose(Jangbaguni jan) //장바구니에 추가가 됐을 때
        {
            string option = "";
            int num = jan.options.Count;
            for (int i=0; i< num; i++) //박스에 띄울 옵션 넣기
            {
                if (jan.options[i][3] != "0")
                {
                    option += jan.options[i][0] + " " + jan.options[i][3] + "개   ";
                }

            }
            Button button = new Button();
            Button X_button = new Button();
            Button plus= new Button();
            Button minus= new Button();
            Label price = new Label();
            TextBox box = new TextBox();
            plus.Text = "+";
            plus.Dock = DockStyle.Right;
            plus.Size = new Size(35, 35);
            plus.FlatStyle = FlatStyle.Flat;
            minus.Text = "-";
            minus.Dock = DockStyle.Left;
            minus.Size = new Size(35, 35);
            minus.FlatStyle = FlatStyle.Flat;
            box.Text = "\r\n" + jan.count.ToString() + " 개";
            box.TextAlign = HorizontalAlignment.Center;
            box.Multiline= true;
            box.Size = new Size(120,35);
            box.Location = new Point(250,8);
            box.Controls.Add(plus);
            box.Controls.Add(minus);
            price.Text = Convert.ToString(jan.total_price) + " 원    ";
            price.TextAlign= ContentAlignment.MiddleRight;
            price.Dock = DockStyle.Right;
            X_button.Text = "X";
            X_button.Font = new Font("휴먼둥근헤드라인", 12);
            X_button.Dock = DockStyle.Right;
            X_button.Size = new Size(50,50);
            X_button.FlatStyle = FlatStyle.Flat;
            X_button.FlatAppearance.BorderSize = 0;
            X_button.ForeColor = Color.Gray;
            X_button.BackColor = Color.Coral;
            X_button.Click += clear_menu;
            button.Controls.Add(price);
            button.Controls.Add(X_button);
            button.Controls.Add(box);
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Name = jan.menu_name + jan.memo;
            button.Text = jan.menu_name + "\r\n" + option  ;
            button.ForeColor = Color.WhiteSmoke;
            button.BackColor = Color.SandyBrown;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("휴먼둥근헤드라인", 8);
            button.Size = new Size(525, 50);
            push_janbaguni_panel(flowLayoutPanel2, button);
        }

        public void clear_menu(object sender, EventArgs e)
        {
            Control button = ((Control)sender).Parent;
            flowLayoutPanel2.Controls.Remove(button);
        }
        public void push_janbaguni_panel(FlowLayoutPanel panel, Button btn )
        {
            panel.Controls.Add(btn);
        }
    }
}
