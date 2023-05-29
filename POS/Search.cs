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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }


        ListView listview = new ListView();
        

        private void Search_Load(object sender, EventArgs e)
        {
            listview.Columns.Add("일자");
            listview.Columns.Add("기록");
            listview.Columns.Add("출/퇴");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string month = "0" + numericUpDown1.Value.ToString();
            string name = textBox1.Text;
            float tottime = 0;
            
            listview.Items.Clear();
            using (StreamReader sr = new StreamReader(Path.Combine("..","..","Properties","geunmoo.CSV")))
            {
                int htime = 0;
                float mtime = 0;

                string day = "";
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] value = line.Split(',');
                    string[] values = value[0].Split('-');


                    if (values[0] ==  month && textBox1.Text == value[1])
                    {
                        ListViewItem item = new ListViewItem(value[0]);
                        item.SubItems.Add(value[1]);
                        item.SubItems.Add(value[2]);
                        listview.Items.Add(item);

                        
                        if (value[2] == "출근")
                        {
                            day = values[1];
                            htime = int.Parse(values[2]);
                            mtime = float.Parse(values[3]);
                            
                        }else if (values[1] == day && value[2] == "퇴근")
                        {
                            
                            htime = int.Parse(values[2]) - htime;
                            mtime = float.Parse(values[3]) - mtime;
                            if (mtime > 0)
                            {
                                tottime += htime + (mtime / 60);
                            }
                            else
                            {
                                tottime += htime + ((mtime) / 60);
                            }
                        }
                        
                    }
                }
                sr.Close();
            }
            listview.Dock = DockStyle.Fill;
            listview.View = View.Details;
            listview.Scrollable = false;
            listview.FullRowSelect = true;
            

            int colwidth = panel1.ClientSize.Width / listview.Columns.Count;
            for (int i = 0; i < listview.Columns.Count; i++)
            {
                ColumnHeader column = listview.Columns[i];
                column.Width = colwidth;
            }

            panel1.Controls.Add(listview);
            textBox2.Text = tottime.ToString();
        }
    }
}
