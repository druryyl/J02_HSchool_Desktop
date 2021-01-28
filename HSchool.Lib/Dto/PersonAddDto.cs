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

        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }

        public string Address { get; set; }
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

                Address = model.Address,
                City = model.City,
                PhoneNo = model.PhoneNo,
                Email = model.Email,
            };
            return result;
        }
    }
}
