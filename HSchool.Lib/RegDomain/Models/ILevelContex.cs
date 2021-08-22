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

    public interface ILevelContext : IDeleteFlag
    {
        //  ROOT
        LevelModel Level { get; }
        //  VALUE OBJECT
        GradeModel Grade { get; }

    }
    public interface ILevelCommand
    {
        void Create(LevelCreateDto level);
        void Update(LevelUpdateDto level);
        void Delete(ILevelKey level);
    }

    public interface ILevelQuery
    {
        LevelModel GetData(ILevelKey Level);
        IEnumerable<LevelModel> ListData(IGradeKey filter);
    }
}
