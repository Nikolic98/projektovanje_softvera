using AutoMapper;
using ESCOOTERRENT.Data;
using ESCOOTERRENT.Models;
using ESCOOTERRENT.Repositories;

namespace ESCOOTERRENT.Services
{
    public interface IScooterService
    {
        List<ScooterModel> ReadAll();
        ScooterModel ReadOne(int id);
        int? Create(ScooterModel scooter);
        void Update(ScooterModel scooter);
        void Delete(ScooterModel scooter);
    }
    public class ScooterService : IScooterService
    {
        private readonly IScooterRepository scooterRepository;
        private readonly IMapper mapper;

        public ScooterService(IScooterRepository scooterRepository, IMapper mapper)
        {
            this.scooterRepository = scooterRepository;
            this.mapper = mapper;
        }

        public List<ScooterModel> ReadAll()
        {
            var resultFromDb = scooterRepository.ReadAll();
            var resultModels = mapper.Map<List<ScooterModel>>(resultFromDb);
            return resultModels;
        }

        public ScooterModel ReadOne(int id)
        {
            var resultFromDb = scooterRepository.ReadOne(id);
            var resultModels = mapper.Map<ScooterModel>(resultFromDb);
            return resultModels;
        }

        public int? Create(ScooterModel scooter)
        {
            return scooterRepository.Create(mapper.Map<Scooter>(scooter));
        }

        public void Delete(ScooterModel scooter)
        {
            scooterRepository.Delete(mapper.Map<Scooter>(scooter));
        }

        public void Update(ScooterModel scooter)
        {
            scooterRepository.Update(mapper.Map<Scooter>(scooter));
        }
    }
}