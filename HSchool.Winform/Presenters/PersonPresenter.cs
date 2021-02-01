using HSchool.Lib.BL;
using HSchool.Winform.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSchool.Winform.Presenters
{
    public class PersonPresenter
    {
        private IPersonView _view;
        private IPersonBL _personBL;

        public PersonPresenter(IPersonView view, IPersonBL personBL)
        {
            _view = view;
            _personBL = personBL;
        }

        public void Save()
        {
            _personBL.Save();
        }

        public void Show()
        {
            _view.Show();
        }
    }
}
