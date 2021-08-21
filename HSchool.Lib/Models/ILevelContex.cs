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

    public interface ILevelContext : IDeleteFlag
    {
        //  ROOT
        LevelEntity Level { get; }
        //  VALUE OBJECT
        GradeEntity Grade { get; }

    }
    public interface ILevelCommand
    {
        void Create(LevelCreateDto level);
        void Update(LevelUpdateDto level);
        void Delete(ILevelKey level);
    }

    public interface ILevelQuery
    {
        LevelEntity GetData(ILevelKey Level);
        IEnumerable<LevelEntity> ListData(IGradeKey filter);
    }
}
