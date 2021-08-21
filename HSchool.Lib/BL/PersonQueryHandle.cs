using HSchool.Lib.Dal;
using HSchool.Lib.Models;
using HSchool.Lib.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL
{

    public interface IPersonQueryHandler :
        IPersonQuery
    {
    }

    public class PersonQueryHandler : IPersonQueryHandler
    {
        private readonly IPersonDal _personDal;

        public PersonQueryHandler(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public PersonEntity GetData(IPersonKey person)
        {
            return _personDal.GetData(person);
        }

        public IEnumerable<PersonEntity> Search(string personName)
        {
            throw new NotImplementedException();
        }
    }
}
