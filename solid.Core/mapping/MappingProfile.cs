using AutoMapper;
using solid.Core.Dtos;
using solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Core.mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {

            CreateMap<User,UserDto> ().ReverseMap();
            CreateMap<Interview,InterviewDto> ().ReverseMap();
            CreateMap<Job,JobDto> ().ReverseMap();
        }

    }
}
