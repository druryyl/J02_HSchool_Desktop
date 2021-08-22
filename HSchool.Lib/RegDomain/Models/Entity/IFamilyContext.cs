using Nuna.Lib.ModelingHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{

    public interface IFamilyContext : IDeleteFlag
    {
        FamilyModel Family { get; }
    }

    public interface IFamilyCommand
    {
        void Create(FamilyMemberModel person);
        void AddAnak(PersonModel person, int anakIndex);
        void AddSuami(PersonModel person);
        void AddIstri(PersonModel person);
        void Remove(PersonModel person);
    }

    public interface IFamilyQuery
    {
        FamilyModel GetData(IFamilyKey key);
        IEnumerable<FamilyMemberModel> ListMember(IPersonKey person);
    }
}
