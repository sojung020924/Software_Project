using Software_Project;
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

    public partial class pos : Form
    {
        public List<location> location_list = new List<location>();
        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();

        public shared_list sharedlist = new shared_list();

        public static pos currentinstance; // 뒤로가기를 눌렀을떄 기존의 pos 폼으로 다시 돌아오게 하기 위함.
        private table_setting settingForm;
        public pos(shared_list sharedlist)
        {
            InitializeComponent();
            currentinstance = this;
            if (sharedlist != null)
            {
                // sharedlist를 사용하는 코드
                this.sharedlist = sharedlist;
                //location_list = sharedlist.GetList();  // 예시: GetList() 메서드 호출
            }
            else
            {
                // sharedlist가 null인 경우에 대한 대체 동작 또는 예외 처리
                // 예시: 로그 출력 또는 예외를 던지는 등의 처리
                Console.WriteLine("sharedlist is null.");
            }
        }

        private void OpenSettingForm()
        {
            if (settingForm == null || settingForm.IsDisposed )
            {
                settingForm = new table_setting(this, sharedlist); // SettingForm의 생성자에 PosForm 인스턴스를 전달합니다.

            }
            this.Hide();
            settingForm.Show();
        }

        public void updateposlist(shared_list sharedlist/*, List<location> location_list*/)
        {
            this.sharedlist = sharedlist;
            //sharedlist.updatesharedList(location_list);
        }

        public shared_list getposlist()
        {
            return sharedlist;
        }

        private Button selectedButton = null;

        
        //int table_num = 0;
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
            //table_num.Text = "고른 테이블: " + button.Text + " 번";
            selectedButton = button;
            selectedButton.Name = button.Name;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {   
            for(int i=0; i<location_list.Count; i++)
            {
                RemoveButtonByName(i.ToString());
            }

            location_list = sharedlist.GetList();

            if (location_list.Count == 0)
            {
                for (int i = 0; i < 50; i++)
                {
                    RemoveButtonByName(i.ToString());
                }
            }



            for (int i = 0; i < location_list.Count; i++)
            {
                
                Button button = new Button();
                button.Size = new Size(131, 62);
                button.Text = "테이블" + i;
                button.Name = i.ToString();
                int x = location_list[i].location_x;
                int y = location_list[i].location_y;
                button.Location = new Point(x, y);
                button.MouseClick += button_click;
                Controls.Add(button);
            }

        }

        public void ifresetclick()
        {
            location_list = sharedlist.GetList();
            if (location_list.Count == 0)
            {
                for (int i = 0; i < 50; i++)
                {
                    RemoveButtonByName(i.ToString());
                }
            }
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

        private void settablebtn_Click(object sender, EventArgs e)
        {
            OpenSettingForm();
        }

        private void kioskOn_Click(object sender, EventArgs e)
        {
            sharedlist.updatesharedList(location_list);
            Main_ui main_Ui = new Main_ui(sharedlist);
            main_Ui.Show();
        }
    }
}
