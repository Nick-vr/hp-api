using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using hp_api.data.Models;
using Npgsql;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace hp_api.data.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : BaseModel
    {
        private string _connectionString;
        private IDbConnection _dbConnection
        {
            get
            {
                DefaultTypeMap.MatchNamesWithUnderscores = true;
                return new NpgsqlConnection(_connectionString);
            }
        }
        
        public GenericRepo(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("HPDBConnectionString");
        }
        
        public async Task<IEnumerable<T>> GetAllAsync(string sql)
        {
            using var dbConnection = _dbConnection;
            return await dbConnection.QueryAsync<T>(sql);
        }
        
        public async Task<T> GetByIdAsync(int id, string sql)
        {
            using var dbConnection = _dbConnection;
            return await dbConnection.QueryFirstOrDefaultAsync<T>(sql, new { id });
        }
    }
}