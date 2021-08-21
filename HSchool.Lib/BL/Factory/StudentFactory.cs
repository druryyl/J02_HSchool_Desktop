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

    public interface IStudentFactory : IStudentContext,
        IStudentCommand
    {
    }

    public class StudentFactory : IStudentFactory
    {
        //  CONSTRUCTOR
        private readonly IStudentDal _studentDal;
        private readonly IPersonDal _personDal;
        private readonly ILevelDal _levelDal;

        private readonly AbstractBuilder<StudentEntity, IStudentKey> _studentBuilder;
        private readonly AbstractBuilder<PersonEntity, IPersonKey> _personBuilder;
        private readonly AbstractBuilder<LevelEntity, ILevelKey> _levelBuilder;
        //  
        public StudentFactory(IStudentDal studentDal,
            IPersonDal personDal,
            AbstractBuilder<StudentEntity, IStudentKey> studentBuilder,
            AbstractBuilder<PersonEntity, IPersonKey> personBuilder)
        {
            _studentDal = studentDal;
            _studentBuilder = studentBuilder;
            _personDal = personDal;
            _personBuilder = personBuilder;
        }

        //  CONTEXT
        public StudentEntity Student { get; private set; }
        public PersonEntity Person { get; private set; }
        public LevelEntity Level { get; private set; }
        public bool IsDeleted { get; private set; }


        //  COMMAND
        public void Create(StudentCreateDto student)
        {
            Level = _levelBuilder
                .FromDb(_levelDal, student)
                .Build();

            Person = _personBuilder
                .FromDb(_personDal, student)
                .Build();

            Student = _studentBuilder
                .FromModel(student)
                .FromModel(Person)
                .FromModel(Level)
                .Build();

            IsDeleted = false;
        }

        public void Update(StudentUpdateDto student)
        {
            Person = _personBuilder
                .FromDb(_personDal, student)
                .Build();
            
            Level = _levelBuilder
                .FromDb(_levelDal, student)
                .Build();

            Student = _studentBuilder
                .FromDb(_studentDal, student)
                .FromModel(student)
                .FromModel(Person)
                .FromModel(Level)
                .Build();
            IsDeleted = false;
        }

        public void Delete(IStudentKey key)
        {
            Student = _studentBuilder
                .FromDb(_studentDal, key)
                .Build();
            IsDeleted = true;
        }
    }
}
