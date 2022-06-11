using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using ESCOOTERRENT.Data;

namespace ESCOOTERRENT.Repositories
{
    public interface IScooterRepository : IBaseRepository<Scooter>
    {
    }
    public class ScooterRepository : BaseRepository<Scooter>, IScooterRepository
    {
        public ScooterRepository(IConfiguration configuration) : base(configuration)
        {   
        }
    
    }
}