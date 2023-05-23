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
using ClassLibrary2;

namespace POS
{
    
    public partial class pay : Form
    {
        List<location> location_list = new List<location>();

        string selectedbutton;
        int totalcost;
        public pay(string selectedbutton, int totalcost)
        {
            InitializeComponent();
            this.selectedbutton = selectedbutton;
            this.totalcost = totalcost;
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
        ListView menuview = new ListView();
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


            //menuview.ItemSelectionChanged += listView_ItemSelectionChanged;

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
            if(listview2.Items.Count == 0)
            {
                MessageBox.Show("선택된 메뉴가 없습니다.", "알림");
                return;
            }            

            while(listview2.Items.Count > 0)
            {
                ListViewItem item = listview2.Items[0];
                listview2.Items.Remove(item);
                listview1.Items.Add(item);
            }
            paycosttxt.Text = "0";
            selectcost = 0;

        }

        private void cardpay_Click(object sender, EventArgs e)
        {
            totalcost = totalcost - int.Parse(paycosttxt.Text);
            if (totalcost == 0)
            {
                MessageBox.Show("결제가 완료 되었습니다.","알림");
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

                return;
            }
            MessageBox.Show("카드 결제가 완료되었습니다.\n" + "남은 금액: " + totalcost.ToString() + "원", "알림"); ;
            paycosttxt.Text = "0";
            selectcost = 0;
            totcosttxt.Text = totalcost.ToString();
            sellistView.Clear();
            

        }

        private void cashpay_Click(object sender, EventArgs e)
        {
            totalcost = totalcost - int.Parse(paycosttxt.Text);
            if (totalcost == 0)
            {
                MessageBox.Show("결제가 완료 되었습니다.", "알림");
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
                return;
            }
            MessageBox.Show("현금 결제가 완료되었습니다.\n" + "남은 금액: " + totalcost.ToString() + "원", "알림"); ;
            paycosttxt.Text = "0";
            selectcost = 0;
            totcosttxt.Text = totalcost.ToString();
            sellistView.Clear();
        }

        private void menuview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListView listView1 = (ListView)sender;
                ListView listView2 = sellistView; // 다른 ListView 컨트롤의 인스턴스

                ListViewItem selected = listView1.SelectedItems[0];
                listView1.Items.Remove(selected);
                listView2.Items.Add(selected);

                string secondCol = selected.SubItems[1].Text;
                selectcost += int.Parse(secondCol);
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
    }
}
