using HSchool.Lib.Models.Dto;
using HSchool.Lib.Models.Entity;
using Nuna.Lib.ModelingHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Models
{
    public interface IPersonContext : IDeleteFlag
    {
        PersonEntity Person { get; }
    }

    public interface IPersonCommand
    {
        void Create(PersonCreateDto person);
        void Update(PersonUpdateDto person);
        void Delete(IPersonKey person);
    }

    public interface IPersonQuery
    {
        PersonEntity GetData(IPersonKey person);
        IEnumerable<PersonEntity> Search(string personName);
    }
}
