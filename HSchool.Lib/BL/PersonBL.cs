using HSchool.Lib.Dal;
using HSchool.Lib.Models;
using Intersolusi.Helper;
using MoreLinq;
using Nuna.Lib.TransactionHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL
{
    public interface IPersonBL : IPersonContext, IPersonCommand, IPersonQuery
    {
    }
    public class PersonBL //: IPersonBL
    {
        private readonly IPersonDal _personDal;
        //private readonly IParamNoBL _paramNoBL;

        public PersonBL(IPersonDal personDal)
            //IParamNoBL paramNoBL)
        {
            _personDal = personDal;
            //_paramNoBL = paramNoBL;

            Init();
        }


        public void Init()
        {
            //Person = new PersonEntity
            //{
            //    PersonID = string.Empty,
            //    PersonName = string.Empty,
            //    NickName = string.Empty,
            //    BirthDate = new DateTime(1900, 1, 1),
            //    BirthPlace = string.Empty,
            //    Gender = GenderEnum.Male,

            //    FullAddr = string.Empty,
            //    ShortAddr = string.Empty,
            //    City = string.Empty,
            //    PhoneNo = string.Empty,
            //    Email = string.Empty,
            //};
        }

        public PersonEntity Person { get; set; }
        //public IEnumerable<PersonSearchResultDto> SearchResult { get; set; }

        public void GetData(IPersonKey person)
        {
            Person = _personDal.GetData(person);
        }

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
            //return _paramNoBL.GenNewID("PR", ParamNoLengthEnum.Code_12);
            return "";
        }


        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Search(string keyword)
        {
            var listPerson = _personDal.ListData();
            if (listPerson is null)
            {
                //SearchResult = new List<PersonSearchResultDto>();
                return;
            }

            keyword = keyword.ToLower();

            //  search name
            var listByName = listPerson
                .Where(x => x.PersonName.ToLower().Contains(keyword));
            var listByNick = listPerson
                .Where(x => x.NickName.ToLower().Contains(keyword));

            //  search tgl lahir full
            IEnumerable<PersonEntity> listByTglLahir = null;
            //if (keyword.IsValidTgl("dd-MM-yyyy"))
            //{
            //    var keywordDT = keyword.ToDate();
            //    listByTglLahir = listPerson
            //        .Where(x => x.BirthDate.Date == keywordDT.Date);
            //}

            var resultAll = new List<PersonEntity>();
            if (listByName.Any())
                resultAll.AddRange(listByName);

            if (listByNick.Any())
                resultAll.AddRange(listByNick);

            if (listByTglLahir != null)
                if (listByTglLahir.Any())
                    resultAll.AddRange(listByTglLahir);

            var resultDistinct = resultAll
                .DistinctBy(x => x.PersonID);

            //if (resultDistinct.Any())
                //SearchResult = resultDistinct
                //    .Select(r => new PersonSearchResultDto
                //    {
                //        PersonID = r.PersonID,
                //        PersonName = r.PersonName,
                //        LastUpdate = r.StmpUpd
                //    })
                //    .OrderByDescending(x => x.LastUpdate)
                //    .Take(50);
            //else
                //SearchResult = new List<PersonSearchResultDto>();
        }
    }
}
