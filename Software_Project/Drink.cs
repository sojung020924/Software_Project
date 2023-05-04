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
    public partial class Drink : Form
    {
        public Drink()
        {
            InitializeComponent();
        }

        private void choose_deopbab_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Deopbab deopbab = new Deopbab(); 
            Point parentPoint = this.Location; 
            deopbab.StartPosition = FormStartPosition.Manual;
            deopbab.Location = new Point(parentPoint.X, parentPoint.Y);
            deopbab.ShowDialog();
            this.Close();
        }

        private void choose_bockbab_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Bockbab bockbab = new Bockbab();
            Point parentPoint = this.Location;
            bockbab.StartPosition = FormStartPosition.Manual;
            bockbab.Location = new Point(parentPoint.X, parentPoint.Y);
            bockbab.ShowDialog();
            this.Close();
        }

        private void choose_side_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Side side = new Side();
            Point parentPoint = this.Location;
            side.StartPosition = FormStartPosition.Manual;
            side.Location = new Point(parentPoint.X, parentPoint.Y);
            side.ShowDialog();
            this.Close();
        }
    }
}
