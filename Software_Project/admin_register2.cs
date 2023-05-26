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

namespace Software_Project
{
    public partial class admin_register2 : Form
    {
        public admin_register2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "pw.CSV";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                File.Delete(filePath);
                writer.WriteLine(textBox1.Text);
                writer.Close();
            }
        }
    }
}
