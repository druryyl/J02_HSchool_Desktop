using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSchool.Winform.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void FlowPanel_Paint(object sender, PaintEventArgs e)
        {
            var panel = (FlowLayoutPanel)sender;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
                Color.DarkKhaki, ButtonBorderStyle.Solid);
        }
    }
}
