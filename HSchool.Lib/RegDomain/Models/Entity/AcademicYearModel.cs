using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public interface IAcademicYearKey
    {
        string AcademicYearID { get; set; }
    }
    public class AcademicYearModel : IAcademicYearKey
    {
        public string AcademicYearID { get; set; }
        public string AcademicYearName { get; set; }
    }
}
