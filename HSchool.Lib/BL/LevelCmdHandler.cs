using FluentValidation;
using HSchool.Lib.BL.Factory;
using HSchool.Lib.Dal;
using HSchool.Lib.Models;
using HSchool.Lib.Models.Dto;
using HSchool.Lib.Models.Entity;
using Nuna.Lib.AutoNumberHelper;
using Nuna.Lib.ModelingHelper;
using Nuna.Lib.TransactionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL
{
    public interface ILevelCommandHandler :
        ILevelContext,
        ILevelCommand,
        IApply<ILevelContext>
    {
    }

    public class LevelCmdHandler : ILevelCommandHandler
    {
        //  CONSTANTA
        private const string PREFIX = "L";
        private const IDFormatEnum FORMAT_ID = IDFormatEnum.Pnn;


        //  CONSTRUCTOR
        private readonly ILevelFactory _levelFactory;
        private readonly ILevelDal _levelDal;
        private readonly INunaCounterBL _counter;
        private readonly IValidator<ILevelContext> _validator;
        //  
        public LevelCmdHandler(ILevelFactory levelFactory,
            ILevelDal levelDal,
            INunaCounterBL counter,
            IValidator<ILevelContext> validator)
        {
            _levelFactory = levelFactory;
            _levelDal = levelDal;
            _counter = counter;
            _validator = validator;
        }


        //  CONTEXT
        public LevelEntity Level { get; private set; }
        public GradeEntity Grade { get; private set; }
        public bool IsDeleted { get; private set; }


        //  APPLY
        private void SetContext(ILevelContext context)
        {
            Level = context.Level;
            Grade = context.Grade;
            IsDeleted = context.IsDeleted;
        }
        public void Apply(ILevelContext context)
        {
            //  SET CONTEXT
            SetContext(context);

            //  VALIDATE
            _validator.ValidateAndThrow(this);

            //  APPLY
            //  -- delete
            if (IsDeleted)
            {
                _levelDal.Delete(Level);
                return;
            }
            //  -- insert
            if (Level.LevelID == string.Empty)
            {
                Level.LevelID = _counter.Generate(PREFIX, FORMAT_ID);
                _levelDal.Insert(Level);
            }
            //  -- update
            _levelDal.Update(Level);
        }

        //  COMMAND
        public void Create(LevelCreateDto level)
        {
            _levelFactory.Create(level);
            using (var trans = TransHelper.NewScope())
            {
                Apply(_levelFactory);
                trans.Complete();
            }
        }

        public void Update(LevelUpdateDto level)
        {
            _levelFactory.Update(level);
            using (var trans = TransHelper.NewScope())
            {
                Apply(_levelFactory);
                trans.Complete();
            }
        }

        public void Delete(ILevelKey key)
        {
            _levelFactory.Delete(key);
            using (var trans = TransHelper.NewScope())
            {
                Apply(_levelFactory);
                trans.Complete();
            }
        }

    }
}
