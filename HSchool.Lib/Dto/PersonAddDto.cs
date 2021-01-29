using HSchool.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Dto
{
    public class PersonAddDto
    {
        public string PersonName { get; set; }

        public string NickName { get; set; }

        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public GenderEnum Gender { get; set; }

        public string FullAddr { get; set; }
        public string ShortAddr { get; set; }
        public string City { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }

        public static explicit operator PersonAddDto(PersonModel model)
        {
            var result = new PersonAddDto
            {
                PersonName = model.PersonName,
                BirthDate = model.BirthDate,
                BirthPlace = model.BirthPlace,

                FullAddr = model.FullAddr,
                City = model.City,
                PhoneNo = model.PhoneNo,
                Email = model.Email,
            };
            return result;
        }
    }
}
