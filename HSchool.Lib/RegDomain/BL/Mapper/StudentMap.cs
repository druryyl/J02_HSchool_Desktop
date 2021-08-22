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

    public class StudentMap : Profile
    {
        public StudentMap()
        {
            AllowNullDestinationValues = false;

            CreateMap<StudentCreateDto, StudentModel>();
            CreateMap<StudentUpdateDto, StudentModel>();

            CreateMap<PersonModel, StudentModel>()
                .ForMember(x => x.PersonID, opt => opt.Ignore());
            CreateMap<LevelModel, StudentModel>()
                .ForMember(x => x.LevelID, opt => opt.Ignore());
        }
    }
}
