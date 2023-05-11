using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class table_setting : Form
    {

        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();
        public List<location> location_list = new List<location>();
        public table_setting(List<Jangbaguni_button_set> list, List<location> loc_list)
        {
            InitializeComponent();
            jan_btn_combi=list;
            location_list=loc_list;
        }
        int table_num = 0;
       
        private void tablechuga_Click(object sender, EventArgs e)
        {
            table_num=location_list.Count;
            Button button = new Button();
            button.Size = new Size(131,62);
            button.Text = "table" + table_num;
           
            button.MouseDown += new MouseEventHandler(button_MouseDown);
            button.MouseMove += new MouseEventHandler(button_MouseMove);
            button.MouseUp += new MouseEventHandler(button_MouseUp);
            Controls.Add(button);
            table_num++;
            
        }
       

        private bool isDragging = false;
        private Point lastLocation;
        int a = 0;

         private void button_MouseDown(object sender, MouseEventArgs e)
         {
            isDragging = true;
             lastLocation = e.Location;
            for(int i=0; i<location_list.Count;i++)
            {
                if (lastLocation.X == location_list[i].location_x && lastLocation.Y == location_list[i].location_y)
                {
                    
                    a = i;
                    break;
                }
            }
          


        }


        private void button_MouseMove(object sender, MouseEventArgs e)
         {
             Button btn = sender as Button;
            if (isDragging)
            {
                btn.Left += e.X - lastLocation.X;
                btn.Top += e.Y - lastLocation.Y;              
            }
             
         }
        private void button_MouseUp(object sender, MouseEventArgs e)
        {
             Button btn = sender as Button;
             isDragging = false;
             location loc = new location
             {
                 location_x = btn.Location.X,
                 location_y = btn.Location.Y
             };
            foreach (Control c in Controls)
            {
                if (c is Button && c != btn && c.Location == lastLocation)
                {
                    Controls.Remove(c);
                    break;
                }
            }
            if (a != 0)
            {
                location_list[a] = loc;
                a = 0;
            }
            else
                location_list.Add(loc);
                          
    
        }


        private void table_setting_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < location_list.Count; i++)
            {
                Button button = new Button();
                button.Size = new Size(131, 62);
                button.Text = "table" + i;
                button.MouseDown += new MouseEventHandler(button_MouseDown);
                button.MouseMove += new MouseEventHandler(button_MouseMove);
                button.MouseUp += new MouseEventHandler(button_MouseUp);
                int x = location_list[i].location_x;
                int y = location_list[i].location_y;
                button.Location = new Point(x, y);
                Controls.Add(button);
            }
        }

        private void table_save_Click(object sender, EventArgs e)
        {
            
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            table g = new table(jan_btn_combi, location_list);
            Point parentPoint = this.Location; //폼 열리는 위치 설정
            g.StartPosition = FormStartPosition.Manual;
            g.Location = new Point(parentPoint.X, parentPoint.Y);
            g.ShowDialog();
        }
    }

}
