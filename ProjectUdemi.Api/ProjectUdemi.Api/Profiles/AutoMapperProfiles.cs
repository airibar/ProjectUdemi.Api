using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectUdemi.Api.DomainModels;
using  DataModel = ProjectUdemi.Api.DataModels;

namespace ProjectUdemi.Api.Profiles
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModel.Student, Student>().ReverseMap();
            CreateMap<DataModel.Gender, Gender>().ReverseMap();
            CreateMap<DataModel.Address, Address>().ReverseMap();


        }
    }
}
