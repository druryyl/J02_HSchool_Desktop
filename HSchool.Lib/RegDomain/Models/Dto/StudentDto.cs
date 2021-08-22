using HSchool.Lib.RegDomain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Dto
{

    public class StudentCreateDto : IPersonKey, ILevelKey
    {
        public string StudentName { get; set; }
        public string PersonID { get; set; }
        public string LevelID { get; set; }
    }

    public class StudentUpdateDto : IStudentKey, IPersonKey, ILevelKey
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string PersonID { get; set; }
        public string LevelID { get; set; }
    }
}
