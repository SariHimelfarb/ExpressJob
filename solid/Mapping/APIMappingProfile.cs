using AutoMapper;
using solid.Core.Models;
using solid.Models;
using System.Data;

namespace solid.Mapping
{
    public class APIMappingProfile:Profile
    {
        public APIMappingProfile()
        {
            CreateMap<InterviewPostModel, Interview>();
            CreateMap<JobPostModel, Job>();
            CreateMap<UserPostModel, User>();
        }
    }
}
