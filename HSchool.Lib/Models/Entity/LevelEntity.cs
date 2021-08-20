using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Models.Entity
{
    public interface ILevelKey
    {
        string LevelID { get; set; }
    }
    public class LevelEntity : ILevelKey
    {
        public string LevelID { get; set; }
        public string LevelName { get; set; }
        public int LevelIndex { get; set; }
        public string GradeID { get; set; }
        public string GradeName { get; set; }
    }
}
