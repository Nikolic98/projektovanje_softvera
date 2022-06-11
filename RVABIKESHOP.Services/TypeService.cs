using AutoMapper;
using ESCOOTERRENT.Models;
using ESCOOTERRENT.Repositories;
using Type = ESCOOTERRENT.Data.Type;

namespace ESCOOTERRENT.Services
{
    public interface ITypeService
    {
        List<TypeModel> ReadAll();
        TypeModel ReadOne(int id);
        int? Create(TypeModel store);
        void Update(TypeModel store);
    }

    public class TypeService : ITypeService
    {
        private readonly ITypeRepository typeRepository;
        private readonly IMapper mapper;

        public TypeService(ITypeRepository typeRepository, IMapper mapper)
        {
            this.typeRepository = typeRepository;
            this.mapper = mapper;
        }
        public List<TypeModel> ReadAll()
        {
            var resultFromDb = typeRepository.ReadAll();
            var resultModels = mapper.Map<List<TypeModel>>(resultFromDb);
            return resultModels;
        }

        public TypeModel ReadOne(int id)
        {
            var resultFromDb = typeRepository.ReadOne(id);
            var resultModels = mapper.Map<TypeModel>(resultFromDb);
            return resultModels;
        }

        public int? Create(TypeModel type)
        {
            return typeRepository.Create(mapper.Map<Type>(type));
        }

        public void Update(TypeModel type)
        {
            typeRepository.Update(mapper.Map<Type>(type));
        }
    }
}