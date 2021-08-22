using HSchool.Lib.RegDomain.Dal;
using HSchool.Lib.RegDomain.Models;
using HSchool.Lib.RegDomain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.BL
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

        public LevelModel GetData(ILevelKey level)
        {
            return _levelDal.GetData(level);
        }

        public IEnumerable<LevelModel> ListData(IGradeKey filter)
        {
            return _levelDal.ListData(filter);
        }
    }
}
