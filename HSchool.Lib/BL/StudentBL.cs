using HSchool.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL
{
    public interface IStudentBL
    {
        StudentModel Student { get;}

        //  pendaftaran
        void Apply(PersonModel person); 
        //  penerimaan
        void Register(PersonModel person);
        void Graduate();
        void LevelUp();
    }

    public class StudentBL : IStudentBL
    {
        public StudentModel Student { get; internal set; }

        public void Apply(PersonModel person)
        {
            throw new NotImplementedException();
        }

        public void Register(PersonModel person)
        {
            throw new NotImplementedException();
        }
        public void LevelUp()
        {
            throw new NotImplementedException();
        }

        public void Graduate()
        {
            throw new NotImplementedException();
        }

    }
}
