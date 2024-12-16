using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ConsumindoApiDe3_.Dtos;
using ConsumindoApiDe3_.Models;

namespace ConsumindoApiDe3_.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));

            CreateMap<BancoResponse, BancoModel>().ReverseMap();
        }
    }
}