using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public interface ILevelKey
    {
        string LevelID { get; set; }
    }
    public class LevelModel : ILevelKey, IGradeKey
    {
        public string LevelID { get; set; }
        public string LevelName { get; set; }
        public string GradeID { get; set; }
        public string GradeName { get; set; }
    }
}