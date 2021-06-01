using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using hp_api.data.Models;
using hp_api.data.Schemas;
using Microsoft.Extensions.Configuration;

namespace hp_api.data.Repositories
{
    public class UserRepo : GenericRepo<User>, IUserRepo
    {
        public UserRepo(IDbConnection connection)
            : base(connection)
        {
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var sql = $"SELECT * FROM {UserSchema.Table}";
            return await GetAllAsync(sql);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var sql = $"SELECT * FROM {UserSchema.Table} WHERE {UserSchema.Columns.Id} = @{nameof(id)}";
            return await GetByIdAsync(id, sql);
        }
    }
}