using HSchool.Lib.RegDomain.Dal;
using HSchool.Lib.RegDomain.Models;
using HSchool.Lib.RegDomain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.BL
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

        public PersonModel GetData(IPersonKey person)
        {
            return _personDal.GetData(person);
        }

        public IEnumerable<PersonModel> Search(string personName)
        {
            throw new NotImplementedException();
        }
    }
}
