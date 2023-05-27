using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Software_Project
{
    public partial class admin : Form
    {
        List<string[]> mlist = new List<string[]>();
        ListView menulist = new ListView();


        public admin()
        {
            InitializeComponent();
            mlist.Clear();

            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "JPG (*.jpg)|*.jpg";
            ofd.Title = "Menu Image";
            ofd.FileName = "";


            menulist.Dock = DockStyle.Fill;
            menulist.View = View.Details;
            menulist.Scrollable = true;
            menulist.FullRowSelect = true;
            menulist.Columns.Add("Menu");
            menulist.Columns.Add("가격");
            menulist.Columns.Add("카테고리");
            menulist.MouseDoubleClick += menulist_MouseDoubleClick;

        }

        private void admin_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("menu.CSV"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string line;
                    line = reader.ReadLine();
                    string[] value = line.Split(',');
                    mlist.Add(value);
                }
                reader.Close();
            }
            for (int i = 0; i < mlist.Count; i++)
            {
                ListViewItem item = new ListViewItem(mlist[i][0]);
                item.SubItems.Add(mlist[i][1]);
                item.SubItems.Add((string)mlist[i][2]);
                menulist.Items.Add(item);
            }

            int colwidth = panel1.ClientSize.Width / menulist.Columns.Count;
            for (int i = 0; i < menulist.Columns.Count; i++)
            {
                ColumnHeader column = menulist.Columns[i];
                column.Width = colwidth;
            }
            panel1.Controls.Add(menulist);
        }
        private void menulist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListView listView1 = (ListView)sender; // 다른 ListView 컨트롤의 인스턴스

                ListViewItem selected = listView1.SelectedItems[0];
                textBox1.Text = selected.Text;
                textBox2.Text = selected.SubItems[1].Text;
                listBox1.Text = selected.SubItems[2].Text;

                string secondCol = selected.SubItems[1].Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            ListViewItem selected = menulist.SelectedItems[0];
            menulist.Items.Remove(selected);

            int count = 1;
            List<string> lines = new List<string>();

            StreamReader sr = new StreamReader("menu.CSV");
            while (!sr.EndOfStream)
            {
                string line;
                line = sr.ReadLine();
                string[] value = line.Split(',');
                if (value[0] == textBox1.Text)
                {
                    continue;
                }
                lines.Add(line);
            }
            sr.Close();
            StreamWriter wr = new StreamWriter("menu.CSV", false);

            for (int i = 0; i < lines.Count; i++)
            {
                wr.Write(lines[i] + '\n');
            }
            wr.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) // 메뉴 추가 버튼
        {
            string text = "";
            using (StreamReader sr = new StreamReader("menu.CSV"))
            {
                while (!sr.EndOfStream)//여기에 기존에 존재하는 메뉴라면 해당행 삭제 후 등록 추가해야함(완료)
                {
                    string line = sr.ReadLine();
                    string[] value = line.Split(',');
                    if (value[0] == textBox1.Text)
                    {


                        continue;
                    }

                    text += line;
                    text += '\n';
                }
                if (textBox4.Text == string.Empty)
                {
                    text += textBox1.Text + ',' + textBox2.Text + ',' + GetCurrentVisibleItemText(listBox1) + ',';
                }
                else
                {
                    text += textBox1.Text + ',' + textBox2.Text + ',' + GetCurrentVisibleItemText(listBox1) + ',';
                }
                sr.Close();
            }
            using (StreamWriter sw = new StreamWriter("menu.CSV", false))
            {
                sw.WriteLine(text);
                sw.Close();
            }

            ListViewItem removeitem = null;
            foreach (ListViewItem items in menulist.Items)
            {
                if (items.Text == textBox1.Text)
                {
                    removeitem = items;
                    break;
                }
            }
            if (removeitem != null)
            {
                menulist.Items.Remove(removeitem);
            }
            ListViewItem item = new ListViewItem(textBox1.Text);
            item.SubItems.Add(textBox2.Text);
            item.SubItems.Add(GetCurrentVisibleItemText(listBox1));
            menulist.Items.Add(item);

            try
            {
                // 파일 이름 변경을 위한 대상 파일명을 입력합니다.
                string newFileName = textBox1.Text + ".jpg";

                // 대상 폴더가 없다면 생성합니다.

                // 파일을 복사하고 이름을 변경하여 붙여넣습니다.
                string targetFilePath = Path.Combine(".", newFileName);
                File.Copy(textBox4.Text, targetFilePath);

                Console.WriteLine("파일이 복사되었습니다.");
                Console.WriteLine("원본 파일 경로: " + textBox4.Text);
                Console.WriteLine("대상 파일 경로: " + targetFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("파일 복사 중 오류가 발생했습니다: " + ex.Message);
            }

            MessageBox.Show("메뉴 추가 완료.", "알림");

        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = ofd.FileName;
                ofd.FileName = "";
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_ui main = new Main_ui();
            main.ShowDialog();
        }
        //int nowindex; // 카테고리 선택란에서 현재 보여지고 있는 텍스트
        private string GetCurrentVisibleItemText(ListBox listBox)
        {
            int firstVisibleIndex = listBox.TopIndex;
            int visibleItemCount = listBox.ClientSize.Height / listBox.ItemHeight;

            // 보여지는 아이템의 인덱스 범위를 계산합니다.
            int lastVisibleIndex = firstVisibleIndex + visibleItemCount - 1;
            lastVisibleIndex = Math.Min(lastVisibleIndex, listBox.Items.Count - 1);

            // 현재 보여지는 아이템 중 첫 번째 아이템의 텍스트를 가져옵니다.
            string currentItemText = listBox.GetItemText(listBox.Items[firstVisibleIndex]);

            return currentItemText;
        }
    }
}
