using HSchool.Lib.Dal;
using HSchool.Lib.Dto;
using HSchool.Lib.Models;
using Intersolusi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL
{
    public interface IPersonBL
    {
        PersonModel Person { get; set; }
        IEnumerable<PersonSearchResultDto> SearchResult { get; set; }
        void Save();
        void Remove();



    }
    public class PersonBL : IPersonBL
    {
        private readonly IPersonDal _personDal;
        private readonly IParamNoBL _paramNoBL;

        public PersonBL(IPersonDal personDal, IParamNoBL paramNoBL)
        {
            _personDal = personDal;
            _paramNoBL = paramNoBL;

            Init();
        }


        public void Init()
        {
            Person = new PersonModel
            {
                PersonID = string.Empty,
                PersonName = string.Empty,
                NickName = string.Empty,
                BirthDate = new DateTime(1900,1,1),
                BirthPlace = string.Empty,
                Gender = GenderEnum.Male,

                FullAddr = string.Empty,
                ShortAddr = string.Empty,
                City = string.Empty,
                PhoneNo = string.Empty,
                Email = string.Empty,
            };
        }

        public PersonModel Person { get; set; }
        public IEnumerable<PersonSearchResultDto> SearchResult { get; set; }


        public void Save()
        {
            if (Person is null)
                throw new ArgumentException("Data empty");

            if (Person.PersonName.Length == 0)
                throw new ArgumentException("Person Name empty");

            if (Person.PersonName.Length == 0)
                throw new ArgumentException("Person Name empty");

            using (var trans = TransHelper.NewScope())
            {
                if (Person.PersonID.Length == 0)
                {
                    Person.PersonID = GenNewID();
                    _personDal.Insert(Person);
                }
                else
                    _personDal.Update(Person);
                trans.Complete();
            }
        }

        private string GenNewID() 
        {
            return _paramNoBL.GenNewID("PR", ParamNoLengthEnum.Code_12);
        }


        public void Remove()
        {
            throw new NotImplementedException();
        }

    }
}
