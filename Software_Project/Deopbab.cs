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

namespace Software_Project
{
    public partial class Deopbab : Form
    {
        public Deopbab()
        {
            InitializeComponent();
        }

        private void Deopbab_Load(object sender, EventArgs e)
        {

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
        public static List<List<string>> ReadCsvFile(string filePath) //메뉴 csv 파일 읽기
        {
            List<List<string>> data = new List<List<string>>();
            using (var reader = new StreamReader(filePath))
            {
                string[] headers = reader.ReadLine().Split(','); //앞부분은 스키마이므로 생략
                int numColumns = headers.Length;
                while (!reader.EndOfStream)
                {
                    string[] row = reader.ReadLine().Split(',');
                    if (row.Length != numColumns)
                    {
                        continue;//잘못된 정보의 경우
                    }
                    List<string> rowData = new List<string>(row);
                    data.Add(rowData);
                }
            }
            return data;
        }
        public void Make_button(List<List<string>> list) //동적으로 메뉴 버튼 만들기
        {
            int num = list.Count;
            while (num > 0)
            {
                Button dynamicButton = new Button();
                dynamicButton.Name = "dynamicButton";
                dynamicButton.Text = "Click Me";
                dynamicButton.Location = new Point(50, 50);
                dynamicButton.Size = new Size(100, 30);
                this.Controls.Add(dynamicButton);
            }
        }
    }
}
