﻿using System;
using System.IO;
using System.Windows.Forms;

namespace POS
{
    public partial class choolgeunboo : Form
    {
        public choolgeunboo()
        {
            InitializeComponent();
        }

        ListView listview = new ListView();
        private void choolgeunboo_Load(object sender, EventArgs e)
        {
            listview.Dock = DockStyle.Fill;
            listview.View = View.Details;
            listview.Scrollable = false;
            listview.FullRowSelect = true;
            listview.Columns.Add("시간");
            listview.Columns.Add("이름");
            listview.Columns.Add("출/퇴근");
            int colwidth = panel1.ClientSize.Width / listview.Columns.Count;
            for (int i = 0; i < listview.Columns.Count; i++)
            {
                ColumnHeader column = listview.Columns[i];
                column.Width = colwidth;
            }
            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine("..", "..", "Properties", "geunmoo.CSV")))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] value = line.Split(',');

                        ListViewItem item = new ListViewItem(value[0]);
                        item.SubItems.Add(value[1]);
                        item.SubItems.Add((string)value[2]);

                        listview.Items.Add(item);
                    }
                    sr.Close();
                }
                panel1.Controls.Add(listview);
            }catch(FileNotFoundException ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }
    }

}
