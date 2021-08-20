using AutoMapper;
using HSchool.Lib.Models.Dto;
using HSchool.Lib.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL.Mapper
{
    public class GradeMap : Profile
    {
        public GradeMap()
        {
            AllowNullDestinationValues = false;

            CreateMap<GradeCreateDto, GradeEntity>();
            CreateMap<GradeUpdateDto, GradeEntity>();
        }
    }
}
