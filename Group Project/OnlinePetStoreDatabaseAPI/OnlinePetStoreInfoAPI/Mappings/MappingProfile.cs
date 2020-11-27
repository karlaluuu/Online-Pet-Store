using AutoMapper;
using OnlinePetStoreInfoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePetStoreInfoAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PetStoreModel, PetStoreModel>();
        }
    }
}
