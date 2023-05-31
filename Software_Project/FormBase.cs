using System.Drawing;
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
