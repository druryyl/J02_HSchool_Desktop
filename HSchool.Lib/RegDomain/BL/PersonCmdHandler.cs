using FluentValidation;
using HSchool.Lib.RegDomain.BL.Factory;
using HSchool.Lib.RegDomain.Dal;
using HSchool.Lib.RegDomain.Models;
using HSchool.Lib.RegDomain.Models.Dto;
using HSchool.Lib.RegDomain.Models.Entity;
using MoreLinq;
using Nuna.Lib.AutoNumberHelper;
using Nuna.Lib.ModelingHelper;
using Nuna.Lib.TransactionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.BL
{

    public interface IPersonCommandHandler :
        IPersonContext,
        IPersonCommand,
        IApply<IPersonContext>
    {
    }

    public class PersonCmdHandler : IPersonCommandHandler
    {
        //  CONSTANTA
        private const string PREFIX = "PR";
        private const IDFormatEnum FORMAT_ID = IDFormatEnum.PF_YYM_nnnnnC;


        //  CONSTRUCTOR
        private readonly IPersonFactory _personFactory;
        private readonly IPersonDal _personDal;
        private readonly INunaCounterBL _counter;
        private readonly IValidator<IPersonContext> _validator;
        //  
        public PersonCmdHandler(IPersonFactory personFactory,
            IPersonDal personDal,
            INunaCounterBL counter,
            IValidator<IPersonContext> validator)
        {
            _personFactory = personFactory;
            _personDal = personDal;
            _counter = counter;
            _validator = validator;
        }


        //  CONTEXT
        public PersonModel Person { get; private set; }
        public bool IsDeleted { get; private set; }


        //  APPLY
        private void SetContext(IPersonContext context)
        {
            Person = context.Person;
            IsDeleted = context.IsDeleted;
        }
        public void Apply(IPersonContext context)
        {
            //  SET CONTEXT
            SetContext(context);

            //  VALIDATE
            _validator.ValidateAndThrow(this);

            //  APPLY
            //  -- delete
            if (IsDeleted)
            {
                _personDal.Delete(Person);
                return;
            }
            //  -- insert
            if (Person.PersonID == string.Empty)
            {
                Person.PersonID = _counter.Generate(PREFIX, FORMAT_ID);
                _personDal.Insert(Person);
            }
            //  -- update
            _personDal.Update(Person);
        }

        //  COMMAND
        public void Create(PersonCreateDto person)
        {
            _personFactory.Create(person);
            using (var trans = TransHelper.NewScope())
            {
                Apply(_personFactory);
                trans.Complete();
            }
        }

        public void Update(PersonUpdateDto person)
        {
            _personFactory.Update(person);
            using (var trans = TransHelper.NewScope())
            {
                Apply(_personFactory);
                trans.Complete();
            }
        }

        public void Delete(IPersonKey key)
        {
            _personFactory.Delete(key);
            using (var trans = TransHelper.NewScope())
            {
                Apply(_personFactory);
                trans.Complete();
            }
        }
    }
}
