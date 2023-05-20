﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace Software_Project
{

    public partial class table_setting : Form
    {

        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();
        public List<location> location_list = new List<location>();

        public shared_list sharedlist;

        private pos posForm;

        public table_setting(pos posForm, shared_list sharedlist)
        {
            InitializeComponent();
            this.posForm = posForm;
         //   jan_btn_combi=list;
           // location_list=loc_list;

            if (sharedlist != null)
            {
                // sharedlist를 사용하는 코드
                this.sharedlist = sharedlist;
                location_list = sharedlist.GetList();  // 예시: GetList() 메서드 호출
            }
            else
            {
                // sharedlist가 null인 경우에 대한 대체 동작 또는 예외 처리
                // 예시: 로그 출력 또는 예외를 던지는 등의 처리
                Console.WriteLine("sharedlist is null.");
            }
            
        }
        int table_num = 0;
       
        private void tablechuga_Click(object sender, EventArgs e)
        {
            location_list = sharedlist.GetList();
            table_num=location_list.Count;
            Button button = new Button();
            button.Size = new Size(131,62);
            button.Name = table_num.ToString();
            button.Text = "테이블 "+table_num;
            

            location loc = new location
            {
                location_x = button.Location.X,
                location_y = button.Location.Y
            };
            location_list.Add(loc);

            if (sharedlist != null)
            {
                // sharedlist를 사용하는 코드
                sharedlist.updatesharedList(location_list);  // 예시: GetList() 메서드 호출
            }
            else
            {
                // sharedlist가 null인 경우에 대한 대체 동작 또는 예외 처리
                // 예시: 로그 출력 또는 예외를 던지는 등의 처리
                Console.WriteLine("sharedlist is null.");
            }

            
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


            if (sharedlist != null)
            {
                // sharedlist를 사용하는 코드
                sharedlist.updatesharedList(location_list);  // 예시: GetList() 메서드 호출
            }
            else
            {
                // sharedlist가 null인 경우에 대한 대체 동작 또는 예외 처리
                // 예시: 로그 출력 또는 예외를 던지는 등의 처리
                Console.WriteLine("sharedlist is null.");
            }
        }


        private void table_setting_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < location_list.Count; i++)
            {
                Button button = new Button();
                button.Size = new Size(131, 62);
                button.Text = "테이블 " + i;
                button.Name = i.ToString();
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
            location_list.Clear();
            sharedlist.updatesharedList(location_list);
            posForm.updateposlist(sharedlist);
            posForm.ifresetclick();

            posForm.Show();
            this.Hide();

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            //posForm.UpdateLocationList(location_list);
            posForm.updateposlist(sharedlist/*, location_list*/);
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