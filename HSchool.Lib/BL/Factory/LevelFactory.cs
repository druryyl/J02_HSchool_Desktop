using HSchool.Lib.Dal;
using HSchool.Lib.Models;
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
        private readonly AbstractBuilder<LevelEntity, ILevelKey> _levelBuilder;
        private readonly AbstractBuilder<GradeEntity, IGradeKey> _gradeBuilder;
        //  
        public LevelFactory(ILevelDal levelDal,
            IGradeDal gradeDal, 
            AbstractBuilder<LevelEntity, ILevelKey> levelBuilder, 
            AbstractBuilder<GradeEntity, IGradeKey> gradeBuilder)
        {
            _levelDal = levelDal;
            _levelBuilder = levelBuilder;
            _gradeDal = gradeDal;
            _gradeBuilder = gradeBuilder;
        }

        //  CONTEXT
        public LevelEntity Level { get; private set; }
        public GradeEntity Grade { get; private set; }
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
        public LevelEntity GetData(ILevelKey key)
        {
            Level = _levelDal.GetData(key);
            return Level;
        }

        public IEnumerable<LevelEntity> ListData(IGradeKey filter)
        {
            var result = _levelDal.ListData(filter);
            return result;
        }
    }
}
