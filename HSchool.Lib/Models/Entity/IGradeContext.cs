using HSchool.Lib.Models.Dto;
using Nuna.Lib.ModelingHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Models.Entity
{
    public interface IGradeContext : IDeleteFlag
    {
        GradeEntity Grade { get; }
    }

    public interface IGradeCommand
    {
        void Create(GradeCreateDto grade);
        void Update(GradeUpdateDto grade);
        void Delete(IGradeKey grade);
    }

    public interface IGradeQuery
    {
        GradeEntity GetData(IGradeKey grade);
        IEnumerable<GradeEntity> ListData();
    }
}
