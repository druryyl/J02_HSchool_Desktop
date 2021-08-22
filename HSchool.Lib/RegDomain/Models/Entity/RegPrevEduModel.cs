using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public enum EduTypeEnum
    {
        Public, Private, Homeschool, Other
    }

    public class RegPrevEduModel : IRegKey
    {
        public string RegID { get; set; }
        public string PreviousEdu { get; set; }
        public EduTypeEnum PreviousEduType { get; set; }
        public string YearAttended { get; set; }
        public string HighestGradeCompleted { get; set; }
        public bool IsAceCurriculum { get; set; }
        public IEnumerable<RegPaceModel> LastPaces { get; set; }
    }

    public class RegPaceModel : IRegKey, IPaceTypeKey
    {
        public string RegID { get; set; }
        public string PaceTypeID { get; set; }
        public string LevelID { get; set; }
    }
}
