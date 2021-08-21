using AutoMapper;
using HSchool.Lib.Models;
using HSchool.Lib.Models.Dto;
using HSchool.Lib.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSchool.Lib.BL.Mapper
{

    public class StudentMap : Profile
    {
        public StudentMap()
        {
            AllowNullDestinationValues = false;

            CreateMap<StudentCreateDto, StudentEntity>();
            CreateMap<StudentUpdateDto, StudentEntity>();

            CreateMap<PersonEntity, StudentEntity>()
                .ForMember(x => x.PersonID, opt => opt.Ignore());
            CreateMap<LevelEntity, StudentEntity>()
                .ForMember(x => x.LevelID, opt => opt.Ignore());
        }
    }
}
