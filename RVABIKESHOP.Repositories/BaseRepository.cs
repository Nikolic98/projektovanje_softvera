using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using ESCOOTERRENT.Data;

namespace ESCOOTERRENT.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : Base
    {
        List<TEntity> ReadAll();
        TEntity ReadOne(int id);
        int? Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Base
    {
        private IConfiguration configuration;
        public string connectionString;
        private MySqlConnection connection;

        public BaseRepository(IConfiguration configuration)
        {
            // https://dotnetcoretutorials.com/2020/07/11/dapper-with-mysql-postgresql-on-net-core/
            // https://github.com/ericdc1/Dapper.SimpleCRUD
            // https://www.creative-tim.com/product/material-dashboard#
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
            connection = new MySqlConnection(connectionString);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }

        public List<TEntity> ReadAll()
        {
            var results = connection.GetList<TEntity>().ToList();
            return results;
        }

        public TEntity ReadOne(int id)
        {
            var results = connection.Get<TEntity>(id);
            return results;
        }

        public int? Create(TEntity entity)
        {
            var results = connection.Insert(entity);
            return results;
        }

        public void Update(TEntity entity)
        {
            connection.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            connection.Delete(entity);
        }
    }
}