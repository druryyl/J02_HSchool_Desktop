using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public interface IFamilyKey
    {
        string FamilyID { get; set; }
    }

    public enum FamilyMemberStatusEnum
    {
        Suami, Istri, Anak
    }

    public class FamilyModel : IFamilyKey
    {
        public string FamilyID { get; set; }
        public IEnumerable<FamilyMemberModel> ListMember { get; set; }
    }

    public class FamilyMemberModel : PersonModel
    {
        public FamilyMemberStatusEnum MemberStatus { get; set; }
        public int AnakIndex { get; set; }
    }
}
