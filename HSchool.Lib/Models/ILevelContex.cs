using HSchool.Lib.Models.Entity;
using Nuna.Lib.ModelingHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Models
{

    public interface ILevelContext
    {
        LevelEntity Level { get; }
    }
    public interface ILevelCommand
    {
        //void Create(LevelCreateDto level);
        //void Update(LevelUpdateDto level);
        void Delete(ILevelKey key);
    }

    public interface ILevelQuery
    {
        LevelEntity GetData(ILevelKey key);
        IEnumerable<LevelEntity> ListData();
    }
}
