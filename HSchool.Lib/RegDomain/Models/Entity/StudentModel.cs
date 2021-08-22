using HSchool.Lib.RegDomain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public interface IStudentKey
    {
        string StudentID { get; set; }
    }
    public class StudentModel : IStudentKey, IPersonKey, ILevelKey
    {
        public string StudentID { get; set; }
        public string PersonID { get; set; }
        public string PersonName { get; set; }
        
        public string LevelID { get; set; }
        public string LevelName { get; set; }
    }
}
