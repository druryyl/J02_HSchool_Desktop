using HSchool.Lib.RegDomain.Models.Dto;
using HSchool.Lib.RegDomain.Models.Entity;
using Nuna.Lib.ModelingHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models
{
    public interface IPersonContext : IDeleteFlag
    {
        PersonModel Person { get; }
    }

    public interface IPersonCommand
    {
        void Create(PersonCreateDto person);
        void Update(PersonUpdateDto person);
        void Delete(IPersonKey person);
    }

    public interface IPersonQuery
    {
        PersonModel GetData(IPersonKey person);
        IEnumerable<PersonModel> Search(string personName);
    }
}
