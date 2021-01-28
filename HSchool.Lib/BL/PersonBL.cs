using HSchool.Lib.Dto;
using HSchool.Lib.Models;
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

        PersonModel Add(PersonAddDto person);
        PersonModel Update(PersonModel person);
        void Delete(IPersonKey person);

    }
    public class PersonBL : IPersonBL
    {
        public PersonModel Person { get; set; }

        public PersonModel Add(PersonAddDto person)
        {
            throw new NotImplementedException();
        }

        public PersonModel Update(PersonModel person)
        {
            throw new NotImplementedException();
        }

        public void Delete(IPersonKey person)
        {
            throw new NotImplementedException();
        }
    }
}
