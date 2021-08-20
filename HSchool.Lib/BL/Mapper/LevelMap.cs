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

    public class LevelMap : Profile
    {
        public LevelMap()
        {
            AllowNullDestinationValues = false;

            CreateMap<LevelCreateDto, LevelEntity>();
            CreateMap<LevelUpdateDto, LevelEntity>();

            CreateMap<GradeEntity, LevelEntity>()
                .ForMember(x => x.GradeID, opt => opt.Ignore());
        }
    }
}
