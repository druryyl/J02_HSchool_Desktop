using HSchool.Lib.Dal;
using HSchool.Lib.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL
{
    public interface IGradeQueryHandler :
        IGradeQuery
    {
    }

    public class GradeQueryHandler : IGradeQueryHandler
    {
        private readonly IGradeDal _gradeDal;

        public GradeQueryHandler(IGradeDal gradeDal)
        {
            _gradeDal = gradeDal;
        }

        public GradeEntity GetData(IGradeKey grade)
        {
            return _gradeDal.GetData(grade);
        }

        public IEnumerable<GradeEntity> ListData()
        {
            return _gradeDal.ListData();
        }
    }
}
