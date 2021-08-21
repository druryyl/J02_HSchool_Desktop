using HSchool.Lib.Models;
using HSchool.Lib.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Models.Dto
{
    public class PersonCreateDto
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
    }
}
