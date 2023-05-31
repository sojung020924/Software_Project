using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace POS
{

    public partial class pay : Form
    {
        List<location> location_list = new List<location>();

        private POS posForm;

        string selectedbutton;
        int totalcost = 0;
        int payedcost;
        ListView menuview = new ListView();
        public pay(POS pos, string selectedbutton, int totalcost)
        {
            InitializeComponent();


            posForm = pos;

            this.selectedbutton = selectedbutton;
            this.totalcost = totalcost;
            payedcost = totalcost;
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
        }

        private void pay_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(selectedbutton + ".CSV");
            string mline = reader.ReadLine();
            string[] value = mline.Split(',');

            menuview.Dock = DockStyle.Fill;
            menuview.View = View.Details;
            menuview.Scrollable = false;
            menuview.FullRowSelect = true;
            menuview.Columns.Add("Menu");
            menuview.Columns.Add("총 금액");
            menuview.Columns.Add("수량");
            menuview.MouseDoubleClick += menuview_MouseDoubleClick;

            int colwidth = paypanel.ClientSize.Width / menuview.Columns.Count;
            for (int i = 0; i < menuview.Columns.Count; i++)
            {
                ColumnHeader column = menuview.Columns[i];
                column.Width = colwidth;
            }

            while (!reader.EndOfStream)
            {
                mline = reader.ReadLine();
                string[] values = mline.Split(',');
                menuview.BeginUpdate();

                ListViewItem lv = new ListViewItem(values[0]);
                lv.SubItems.Add(values[1]);
                //totalcost += int.Parse(values[1]);
                //여기에 옵션 출력코드 추가해야함.
                lv.SubItems.Add(values[7]);
                menuview.Items.Add(lv);
            }

            paypanel.Controls.Add(menuview);
            reader.Close();

            totcosttxt.Text = totalcost.ToString();
            paycosttxt.Text = "0";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            paycosttxt.Text = totalcost.ToString();
            ListView listview1 = menuview;
            ListView listview2 = sellistView;
            while (listview1.Items.Count > 0)
            {
                ListViewItem item = listview1.Items[0];
                listview1.Items.Remove(item);
                listview2.Items.Add(item);
            }


        }
        // ListView의 ItemSelectionChanged 이벤트 핸들러

        int selectcost = 0;
        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string column1Value = e.Item.SubItems[1].Text;
                selectcost += int.Parse(column1Value);
            }

            paycosttxt.Text = selectcost.ToString();
        }

        private void selectcancel_Click(object sender, EventArgs e)
        {
            ListView listview1 = menuview;
            ListView listview2 = sellistView;
            if (listview2.Items.Count == 0)
            {
                MessageBox.Show("선택된 메뉴가 없습니다.", "알림");
                return;
            }

            while (listview2.Items.Count > 0)
            {
                ListViewItem item = listview2.Items[0];
                sellistView.Items.Remove(item);
                menuview.Items.Add(item); //수정한것
            }
            paycosttxt.Text = "0";
            selectcost = 0;

        }

        private void cardpay_Click(object sender, EventArgs e)
        {
            if (int.Parse(paycosttxt.Text) == 0)
            {
                MessageBox.Show("금액을 선택해주세요.", "알림");
            }
            else if (int.Parse(paycosttxt.Text) < 0)
            {
                MessageBox.Show("0원 이상의 금액을 입력해주세요.", "알림");
            }
            else
            {
                totalcost = totalcost - int.Parse(paycosttxt.Text);
                if (totalcost == 0)
                {
                    MessageBox.Show("결제가 완료 되었습니다.", "알림");
                    this.Close();

                    posForm.Updatemaechool(payedcost);

                    location loc = new location()
                    {
                        location_x = location_list[int.Parse(selectedbutton)].location_x,
                        location_y = location_list[int.Parse(selectedbutton)].location_y,
                        used = false
                    };
                    location_list[int.Parse(selectedbutton)] = loc;
                    bGenerateCsv(location_list, "tablelist.CSV", int.Parse(selectedbutton));
                    File.Delete(selectedbutton + ".CSV");

                    return;
                }
                MessageBox.Show("카드 결제가 완료되었습니다.\n" + "남은 금액: " + totalcost.ToString() + "원", "알림"); ;
                paycosttxt.Text = "0";
                selectcost = 0;
                totcosttxt.Text = totalcost.ToString();
                sellistView.Clear();
            }

        }

        private void cashpay_Click(object sender, EventArgs e)
        {
            if (int.Parse(paycosttxt.Text) == 0)
            {
                MessageBox.Show("금액을 선택해주세요.", "알림");
            }
            else if (int.Parse(paycosttxt.Text) < 0)
            {
                MessageBox.Show("0원 이상의 금액을 입력해주세요.", "알림");
            }
            else
            {
                totalcost = totalcost - int.Parse(paycosttxt.Text);

                if (totalcost == 0)
                {
                    MessageBox.Show("결제가 완료 되었습니다.", "알림");
                    this.Close();


                    posForm.Updatemaechool(payedcost);
                    location loc = new location()
                    {
                        location_x = location_list[int.Parse(selectedbutton)].location_x,
                        location_y = location_list[int.Parse(selectedbutton)].location_y,
                        used = false
                    };
                    location_list[int.Parse(selectedbutton)] = loc;
                    bGenerateCsv(location_list, "tablelist.CSV", int.Parse(selectedbutton));
                    File.Delete(selectedbutton + ".CSV"); //결제 완료 했으니까 파일 삭제


                    return;
                }
                MessageBox.Show("현금 결제가 완료되었습니다.\n" + "남은 금액: " + totalcost.ToString() + "원", "알림"); ;
                paycosttxt.Text = "0";
                selectcost = 0;
                totcosttxt.Text = totalcost.ToString();
                sellistView.Clear();
            }
        }

        private void menuview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListView listView1 = (ListView)sender;//클릭해서 고른 것 
                ListView listView2 = sellistView; // 다른 ListView 컨트롤의 인스턴스
                ListViewItem selected = listView1.SelectedItems[0]; //클릭한 것의 이름
                listView1.Items.Remove(selected);
                listView2.Items.Add(selected);
                string secondCol = selected.SubItems[1].Text;
                selectcost += int.Parse(secondCol); //계산
            }
            paycosttxt.Text = selectcost.ToString();

        }
        // ItemSelectionChanged 이벤트 핸들러 연결
        public void bGenerateCsv(List<location> location_list, string filePath, int currentline)
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
            }

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }


        }

        private void pay_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e) //뒤로가기 버튼
        {
            ListView listview1 = menuview;
            ListView listview2 = sellistView;
            if (listview2.Items.Count != 0)
            {
                MessageBox.Show("선택된 메뉴를 취소해주세요.", "알림");
                return;
            }

            var reader = new StreamReader(selectedbutton + ".CSV", Encoding.UTF8);
            string[] headers = reader.ReadLine().Split(','); //앞부분은 스키마이므로 생략

            List<List<string>> data = new List<List<string>>();
            int num = 0;
            while (!reader.EndOfStream) //현재 테이블의 모든 메뉴를 순회하면서
            {

                string[] row = reader.ReadLine().Split(',');

                for (int i = 0; i < listview1.Items.Count; i++)
                {
                    ListViewItem item = listview1.Items[i];
                    num++;
                    string menuname = item.SubItems[0].Text;
                    int menucost = int.Parse(item.SubItems[1].Text);
                    int menucount = int.Parse(item.SubItems[2].Text);
                    // row의 첫 번째 요소와 메뉴 이름 비교
                    if (menuname == row[0] && menucost / menucount == int.Parse(row[1]) / int.Parse(row[7]))
                    {
                        List<string> buf = new List<string>(row);
                        data.Add(buf);
                    }

                }


            }
            reader.Close();
            this.Close();
            File.Delete(selectedbutton + ".CSV");
            using (StreamWriter writer = new StreamWriter(selectedbutton + ".CSV"))
            {
                writer.WriteLine(headers[0] + "," + headers[1] + "," + headers[2] + "," + headers[3] + "," + headers[4]);
                foreach (List<string> line in data)
                {
                    writer.WriteLine(line[0] + "," + line[1] + "," + line[2] + "," + line[3] + "," + line[4] + "," + line[5] + "," + line[6] + "," + line[7]); // 새로운 파일에 라인 쓰기
                }
            }
            posForm.Updatemaechool(payedcost - totalcost);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            totalcost = totalcost - int.Parse(paycosttxt.Text);
            paycosttxt.Text = "0";
            selectcost = 0;
            totcosttxt.Text = totalcost.ToString();
            sellistView.Clear();
            if (totalcost == 0) //만약에 모든 메뉴를 삭제한 경우
            {
                this.Close();
                location loc = new location()
                {
                    location_x = location_list[int.Parse(selectedbutton)].location_x,
                    location_y = location_list[int.Parse(selectedbutton)].location_y,
                    used = false
                };
                location_list[int.Parse(selectedbutton)] = loc;
                bGenerateCsv(location_list, "tablelist.CSV", int.Parse(selectedbutton));
                File.Delete(selectedbutton + ".CSV");
            }
        }

        private void totcosttxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
