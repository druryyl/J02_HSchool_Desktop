using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public interface IRegKey
    {
        string RegID { get; set; }
    }

    public class RegModel : IRegKey, IGradeKey
    {
        public string RegID { get; set; }
        public string RegDate { get; set; }
        public string AcademicYearID { get; set; }

        public string PersonID { get; set; }
        public string PersonName { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public GenderEnum Gender { get; set; }
        public string FullAddr { get; set; }
        public string ShortAddr { get; set; }
        public string City { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }


        public string GradeID { get; set; }
        public string GradeName { get; set; }
    }
}
