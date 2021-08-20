using HSchool.Lib.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Models.Dto
{
    public class GradeCreateDto
    {
        public string GradeName { get; set; }
    }
    public class GradeUpdateDto : IGradeKey
    {
        public string GradeID { get; set; }
        public string GradeName { get; set; }
    }
}
