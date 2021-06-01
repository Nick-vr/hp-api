using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using hp_api.data.Models;
using Dapper;

namespace hp_api.data.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : BaseModel
    {
        private readonly IDbConnection _dbConnection;
        public GenericRepo(IDbConnection connection)
        {
            _dbConnection = connection;
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