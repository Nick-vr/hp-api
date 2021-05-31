using System.Collections.Generic;
using System.Threading.Tasks;
using hp_api.data.Models;

namespace hp_api.data.Repositories
{
    public interface IGenericRepo<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAllAsync(string sql);
        Task<T> GetByIdAsync(int id, string sql);
    }
}