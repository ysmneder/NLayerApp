using System;
using AutoMapper;
using App.Core.Models;
using App.Core.Dtos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<DeliveryPoint, DeliveryPointDto>().ReverseMap();
            CreateMap<Bag, BagDto>().ReverseMap();
            CreateMap<Package, PackageDto>().ReverseMap();
            CreateMap<Vehicle, VehicleDto>().ReverseMap();
        }



    }
}

