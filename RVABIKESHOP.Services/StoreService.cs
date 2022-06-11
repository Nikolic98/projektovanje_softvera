using AutoMapper;
using ESCOOTERRENT.Data;
using ESCOOTERRENT.Models;
using ESCOOTERRENT.Repositories;

namespace ESCOOTERRENT.Services
{
    public interface IStoreService
    {
        List<StoreModel> ReadAll();
        StoreModel ReadOne(int id);
        int? Create(StoreModel store);
        void Update(StoreModel store);
    }

    public class StoreService : IStoreService
    {
        private readonly IStoreRepository storeRepository;
        private readonly IMapper mapper;

        public StoreService(IStoreRepository storeRepository, IMapper mapper)
        {
            this.storeRepository = storeRepository;
            this.mapper = mapper;
        }

        public List<StoreModel> ReadAll()
        {
            var resultFromDb = storeRepository.ReadAll();
            var resultModels = mapper.Map<List<StoreModel>>(resultFromDb);
            return resultModels;
        }

        public StoreModel ReadOne(int id)
        {
            var resultFromDb = storeRepository.ReadOne(id);
            var resultModels = mapper.Map<StoreModel>(resultFromDb);
            return resultModels;
        }

        public int? Create(StoreModel store)
        {
            return storeRepository.Create(mapper.Map<Store>(store));
        }

        public void Update(StoreModel store)
        {
            storeRepository.Update(mapper.Map<Store>(store));
        }
    }
}