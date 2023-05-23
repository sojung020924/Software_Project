using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.WinForms.Suite.Descriptions;
using System.Windows.Forms;

namespace Software_Project
{
    public class FormBase : Form
    {
        public void ChangeFontSize(float fontSize)
        {
            Font = new Font(Font.FontFamily, fontSize, Font.Style);

            foreach (Control control in Controls)
            {
                control.Font = new Font(control.Font.FontFamily, fontSize, control.Font.Style);

                if (control is FormBase formBase)
                {
                    formBase.ChangeFontSize(fontSize); // 하위 폼에 대해 재귀적으로 호출
                }
            }
        }
    }
}
