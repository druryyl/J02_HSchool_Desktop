using AutoMapper;
using HSchool.Lib.Models;
using HSchool.Lib.Models.Entity;
using Nuna.Lib.PatternHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL.Builder
{

    public class StudentBuilder : AbstractBuilder<StudentEntity, IStudentKey>
    {
        public StudentBuilder(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
