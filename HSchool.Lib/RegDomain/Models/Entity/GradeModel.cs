using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public interface IGradeKey
    {
        string GradeID { get; set; }
    }
    public class GradeModel : IGradeKey
    {
        public string GradeID { get; set; }
        public string GradeName { get; set; }
    }
}
