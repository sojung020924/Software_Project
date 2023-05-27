using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Software_Project.Main_ui;
using static System.Net.Mime.MediaTypeNames;

namespace Software_Project
{
    public partial class Choose : FormBase
    {
        public delegate void FormSendDataHandler(Jangbaguni jang); //대리자
        public event FormSendDataHandler chooseSendEvent;
        string Current_menu;
        List<List<string>> option_list = new List<List<string>>();
        List<TextBox> option_txt = new List<TextBox>(); //추가된 버튼 리스트
        int price = 0;

        float fontsize = 10;

        public Choose(string name, float fontsize)
        {
            InitializeComponent();
            Current_menu = name;
            Menu_name.Text = "[ " + name + " ]";
            this.fontsize = fontsize;
        }
        private void Choose_Load(object sender, EventArgs e)
        {
            setting("menu.CSV");
            ChangeFontSize(fontsize);
        }

        private void setting(string filePath) //옵션 깔기
        {
            List<List<string>> data = new List<List<string>>();
            var reader = new StreamReader(filePath);
            
            string[] headers = reader.ReadLine().Split(','); //앞부분은 스키마이므로 생략
            while (!reader.EndOfStream) // 메뉴파일 다시 읽기
            {
                string[] row = new string[4];
                row = reader.ReadLine().Split(',');
                row[3] = "0"; //장바구니에 담긴 수량 넣기
                List<string> rowData = new List<string>(row);
                data.Add(rowData);
                if (row[2] == "옵션")
                {
                    option_list.Add(rowData);
                }
            }
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i][0] == Current_menu)
                {
                    price = Convert.ToInt32(data[i][1]); //총 가격 초기화

                    total.Text = "총 " + data[i][1] +" 원";
                    if (data[i][2] == "덮밥" || data[i][2] == "볶음밥")
                    {
                        make_option(option_list, option_panel);
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }
        private void make_option(List<List<string>> list, FlowLayoutPanel panel) {
            List<Guna2Button> buttonList = new List<Guna2Button>();
            for (int i = 0; i < list.Count; i++)
            {
                Guna2Button button = new Guna2Button();
                button.Name = list[i][0];
                button.Text = list[i][0] + "\n[" + list[i][1] + "원]";
                button.ForeColor = Color.DimGray;
                button.FillColor = Color.AntiqueWhite;
                button.Font = new Font("휴먼둥근헤드라인", 10);
                button.TextAlign = HorizontalAlignment.Center;
                button.Size = new Size(150, 70);
                panel.Controls.Add(button);
                button.Click += button_Click;
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, EventArgs e) //옵션 클릭
        {
            Guna2Button btn = (Guna2Button)sender;
            string name = btn.Name;
            choosed_option(name, choosed_option_panel);
        }

        private void choosed_option(string name, FlowLayoutPanel panel) //옵션 선택한 것 버튼 추가
        {
            int num=0;
            int i;
            for (i = 0;i<option_list.Count;i++)
            {
                if (option_list[i][0] == name)
                {
                    num =Convert.ToInt32(option_list[i][3]);
                    //장바구니 수량 수정
                    num++;
                    option_list[i][3] = Convert.ToString(num);
                    price_setting(Convert.ToInt32(option_list[i][1]), true, total); //가격 수정
                }

            }
            if(num == 1) //새롭게 누른 경우
            { //새롭게 박스를 생성
                System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
                System.Windows.Forms.Button plus = new System.Windows.Forms.Button();
                System.Windows.Forms.Button minus = new System.Windows.Forms.Button();

                //박스 설정
                txt.Name = name;
                txt.Multiline= true;
                txt.Height = 60;
                txt.Width = 164;
                txt.Text = "\r\n" + name + "\r\n수량: " + num + "개";
                txt.ForeColor = System.Drawing.Color.SlateGray;
                txt.HideSelection= false;
                txt.Font = new Font("휴먼둥근헤드라인", 10);
                txt.TextAlign = HorizontalAlignment.Center;

                //+,- 버튼 넣기
                plus.Name= name; //현재 무슨 버튼인지 알아보기 위해
                plus.Text = "+";
                plus.Size = new Size(30, 10);
                plus.Dock = DockStyle.Right;
                plus.FlatStyle = FlatStyle.Flat;
                plus.FlatAppearance.BorderSize = 0;
                plus.BackColor = Color.Coral;
                plus.Click += plus_Click;
                txt.Controls.Add(plus);
                minus.Name= name;
                minus.Text = "-";
                minus.Dock = DockStyle.Left;
                minus.Size = new Size(30,10);
                minus.FlatStyle = FlatStyle.Flat;
                minus.FlatAppearance.BorderSize = 0;
                minus.BackColor = Color.Coral;
                minus.Click += minus_Click;
                txt.Controls.Add(minus);


                //판넬에 추가
                panel.Controls.Add(txt);
                option_txt.Add(txt);

            }
            else //있던 것을 누른 경우
            {
                for (int j =0; j< option_txt.Count;j++)
                {
                    if(option_txt[j].Name == name) //현재 수량을 추가한 것인 경우
                    {
                        option_txt[j].Text = "\r\n" + name + "\r\n수량: " + num + "개";
                        break;
                    }
                }
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Button btn =(Button)sender;
            int num = 0;
            for (int i = 0; i < option_list.Count; i++)
            {
                if (option_list[i][0] == btn.Name)
                {
                    num = Convert.ToInt32(option_list[i][3]);
                    //장바구니 수량 수정
                    num++;
                    price_setting(Convert.ToInt32(option_list[i][1]), true, total); //가격 수정
                    option_list[i][3] = Convert.ToString(num);
                    for (int j = 0; j < option_txt.Count; j++)
                    {
                        if (option_txt[j].Name == btn.Name) //현재 수량을 추가한 것인 경우
                        {
                            option_txt[j].Text = "\r\n" + btn.Name + "\r\n수량: " + num + "개";
                            break;
                        }
                    }
                    break;
                }


            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int num = 0;
            for (int i = 0; i < option_list.Count; i++)
            {
                if (option_list[i][0] == btn.Name)
                {
                    price_setting(Convert.ToInt32(option_list[i][1]), false, total); //가격 수정
                    num = Convert.ToInt32(option_list[i][3]);
                    //장바구니 수량 수정
                    num--;
                    option_list[i][3] = Convert.ToString(num);
                    for (int j = 0; j < option_txt.Count; j++)
                    {
                        if (option_txt[j].Name == btn.Name) //현재 수량을 뺀 것인 경우
                        {   
                            if(num == 0)//수량이 0인 경우
                            {
                                get_out(option_txt[j], choosed_option_panel);
                                break;
                            }
                            option_txt[j].Text = "\r\n" + btn.Name + "\r\n수량: " + num + "개";
                            break;
                        }
                    }
                    break;
                }


            }
        }

        private void price_setting(int pri, bool oper,Guna2TextBox txtbox) //true : plus, false : minus
        {
            if(oper == true)
            {
                price += pri;
            }
            else
            {
                price -= pri;
            }
            txtbox.Text = "총 " + price.ToString() + " 원"; ;
        }
        private void get_out(TextBox box, FlowLayoutPanel panel)
        {
            panel.Controls.Remove(box);
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) //텍스트 입력하기 전 안내문자
        {
            this.Controls.Remove(info);
        }

        private void guna2Button1_Click(object sender, EventArgs e) //장바구니 담기 클릭
        {
            Jangbaguni j = new Jangbaguni();
            j.menu_name = Current_menu;
            j.total_price = price;
            j.options = option_list; //옵션들 넣기 (옵션이름, 옵션 총 가격, "옵션" ,옵션 총 수량)
            j.memo = guna2TextBox1.Text;
            j.count = 1;
            this.chooseSendEvent(j);
            this.Close();
        }
    }
}
