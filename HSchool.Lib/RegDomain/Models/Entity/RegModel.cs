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
        public string PersonID { get; set; }
        public string GradeID { get; set; }
        public string AcademicYear { get; set; }
    }
}
