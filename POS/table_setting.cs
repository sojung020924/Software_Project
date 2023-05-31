using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace POS
{


    public partial class table_setting : Form
    {

        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();
        public List<location> location_list = new List<location>();


        private POS posForm;


        int table_num = 0;

        public table_setting(POS posForm)
        {
            InitializeComponent();
            this.posForm = posForm;
            try
            {
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
            int v = location_list.Count;
            table_num = v;
        }

        private void tablechuga_Click(object sender, EventArgs e)
        {
            //table_num=location_list.Count;
            Button button = new Button();
            button.Size = new Size(131, 62);
            button.Name = table_num.ToString();
            button.Text = "테이블 " + (table_num + 1);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("HY견고딕", 10);
            button.BackColor = Color.LightCoral;

            location loc = new location
            {
                location_x = button.Location.X,
                location_y = button.Location.Y
            };
            if (location_list.Count == 0)
            {
                location_list.Add(loc);
                button.MouseDown += new MouseEventHandler(button_MouseDown);
                button.MouseMove += new MouseEventHandler(button_MouseMove);
                button.MouseUp += new MouseEventHandler(button_MouseUp);
                Controls.Add(button);
                table_num++;
                return;
            }
            location_list.Add(loc);


            button.MouseDown += new MouseEventHandler(button_MouseDown);
            button.MouseMove += new MouseEventHandler(button_MouseMove);
            button.MouseUp += new MouseEventHandler(button_MouseUp);
            Controls.Add(button);
            table_num++;

        }


        private bool isDragging = false;
        private Point lastLocation;

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
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
            location_list[int.Parse(btn.Name)] = loc;





        }


        private void table_setting_Load(object sender, EventArgs e)
        {



            for (int i = 0; i < location_list.Count; i++)
            {
                Button button = new Button();
                button.Size = new Size(131, 62);
                button.Text = "테이블 " + (i + 1);
                button.Name = i.ToString();
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = new Font("HY견고딕", 10);
                button.BackColor = Color.LightCoral;
                button.MouseDown += new MouseEventHandler(button_MouseDown);
                button.MouseMove += new MouseEventHandler(button_MouseMove);
                button.MouseUp += new MouseEventHandler(button_MouseUp);
                int x = location_list[i].location_x;
                int y = location_list[i].location_y;
                button.Location = new Point(x, y);
                button.BringToFront();
                Controls.Add(button);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < location_list.Count; i++)
            {
                RemoveButtonByName(i.ToString());
            }
            try
            {
                File.Delete("tablelist.CSV");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            location_list.Clear();
            table_num = 0;

            //posForm.Show();
            //this.Hide();

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            //posForm.UpdateLocationList(location_list);
            //posForm.updateposlist(sharedlist/*, location_list*/);
            CsvGenerator csvgenerator = new CsvGenerator();
            csvgenerator.GenerateCsv(location_list, "tablelist.CSV");


            posForm.Show();
            this.Hide();
        }
        private void RemoveButtonByName(string buttonName)
        {
            Control[] foundButtons = this.Controls.Find(buttonName, true);

            if (foundButtons.Length > 0 && foundButtons[0] is Button)
            {
                Button button = (Button)foundButtons[0];
                this.Controls.Remove(button);
                button.Dispose(); // 선택적으로 버튼을 메모리에서 해제할 수 있습니다.
            }
        }
    }

}
