using HSchool.Lib.Models;
using HSchool.Lib.Models.Dto;
using HSchool.Lib.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Models
{

    public interface IStudentContext
    {
        //  ROOT
        StudentEntity Student { get; }
        //  VALUE OBJECT
        PersonEntity Person { get; }
        LevelEntity Level { get; }

    }
    public interface IStudentCommand
    {
        void Create(StudentCreateDto student);
        void Update(StudentUpdateDto student);
        void Delete(IStudentKey student);
    }

    public interface IStudentQuery
    {
        StudentEntity GetData(IStudentKey Student);
        IEnumerable<StudentEntity> ListData();
        IEnumerable<StudentEntity> ListData(IPersonKey filter);
    }
}