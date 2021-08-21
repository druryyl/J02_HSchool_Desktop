using HSchool.Lib.Dal;
using HSchool.Lib.Models.Dto;
using HSchool.Lib.Models.Entity;
using Nuna.Lib.PatternHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL.Factory
{
    public interface IGradeFactory : IGradeContext,
        IGradeCommand
    {
    }

    public class GradeFactory : IGradeFactory
    {
        //  CONSTRUCTOR
        private readonly IGradeDal _gradeDal;
        private readonly AbstractBuilder<GradeEntity, IGradeKey> _gradeBuilder;
        //  
        public GradeFactory(IGradeDal gradeDal,
            AbstractBuilder<GradeEntity, IGradeKey> gradeBuilder)
        {
            _gradeDal = gradeDal;
            _gradeBuilder = gradeBuilder;
        }

        //  CONTEXT
        public GradeEntity Grade { get; private set; }
        public bool IsDeleted { get; private set; }


        //  COMMAND
        public void Create(GradeCreateDto grade)
        {
            Grade = _gradeBuilder
                .FromModel(grade)
                .Build();
        }

        public void Update(GradeUpdateDto grade)
        {
            Grade = _gradeBuilder
                .FromDb(_gradeDal, grade)
                .FromModel(grade)
                .Build();
        }

        public void Delete(IGradeKey key)
        {
            Grade = _gradeBuilder
                .FromDb(_gradeDal, key)
                .Build();
            IsDeleted = true;
        }
    }
}
