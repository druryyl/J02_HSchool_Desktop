using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public class RegMedicalModel : IRegKey
    {
        public string RegID { get; set; }
        public string FamilyPhysician { get; set; }
        public string Allergies { get; set; }
        public string Immunization { get; set; }
    }
}
