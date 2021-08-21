using FluentValidation;
using HSchool.Lib.BL.Factory;
using HSchool.Lib.Dal;
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
    public interface IGradeCommandHandler : 
        IGradeContext,
        IGradeCommand,
        IApply<IGradeContext>
    {
    }

    public class GradeCmdHandler : IGradeCommandHandler
    {
        //  CONSTANTA
        private const string PREFIX = "G";
        private const IDFormatEnum FORMAT_ID = IDFormatEnum.Pnn;


        //  CONSTRUCTOR
        private readonly IGradeFactory _gradeFactory;
        private readonly IGradeDal _gradeDal;
        private readonly INunaCounterBL _counter;
        private readonly IValidator<IGradeContext> _validator;
        //  
        public GradeCmdHandler(IGradeFactory gradeFactory,
            IGradeDal gradeDal,
            INunaCounterBL counter,
            IValidator<IGradeContext> validator)
        {
            _gradeFactory = gradeFactory;
            _gradeDal = gradeDal;
            _counter = counter;
            _validator = validator;
        }


        //  CONTEXT
        public GradeEntity Grade { get; private set; }
        public bool IsDeleted { get; private set; }


        //  APPLY
        private void SetContext(IGradeContext context)
        {
            Grade = context.Grade;
            IsDeleted = context.IsDeleted;
        }
        public void Apply(IGradeContext context)
        {
            //  SET CONTEXT
            SetContext(context);

            //  VALIDATE
            _validator.ValidateAndThrow(this);

            //  APPLY
            //  -- delete
            if (IsDeleted)
            {
                _gradeDal.Delete(Grade);
                return;
            }
            //  -- insert
            if (Grade.GradeID == string.Empty)
            {
                Grade.GradeID = _counter.Generate(PREFIX, FORMAT_ID);
                _gradeDal.Insert(Grade);
            }
            //  -- update
            _gradeDal.Update(Grade);
        }

        //  COMMAND
        public void Create(GradeCreateDto grade)
        {
            _gradeFactory.Create(grade);
            using (var trans = TransHelper.NewScope())
            {
                Apply(_gradeFactory);
                trans.Complete();
            }
        }

        public void Update(GradeUpdateDto grade)
        {
            _gradeFactory.Update(grade);
            using (var trans = TransHelper.NewScope())
            {
                Apply(_gradeFactory);
                trans.Complete();
            }
        }

        public void Delete(IGradeKey key)
        {
            _gradeFactory.Delete(key);
            using (var trans = TransHelper.NewScope())
            {
                Apply(_gradeFactory);
                trans.Complete();
            }
        }
    }
}
