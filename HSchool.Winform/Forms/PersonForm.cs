using HSchool.Lib.BL;
using HSchool.Lib.Dto;
using HSchool.Lib.Models;
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
    public partial class PersonForm : Form
    {
        private readonly IPersonBL _personBL;
        private BindingSource _searchResultBinding;

        public PersonForm(IPersonBL personBL)
        {
            InitializeComponent();
            _personBL = personBL;
            _searchResultBinding = new BindingSource();
            _searchResultBinding.DataSource = _personBL.SearchResult;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SetData();
            _personBL.Save();
        }

        private void SetData()
        {
            var person = new PersonModel
            {
                PersonID = PersonIDTextBox.Text,
                PersonName = FullNameTextBox.Text,
                NickName = NickNameTextBox.Text,
                BirthDate = BirthDateDatePicker.Value,
                BirthPlace = BirthPlaceTextBox.Text,
                Gender = (GenderEnum)GenderComboBox.SelectedIndex,

                FullAddr = AddressTextBox.Text,
                ShortAddr = ShortAddressTextBox.Text,
                City = CityTextBox.Text,
                PhoneNo = PhoneNoTextBox.Text,
                Email = EmailTextBox.Text
            };
            _personBL.Person = person;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            var ctrl = (TextBox)sender;
            if (ctrl == SearchTextBox)
                Search();
        }

        private void Search()
        {
            _personBL.Search(SearchTextBox.Text);
            _searchResultBinding.ResetBindings(false);
        }
    }
}
