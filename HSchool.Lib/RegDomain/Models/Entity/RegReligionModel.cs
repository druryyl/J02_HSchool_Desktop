using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public enum ReligionEnum
    {
        Christian, Catholic, Moslem, Budhist, Hindu, Other
    }

    public class RegReligionModel : IRegKey
    {
        public string RegID { get; set; }
        public string ChurchName{ get; set; }
        public string ChurchAddr { get; set; }
        public string PastorName { get; set; }
        public string PhoneNo { get; set; }
        public ReligionEnum FatherReligion { get; set; }
        public ReligionEnum MotherReligion { get; set; }
        public bool IsProfesionApplicant { get; set; }
    }
}
