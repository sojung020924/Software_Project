using Guna.UI2.WinForms;
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
    public partial class Bockbab : Form
    {
        public Bockbab()
        {
            InitializeComponent();
        }
        private void Bockbab_Load(object sender, EventArgs e)
        {
            ReadCsvFile("menu.csv",flowLayoutPanel1);
        }
        private void choose_deopbab_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Deopbab deopbab = new Deopbab();
            Point parentPoint = this.Location;
            deopbab.StartPosition = FormStartPosition.Manual;
            deopbab.Location = new Point(parentPoint.X, parentPoint.Y);
            deopbab.ShowDialog();
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

        public static void ReadCsvFile(string filePath, FlowLayoutPanel panel) //메뉴 csv 파일 읽기
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
                    if (row[2] == "볶음밥")
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
            Make_button(data, panel);
        }
        public static void Make_button(List<List<string>> list, FlowLayoutPanel panel) //동적으로 메뉴 버튼 만들기
        {
            int num = list.Count;
            List<Guna2Button> buttonList = new List<Guna2Button>();

            // 버튼 생성 및 속성 설정 후 리스트에 추가
            for (int i = 0; i < num; i++)
            {
                //버튼 생성
                Guna2Button button = new Guna2Button();
                button.Name = "button" + i.ToString();
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
            }
        }

    }
}
