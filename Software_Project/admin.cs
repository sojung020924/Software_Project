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
            using(StreamReader reader = new StreamReader("menu.CSV"))
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
            for( int i = 0; i < mlist.Count; i++ )
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
                textBox3.Text = selected.SubItems[2].Text;

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
            
            for(int i = 0; i < lines.Count; i++)
            {
                wr.Write(lines[i] + '\n');
            }
            wr.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
