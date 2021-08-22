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
    public interface IGradeContext : IDeleteFlag
    {
        GradeModel Grade { get; }
    }

    public interface IGradeCommand
    {
        void Create(GradeCreateDto grade);
        void Update(GradeUpdateDto grade);
        void Delete(IGradeKey grade);
    }

    public interface IGradeQuery
    {
        GradeModel GetData(IGradeKey grade);
        IEnumerable<GradeModel> ListData();
    }
}
