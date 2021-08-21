using HSchool.Lib.Dal;
using HSchool.Lib.Models;
using HSchool.Lib.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL
{

    public interface ILevelQueryHandler :
        ILevelQuery
    {
    }

    public class LevelQueryHandler : ILevelQueryHandler
    {
        private readonly ILevelDal _levelDal;

        public LevelQueryHandler(ILevelDal levelDal)
        {
            _levelDal = levelDal;
        }

        public LevelEntity GetData(ILevelKey level)
        {
            return _levelDal.GetData(level);
        }

        public IEnumerable<LevelEntity> ListData(IGradeKey filter)
        {
            return _levelDal.ListData(filter);
        }
    }
}
