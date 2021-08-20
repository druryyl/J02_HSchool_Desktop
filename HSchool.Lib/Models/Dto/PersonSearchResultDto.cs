using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.Models.Dto
{
    public class PersonSearchResultDto
    {
        public string PersonID { get; set; }
        public string PersonName { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
