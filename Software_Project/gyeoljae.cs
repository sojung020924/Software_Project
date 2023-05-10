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
    public partial class gyeoljae : Form
    {
        public List<Jangbaguni_button_set> jan_btn_combi = new List<Jangbaguni_button_set>();
        public gyeoljae(List<Jangbaguni_button_set> list)
        {
            InitializeComponent();
            jan_btn_combi = list;
        }

        private void gyeoljae_Load(object sender, EventArgs e)
        {

        }

        private void card_Click(object sender, EventArgs e)
        {

        }

        private void cash_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i=0; i<jan_btn_combi.Count; i++)
            {

            }
        }
    }
}
