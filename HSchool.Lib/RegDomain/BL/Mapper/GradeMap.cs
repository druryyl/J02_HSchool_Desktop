using AutoMapper;
using HSchool.Lib.RegDomain.Models.Dto;
using HSchool.Lib.RegDomain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.RegDomain.BL.Mapper
{
    public class GradeMap : Profile
    {
        public GradeMap()
        {
            AllowNullDestinationValues = false;

            CreateMap<GradeCreateDto, GradeModel>();
            CreateMap<GradeUpdateDto, GradeModel>();
        }
    }
}
