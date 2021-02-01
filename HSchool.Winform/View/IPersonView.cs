using HSchool.Lib.Dto;
using HSchool.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSchool.Winform.View
{
    public interface IPersonView
    {
        string PersonID { get; set; }
        string PersonName { get; set; }
        string NickName { get; set; }

        DateTime BirthDate { get; set; }
        string BirthPlace { get; set; }
        GenderEnum Gender { get; set; }

        string FullAddr { get; set; }
        string ShortAddr { get; set; }
        string City { get; set; }
        string PhoneNo { get; set; }
        string Email { get; set; }

        string KeywordSearch { get; set; }

        IEnumerable<PersonSearchResultDto> SearchResult { get; set; }

        void Show();
    }
}
