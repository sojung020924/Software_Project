using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class table : Form
    {
        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();
        public List<location> location_list = new List<location>();
        public table(List<Jangbaguni_button_set> list, List<location> loc_list)
        {
            InitializeComponent();
            jan_btn_combi=list;
            location_list = loc_list;
        }
       
       

        private void table_Load(object sender, EventArgs e)
        {
            for(int i=0; i<location_list.Count; i++)
            {
                Button button = new Button();
                button.Size = new Size(131, 62);
                button.Text = "테이블" + i;
                button.Name=i.ToString();
                int x = location_list[i].location_x;
                int y = location_list[i].location_y;
                button.Location = new Point(x, y);
                button.MouseClick += button_click;  
                Controls.Add(button);
            }
            
        }
        private Button selectedButton = null;
        private void button_click(object sender, EventArgs e)
        {
            // 이전에 선택된 버튼의 색상을 원래대로 되돌립니다.
            if (selectedButton != null)
            {
                selectedButton.BackColor = SystemColors.Control;
            }

            // 선택된 버튼에 대한 색상을 변경합니다.
            Button button = (Button)sender;
            button.BackColor = Color.Blue;

            // 선택된 버튼을 추적합니다.          
            table_num.Text = "고른 테이블: " + button.Text + " 번";
            selectedButton = button;
            selectedButton.Name = button.Name;           
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
           
            this.Visible = false;
            gyeoljae g = new gyeoljae(jan_btn_combi,location_list);
            Point parentPoint = this.Location;
            g.StartPosition = FormStartPosition.Manual;
            g.Location = new Point(parentPoint.X, parentPoint.Y);
            g.ShowDialog();
        }

        private void tablegola_Click(object sender, EventArgs e)
        {
            location loc = new location
            {
                location_x = selectedButton.Location.X,
                location_y = selectedButton.Location.Y,
                used = true
            };
            location_list[int.Parse(selectedButton.Name)] = loc;
            this.Visible = false;
            Main_ui main_ui = new Main_ui();
            Point parentPoint = this.Location;
            main_ui.StartPosition = FormStartPosition.Manual;
            main_ui.Location = new Point(parentPoint.X, parentPoint.Y);
            main_ui.ShowDialog();
            this.Close();
        }

        private void table_setting_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            table_setting g = new table_setting(jan_btn_combi, location_list);
            Point parentPoint = this.Location; 
            g.StartPosition = FormStartPosition.Manual;
            g.Location = new Point(parentPoint.X, parentPoint.Y);
            g.ShowDialog();
        }
    }
}
