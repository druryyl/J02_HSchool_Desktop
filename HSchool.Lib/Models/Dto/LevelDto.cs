using HSchool.Lib.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Models.Dto
{

    public class LevelCreateDto : IGradeKey
    {
        public string LevelName { get; set; }
        public string GradeID { get; set; }
    }

    public class LevelUpdateDto : ILevelKey, IGradeKey
    {
        public string LevelID { get; set; }
        public string LevelName { get; set; }
        public string GradeID { get; set; }
    }
}
