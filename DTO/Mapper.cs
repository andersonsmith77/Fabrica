using System;
using AutoSystem.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace AutosSystem.DTO
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<AutoDTO, Auto>();
            CreateMap<Auto, AutoDTO>();

        }
    }
}
