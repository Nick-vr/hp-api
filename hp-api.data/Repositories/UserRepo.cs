namespace hp_api.data.Repositories
{
    public class UserRepo
    {
        public UserRepo()
        {
            
            // public async Task<IEnumerable<User>> FindAllAsync()
            // {
            //     var sql = $@"SELECT * FROM {UserSchema.Table}";
            //     using var dbConnection = _dbConnection;
            //     return await dbConnection.QueryAsync<User>(sql);
            // }
            //
            // public async Task<User> FindByIdAsync(int id)
            // {
            //     var sql = $@"SELECT * FROM {UserSchema.Table} WHERE {UserSchema.Columns.Id} = @{nameof(id)}";
            //     using var dbConnection = _dbConnection;
            //     return await dbConnection.QueryFirstOrDefaultAsync<User>(sql, new { id });
            // }
            //
            // public async Task<User> FindByUserNameAsync(string username)
            // {
            //     var sql = $@"SELECT * FROM  {UserSchema.Table} WHERE {UserSchema.Columns.UserName} = @{nameof(username)}";
            //     using var dbConnection = _dbConnection;
            //     return await dbConnection.QuerySingleOrDefaultAsync<User>(sql, new { username });
            // }
        }
    }
}