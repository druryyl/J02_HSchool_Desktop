using AutoMapper;
using HSchool.Lib.RegDomain.Models.Entity;
using Nuna.Lib.PatternHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.BL.Builder
{
    public class PersonBuilder : AbstractBuilder<PersonModel, IPersonKey>
    {
        public PersonBuilder(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
