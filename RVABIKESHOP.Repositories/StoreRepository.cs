using Microsoft.Extensions.Configuration;
using ESCOOTERRENT.Data;

namespace ESCOOTERRENT.Repositories
{
    public interface IStoreRepository : IBaseRepository<Store>
    {

    }
    public class StoreRepository : BaseRepository<Store>, IStoreRepository
    {
        public StoreRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}