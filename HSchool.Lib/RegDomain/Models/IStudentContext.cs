using HSchool.Lib.RegDomain.Models.Dto;
using HSchool.Lib.RegDomain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models
{

    public interface IStudentContext
    {
        //  ROOT
        StudentModel Student { get; }
        //  VALUE OBJECT
        PersonModel Person { get; }
        LevelModel Level { get; }

    }
    public interface IStudentCommand
    {
        void Create(StudentCreateDto student);
        void Update(StudentUpdateDto student);
        void Delete(IStudentKey student);
    }

    public interface IStudentQuery
    {
        StudentModel GetData(IStudentKey Student);
        IEnumerable<StudentModel> ListData();
        IEnumerable<StudentModel> ListData(IPersonKey filter);
    }
}