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
using ClassLibrary2;

namespace Software_Project
{
    public class CsvGenerator
    {
        public void GenerateCsv(List<Jangbaguni> jangbaguniList, string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // CSV 파일의 헤더 작성
                writer.WriteLine("Menu Name,Total Price,Memo,Options,Count");

                // Jangbaguni 리스트의 각 항목을 CSV 파일에 작성
                foreach (Jangbaguni jangbaguni in jangbaguniList)
                {
                    // 각 필드 값을 쉼표로 구분하여 CSV 파일에 작성
                    string line = $"{jangbaguni.menu_name},{jangbaguni.total_price},{jangbaguni.memo},{OptionsToString(jangbaguni.options)},{jangbaguni.count}";
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("CSV 파일이 생성되었습니다.");
        }

        private string OptionsToString(List<List<string>> options)
        {
            // Options 리스트의 각 항목을 쉼표로 구분하여 하나의 문자열로 만듦
            List<string> optionStrings = new List<string>();
            foreach (List<string> option in options)
            {
                string optionString = string.Join("/", option);
                optionStrings.Add(optionString);
            }

            return string.Join(",", optionStrings);
        }
    }
    public partial class table : Form
    {
        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();
        
        public List<location> location_list = new List<location>();
        public shared_list sharedlist = new shared_list();
        
        //private pos posform;
        public table(List<Jangbaguni_button_set> list, List<location> loc_list, shared_list sharedlist)
        {
            InitializeComponent();
            jan_btn_combi=list;
            location_list = loc_list;

            if (sharedlist != null)
            {
                // sharedlist를 사용하는 코드
                this.sharedlist = sharedlist;
                location_list = sharedlist.GetList();  // 예시: GetList() 메서드 호출
                //location_list = posform.location_list;
            }
            else
            {
                // sharedlist가 null인 경우에 대한 대체 동작 또는 예외 처리
                // 예시: 로그 출력 또는 예외를 던지는 등의 처리
                Console.WriteLine("sharedlist is null.");
            }
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
                if (location_list[i].used == true)
                    button.BackColor = Color.Red;
                Controls.Add(button);
            }
            
        }
        private Button selectedButton = null;
        private void button_click(object sender, EventArgs e)
        { 
            
            // 이전에 선택된 버튼의 색상을 원래대로 되돌립니다.
            if (selectedButton != null)
            {
                if (selectedButton.BackColor == Color.Blue)
                {
                    selectedButton.BackColor = SystemColors.Control;
                }
            }

            // 선택된 버튼에 대한 색상을 변경합니다.
            Button button = (Button)sender;
            if(button.BackColor == Color.Red)
            {
                MessageBox.Show("이미 사용중인 테이블입니다.\n 다른 테이블을 선택해주세요.", "선택 불가");
                return;
            }
            button.BackColor = Color.Blue;

            // 선택된 버튼을 추적합니다.          
            table_num.Text = "고른 테이블: " + button.Text + " 번";
            selectedButton = button;
            selectedButton.Name = button.Name;           
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
           
            this.Visible = false;
            gyeoljae g = new gyeoljae(jan_btn_combi,location_list,sharedlist);
            Point parentPoint = this.Location;
            g.StartPosition = FormStartPosition.Manual;
            g.Location = new Point(parentPoint.X, parentPoint.Y);
            g.ShowDialog();
        }
        public List<Jangbaguni> menulist = new List<Jangbaguni>();
        private void tablegola_Click(object sender, EventArgs e)
        {
            location loc = new location
            {
                location_x = selectedButton.Location.X,
                location_y = selectedButton.Location.Y,
                used = true
            };
            /*location_list[int.Parse(selectedButton.Name)] = loc;
            sharedlist.updatesharedList(location_list);*/

            for(int i = 0; i < jan_btn_combi.Count; i++)
            {
                menulist.Add(jan_btn_combi[i].jangbaguni);
            }
            CsvGenerator savecsv = new CsvGenerator();
            savecsv.GenerateCsv(menulist, selectedButton.Name + ".CSV");

            location_list[int.Parse(selectedButton.Name)]= loc;
            sharedlist.updatesharedList(location_list);
            this.Visible = false;
            Main_ui main_ui = new Main_ui(sharedlist);
            Point parentPoint = this.Location;
            main_ui.StartPosition = FormStartPosition.Manual;
            main_ui.Location = new Point(parentPoint.X, parentPoint.Y);
            main_ui.ShowDialog();
            this.Close();
        }
    }
}
