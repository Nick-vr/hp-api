using System.Collections.Generic;
using System.Threading.Tasks;
using hp_api.data.Models;
using hp_api.data.Schemas;

namespace hp_api.data.Repositories
{
    public class UserRepo : GenericRepo<User>, IUserRepo
    {
        // public UserRepo(IDbConfig dbConfig)
        //     : base(dbConfig)
        // {
        // }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var sql = $@"SELECT * FROM {UserSchema.Table}";
            return await GetAllAsync(sql);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var sql = $@"SELECT * FROM {UserSchema.Table} WHERE {UserSchema.Columns.Id} = @{nameof(id)}";
            return await GetByIdAsync(id, sql);
        }
    }
}