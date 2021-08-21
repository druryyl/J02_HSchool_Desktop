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

    public interface IPersonFactory : IPersonContext,
        IPersonCommand
    {
    }

    public class PersonFactory : IPersonFactory
    {
        //  CONSTRUCTOR
        private readonly IPersonDal _personDal;
        private readonly AbstractBuilder<PersonEntity, IPersonKey> _personBuilder;
        //  
        public PersonFactory(IPersonDal personDal,
            AbstractBuilder<PersonEntity, IPersonKey> personBuilder)
        {
            _personDal = personDal;
            _personBuilder = personBuilder;
        }

        //  CONTEXT
        public PersonEntity Person { get; private set; }
        public bool IsDeleted { get; private set; }


        //  COMMAND
        public void Create(PersonCreateDto person)
        {
            Person = _personBuilder
                .FromModel(person)
                .Build();
            IsDeleted = false;
        }

        public void Update(PersonUpdateDto person)
        {
            Person = _personBuilder
                .FromDb(_personDal, person)
                .FromModel(person)
                .Build();
            IsDeleted = false;
        }

        public void Delete(IPersonKey key)
        {
            Person = _personBuilder
                .FromDb(_personDal, key)
                .Build();
            IsDeleted = true;
        }
    }

}
