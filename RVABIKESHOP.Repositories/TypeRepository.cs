using Microsoft.Extensions.Configuration;
using Type = ESCOOTERRENT.Data.Type;

namespace ESCOOTERRENT.Repositories
{

    public interface ITypeRepository : IBaseRepository<Type>
    {

    }
    public class TypeRepository : BaseRepository<Type>, ITypeRepository
    {
        public TypeRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}