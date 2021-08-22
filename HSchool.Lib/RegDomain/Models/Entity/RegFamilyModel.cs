using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public enum ParentTypeEnum
    {
        Father, Mother, Guardian
    }
    public enum MaritalStatusEnum
    {
        Married, Widow, Divorce, Separated, SingleParent
    }
    public class RegFamilyModel : IRegKey
    {
        public string RegID { get; set; }
        public IEnumerable<RegFamilyPersonModel> Parents { get; set; }
        public string EmergencyPhone { get; set; }
        public MaritalStatusEnum MaritalStatus { get; set; }
    }

    public class RegFamilyPersonModel : IRegKey
    {
        public string RegID { get; set; }
        public string PersonID { get; set; }
        public string PersonName { get; set; }
        public bool IsBiological { get; set; }
        public bool BiologicalName { get; set; }
        public string Employment { get; set; }
        public string Position { get; set; }
        public string BussinesPhone { get; set; }
        public FamilyMemberStatusEnum ParentType { get; set; }
    }

    public class RegFamilySibling : IRegKey
    {
        public string RegID { get; set; }
        public string PersonName { get; set; }
        public int Age { get; set; }
        public string ReasonNotApply { get; set; }
    }
}
