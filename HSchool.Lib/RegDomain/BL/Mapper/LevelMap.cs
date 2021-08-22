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

    public class LevelMap : Profile
    {
        public LevelMap()
        {
            AllowNullDestinationValues = false;

            CreateMap<LevelCreateDto, LevelModel>();
            CreateMap<LevelUpdateDto, LevelModel>();

            CreateMap<GradeModel, LevelModel>()
                .ForMember(x => x.GradeID, opt => opt.Ignore());
        }
    }
}
