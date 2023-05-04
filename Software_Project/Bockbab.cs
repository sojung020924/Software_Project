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
    public partial class Bockbab : Form
    {
        public Bockbab()
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
        }

        private void choose_side_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Side side = new Side();
            Point parentPoint = this.Location;
            side.StartPosition = FormStartPosition.Manual;
            side.Location = new Point(parentPoint.X, parentPoint.Y);
            side.ShowDialog();
        }

        private void choose_drink_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Drink drink = new Drink();
            Point parentPoint = this.Location;
            drink.StartPosition = FormStartPosition.Manual;
            drink.Location = new Point(parentPoint.X, parentPoint.Y);
            drink.ShowDialog();
        }
    }
}
