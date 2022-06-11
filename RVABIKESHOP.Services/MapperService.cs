using AutoMapper;
using ESCOOTERRENT.Data;
using ESCOOTERRENT.Models;
using Type = ESCOOTERRENT.Data.Type;

namespace ESCOOTERRENT.Services
{
    public class MapperService : Profile
    {
        public MapperService()
        {
            CreateMap<Scooter, ScooterModel>().ReverseMap();
            CreateMap<Store, StoreModel>().ReverseMap();
            CreateMap<Type, TypeModel>().ReverseMap();
        }
    }
}