using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.Models.Entity
{
    public interface IPaceTypeKey
    {
        string PaceTypeID { get; set; }
    }
    public class PaceTypeModel : IPaceTypeKey
    {
        public string PaceTypeID { get; set; }
        public string PaceTypeName { get; set; }
    }
}
