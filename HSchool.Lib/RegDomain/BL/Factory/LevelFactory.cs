using HSchool.Lib.RegDomain.Dal;
using HSchool.Lib.RegDomain.Models;
using HSchool.Lib.RegDomain.Models.Dto;
using HSchool.Lib.RegDomain.Models.Entity;
using Nuna.Lib.PatternHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.BL.Factory
{
    public interface ILevelFactory : ILevelContext,
        ILevelCommand,
        ILevelQuery
    {
    }

    public class LevelFactory : ILevelFactory
    {
        //  CONSTRUCTOR
        private readonly ILevelDal _levelDal;
        private readonly IGradeDal _gradeDal;
        private readonly AbstractBuilder<LevelModel, ILevelKey> _levelBuilder;
        private readonly AbstractBuilder<GradeModel, IGradeKey> _gradeBuilder;
        //  
        public LevelFactory(ILevelDal levelDal,
            IGradeDal gradeDal, 
            AbstractBuilder<LevelModel, ILevelKey> levelBuilder, 
            AbstractBuilder<GradeModel, IGradeKey> gradeBuilder)
        {
            _levelDal = levelDal;
            _levelBuilder = levelBuilder;
            _gradeDal = gradeDal;
            _gradeBuilder = gradeBuilder;
        }

        //  CONTEXT
        public LevelModel Level { get; private set; }
        public GradeModel Grade { get; private set; }
        public bool IsDeleted { get; private set; }


        //  COMMAND
        public void Create(LevelCreateDto level)
        {
            Grade = _gradeBuilder
                .FromDb(_gradeDal, level)
                .Build();

            Level = _levelBuilder
                .FromModel(level)
                .FromModel(Grade)
                .Build();

            IsDeleted = false;
        }

        public void Update(LevelUpdateDto level)
        {
            Grade = _gradeBuilder
                .FromDb(_gradeDal, level)
                .Build();
            Level = _levelBuilder
                .FromDb(_levelDal, level)
                .FromModel(level)
                .FromModel(Grade)
                .Build();
            IsDeleted = false;
        }

        public void Delete(ILevelKey key)
        {
            Level = _levelBuilder
                .FromDb(_levelDal, key)
                .Build();
            IsDeleted = true;
        }


        //  QUERY
        public LevelModel GetData(ILevelKey key)
        {
            Level = _levelDal.GetData(key);
            return Level;
        }

        public IEnumerable<LevelModel> ListData(IGradeKey filter)
        {
            var result = _levelDal.ListData(filter);
            return result;
        }
    }
}
