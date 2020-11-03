using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSchool.Winform.InputUserControl
{
    public partial class InputStringUserControl : UserControl
    {
        public InputStringUserControl()
        {
            InitializeComponent();
        }

        public string Caption
        {
            get => CaptionLabel.Text;
            set => CaptionLabel.Text = value;
        }
        public override string Text
        {
            get => StringTextBox.Text;
            set => StringTextBox.Text = value;
        }
    }
}
