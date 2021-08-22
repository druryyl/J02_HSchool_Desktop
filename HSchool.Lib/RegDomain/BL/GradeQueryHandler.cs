using HSchool.Lib.RegDomain.Models.Entity;
using HSchool.Lib.RegDomain.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSchool.Lib.RegDomain.Models;

namespace HSchool.Lib.RegDomain.BL
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

        public GradeModel GetData(IGradeKey grade)
        {
            return _gradeDal.GetData(grade);
        }

        public IEnumerable<GradeModel> ListData()
        {
            return _gradeDal.ListData();
        }
    }
}
