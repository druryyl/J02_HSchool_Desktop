using HSchool.Lib;
using HSchool.Lib.BL;
using HSchool.Lib.Dal;
using HSchool.Winform.Forms;
using HSchool.Winform.Presenters;
using HSchool.Winform.View;
using Intersolusi.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace HSchool.Winform
{
    public partial class MainForm : Form
    {
        private readonly UnityContainer _container;

        public MainForm()
        {
            InitializeComponent();
            this.ResizeEnd += delegate { this.Refresh(); };

            _container = new UnityContainer();
            _container.RegisterType<IParamNoDal, ParamNoDal>();
            _container.RegisterType<IParamNoBL, ParamNoBL>();
            _container.RegisterType<IPersonDal, PersonDal>();
            _container.RegisterType<IPersonBL, PersonBL>();

            _container.RegisterType<IPersonView, PersonForm>();
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

        private void Menu_Click(object sender, EventArgs e)
        {
            var menu = (RibbonButton)sender;
            Form form = null;
            switch (menu.Name)
            {
                case "ProfileMenu":
                    var presenter = _container.Resolve<PersonPresenter>();
                    presenter.Show();
                    //form = _container.Resolve<PersonForm>();
                    break;
                case "RegistrationMenu":
                    form = new RegisterForm();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.MdiParent = this;
                    form.Show();
                    break;
                default:
                    break;
            }

        }
    }
}
