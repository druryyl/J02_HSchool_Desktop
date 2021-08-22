using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public enum AcademicLevelEnum
    {
        Excelent, Good, Average, Poor
    }

    public class RegScholasticIssueModel : IRegKey
    {
        public string RegID { get; set; }
        public string TransferIssue { get; set; }
        public string DisiplinaryIssue { get; set; }
        public string DrugIssue { get; set; }
        public string AcademicFailedIssue { get; set; }
        public AcademicLevelEnum AcademicLevel { get; set; }
    }
}
