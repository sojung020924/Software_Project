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
    public struct Jangbaguni_button_set
    {
        public Jangbaguni jangbaguni;
        public Button btn;
    }

    public partial class Main_ui : Form
    {
        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();

        public shared_list sharedlist = new shared_list();

        public Main_ui(shared_list sharedlist)
        {
            InitializeComponent();
            if (sharedlist != null)
            {
                // sharedlist를 사용하는 코드
                this.sharedlist = sharedlist;
                sharedlist.location_list = sharedlist.GetList();  // 예시: GetList() 메서드 호출
            }
            else
            {
                // sharedlist가 null인 경우에 대한 대체 동작 또는 예외 처리
                // 예시: 로그 출력 또는 예외를 던지는 등의 처리
                Console.WriteLine("sharedlist is null.");
            }
           // pos posForm = new pos(sharedlist);
            //posForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void choose_deopbab_Click(object sender, EventArgs e)
        {
            this.Visible = false; //현재창 숨김
            Deopbab deopbab = new Deopbab(jan_btn_combi, sharedlist); //객체 생성
            Point parentPoint = this.Location; //폼 열리는 위치 설정
            deopbab.StartPosition = FormStartPosition.Manual;  
            deopbab.Location = new Point(parentPoint.X, parentPoint.Y);
            deopbab.ShowDialog(); //폼 open
            this.Close();
        }

        private void choose_bockbab_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Bockbab bockbab = new Bockbab(jan_btn_combi, sharedlist);
            Point parentPoint = this.Location;
            bockbab.StartPosition = FormStartPosition.Manual; 
            bockbab.Location = new Point(parentPoint.X, parentPoint.Y);
            bockbab.ShowDialog();
            this.Close();
        }

        private void choose_side_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Side side = new Side(jan_btn_combi, sharedlist);
            Point parentPoint = this.Location;
            side.StartPosition = FormStartPosition.Manual;
            side.Location = new Point(parentPoint.X, parentPoint.Y);
            side.ShowDialog();
            this.Close();
        }

        private void choose_drink_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Drink drink = new Drink(jan_btn_combi, sharedlist);
            Point parentPoint = this.Location;
            drink.StartPosition = FormStartPosition.Manual;  
            drink.Location = new Point(parentPoint.X, parentPoint.Y);
            drink.ShowDialog();
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
