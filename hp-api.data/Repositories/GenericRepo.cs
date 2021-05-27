using System.Data;
using hp_api.data.Models;
using Npgsql;
using Dapper;

namespace hp_api.data.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : BaseModel
    {
        // private string _connectionString;
        // private IDbConnection _dbConnection
        // {
        //     get
        //     {
        //         Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        //         return new NpgsqlConnection(_connectionString);
        //     }
        // }
        //
        // public GenericRepo(IConfiguration configuration)
        // {
        //     _connectionString = configuration.GetValue<string>("DbConnString");
        // }
    }
}