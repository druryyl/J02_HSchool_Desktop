using HSchool.Lib.RegDomain.Models.Dto;
using HSchool.Lib.RegDomain.Models.Entity;
using HSchool.Lib.RegDomain.Dal;
using Nuna.Lib.PatternHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HSchool.Lib.RegDomain.Models;

namespace HSchool.Lib.RegDomain.BL.Factory
{
    public interface IGradeFactory : IGradeContext,
        IGradeCommand
    {
    }

    public class GradeFactory : IGradeFactory
    {
        //  CONSTRUCTOR
        private readonly IGradeDal _gradeDal;
        private readonly AbstractBuilder<GradeModel, IGradeKey> _gradeBuilder;
        //  
        public GradeFactory(IGradeDal gradeDal,
            AbstractBuilder<GradeModel, IGradeKey> gradeBuilder)
        {
            _gradeDal = gradeDal;
            _gradeBuilder = gradeBuilder;
        }

        //  CONTEXT
        public GradeModel Grade { get; private set; }
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
