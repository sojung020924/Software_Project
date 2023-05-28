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

namespace POS
{
    public partial class maechoollist : Form
    {
        ListView list = new ListView();

        public maechoollist()
        {
            InitializeComponent();
        }

        private void maechoollist_Load(object sender, EventArgs e)
        {
            list.Dock = DockStyle.Fill;
            list.View = View.Details;
            list.Scrollable = false;
            list.FullRowSelect = true;

            list.Columns.Add("날짜");
            list.Columns.Add("매출");

            int colwidth = panel1.ClientSize.Width / list.Columns.Count;
            for (int i = 0; i < list.Columns.Count; i++)
            {
                ColumnHeader column = list.Columns[i];
                column.Width = colwidth;
            }
            try
            {
                StreamReader sr = new StreamReader(Path.Combine("..", "..", "Properties", "totalmaechool.CSV"));
                while (!sr.EndOfStream)
                {
                    string line;
                    line = sr.ReadLine();
                    string[] value = line.Split(',');
                    if (value.Length == 2)
                    {
                        ListViewItem item = new ListViewItem(value[0]);
                        item.SubItems.Add(value[1]);
                        list.Items.Add(item);
                    }
                }
                sr.Close();
                panel1.Controls.Add(list);
            }catch (Exception ex)
            {
                MessageBox.Show("아직 매출 내역이 없습니다.", "알림");
                this.Close();
            }
        }
    }
}
