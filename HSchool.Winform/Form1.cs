using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSchool.Winform
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            this.ResizeEnd += delegate { this.Refresh(); };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var mdi = Controls.OfType<MdiClient>().FirstOrDefault();
            mdi.BackColor = Color.White;
            mdi.BackgroundImage = Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

    }
}
