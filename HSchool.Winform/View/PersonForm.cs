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

namespace HSchool.Winform.View
{
    public partial class PersonForm : Form, IPersonView
    {
        private readonly IPersonBL _personBL;
        private readonly BindingSource _searchResultBindingSource;



        public PersonForm(IPersonBL personBL)
        {
            InitializeComponent();
            _personBL = personBL;
            _searchResultBindingSource = new BindingSource();
            _searchResultBindingSource.DataSource = _personBL.SearchResult;
            SearchResultGrid.DataSource = _personBL.SearchResult;
        }

        public string PersonID 
        { 
            get => PersonIDTextBox.Text; 
            set => PersonIDTextBox.Text = value; 
        }
        public string PersonName 
        {
            get => FullNameTextBox.Text; 
            set => FullNameTextBox.Text = value; 
        }
        public string NickName 
        { 
            get => NickNameTextBox.Text; 
            set => NickNameTextBox.Text = value; 
        }
        public DateTime BirthDate 
        { 
            get => BirthDateDatePicker.Value; 
            set => BirthDateDatePicker.Value = value; 
        }
        public string BirthPlace 
        { 
            get => BirthPlaceTextBox.Text; 
            set => BirthPlaceTextBox.Text = value; 
        }
        public GenderEnum Gender 
        { 
            get => (GenderEnum)GenderComboBox.SelectedIndex; 
            set => GenderComboBox.SelectedIndex = (int)value; 
        }
        public string FullAddr 
        { 
            get => AddressTextBox.Text; 
            set => AddressTextBox.Text = value; 
        }
        public string ShortAddr 
        { 
            get => ShortAddressTextBox.Text; 
            set => ShortAddressTextBox.Text = value; 
        }
        public string City 
        { 
            get => CityTextBox.Text; 
            set => CityTextBox.Text = value; 
        }
        public string PhoneNo 
        { 
            get => PhoneNoTextBox.Text;
            set => PhoneNoTextBox.Text = value; 
        }
        public string Email 
        { 
            get => EmailTextBox.Text;
            set => EmailTextBox.Text = value; 
        }
        public string KeywordSearch 
        { 
            get => SearchTextBox.Text; 
            set => SearchTextBox.Text = value; 
        }
        public IEnumerable<PersonSearchResultDto> SearchResult 
        { 
            get => (IEnumerable<PersonSearchResultDto >)_searchResultBindingSource.DataSource;
            set => _searchResultBindingSource.DataSource = value; 
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _personBL.Save();
        }
    }
}
