using HSchool.Lib.RegDomain.BL;
using HSchool.Lib.RegDomain.Models.Entity;
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
//        private readonly IPersonBL _personBL;
        private BindingSource _searchResultBinding;

        //public PersonForm(IPersonBL personBL)
        //{
        //    InitializeComponent();
        //    _personBL = personBL;
        //    _searchResultBinding = new BindingSource();
        //    SearchResultGrid.DataSource = _searchResultBinding;
        //    SearchResultGrid.ReadOnly = true;
        //    ClearScreen();
        //    Search();

        //}

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SetData();
            try
            {
                //_personBL.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ClearScreen();
            Search();
        }
        private void ClearScreen()
        {
            PersonIDTextBox.Text = string.Empty;
            FullNameTextBox.Text = string.Empty;
            NickNameTextBox.Text = string.Empty;
            BirthDateDatePicker.Value = DateTime.Now;
            BirthPlaceTextBox.Text = string.Empty;
            GenderComboBox.SelectedIndex = 0;

            AddressTextBox.Text = string.Empty;
            ShortAddressTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
            PhoneNoTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
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
            //_personBL.Person = person;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var ctrl = (TextBox)sender;
                if (ctrl == SearchTextBox)
                    Search();
            }
        }

        private void Search()
        {
            //_personBL.Search(SearchTextBox.Text);
            //_searchResultBinding.DataSource = _personBL.SearchResult;
            SearchResultGrid.Columns["LastUpdate"].Visible = false;
        }

        private void Edit(int rowNum)
        {
            var key = SearchResultGrid.Rows[rowNum].Cells["PersonID"].Value.ToString();
            //_personBL.GetData(key);
            SetData();
        }
    }
}
