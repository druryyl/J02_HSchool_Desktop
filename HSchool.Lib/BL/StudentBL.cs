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
        void Apply(PersonEntity person); 
        //  penerimaan
        void Register(PersonEntity person);
        void Graduate();
        void LevelUp();
    }

    public class StudentBL : IStudentBL
    {
        public StudentModel Student { get; internal set; }

        public void Apply(PersonEntity person)
        {
            throw new NotImplementedException();
        }

        public void Register(PersonEntity person)
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
