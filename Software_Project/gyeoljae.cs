using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace Software_Project
{
    public partial class gyeoljae : Form
    {
        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();
        public List<location> location_list = new List<location>();

        public shared_list sharedlist = new shared_list();


        public gyeoljae(List<Jangbaguni_button_set> list, List<location> loc_list, shared_list sharedlist)
        {
            InitializeComponent();
            jan_btn_combi = list;
            location_list = loc_list;
            this.sharedlist = sharedlist;
            location_list = sharedlist.GetList();
        }

        private void gyeoljae_Load(object sender, EventArgs e)
        {

            int sum = 0;
            
            for (int i = 0; i < jan_btn_combi.Count; i++)
            {   
                string s="";
                string p = "";
                TextBox box = new TextBox();
                TextBox box2 = new TextBox();
                box.Multiline = true;
                box.Size = new Size(flowLayoutPanel1.Width-20, 120);
                box2.Multiline = true;
                box2.Dock = DockStyle.Right;
                box2.Size = new Size(120, 80);
                box2.TextAlign = HorizontalAlignment.Center;
                box2.BorderStyle = BorderStyle.None;
                string option = "";
                int num = jan_btn_combi[i].jangbaguni.options.Count;
                for (int j = 0; j < num; j++) 
                {
                    if (jan_btn_combi[i].jangbaguni.options[j][3] != "0")
                    {
                        option += jan_btn_combi[i].jangbaguni.options[j][0] + "" + jan_btn_combi[i].jangbaguni.options[j][3] + "개 \r\n";
                    }

                }
                if (jan_btn_combi[i].jangbaguni.memo != "")
                {
                    option += "\"" + jan_btn_combi[i].jangbaguni.memo +"\"\r\n";
                }
                sum += jan_btn_combi[i].jangbaguni.total_price;
                s += "\r\n"+jan_btn_combi[i].jangbaguni.menu_name + " " + jan_btn_combi[i].jangbaguni.count + "개\r\n" + option;
                p = jan_btn_combi[i].jangbaguni.total_price + "원\r\n";
                box.Text = s;
                box2.Text ="\r\n\r\n" + p;

                box.Controls.Add(box2);
                flowLayoutPanel1.Controls.Add(box);
            }
            total.Text = "total: " + sum.ToString() + "원"; 
        }
        
        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Deopbab d = new Deopbab(jan_btn_combi, sharedlist);
            Point parentPoint = this.Location; 
            d.StartPosition = FormStartPosition.Manual;
            d.Location = new Point(parentPoint.X, parentPoint.Y);
            d.ShowDialog();
        }

        private void gyeoljoeng_hagi_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            table g = new table(jan_btn_combi,location_list, sharedlist);
            Point parentPoint = this.Location;
            g.StartPosition = FormStartPosition.Manual;
            g.Location = new Point(parentPoint.X, parentPoint.Y);
            g.ShowDialog();
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
