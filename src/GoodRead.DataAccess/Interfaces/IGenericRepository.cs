using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.DataAccess.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(long id,T entity);
        Task<T> DeleteAsync(long id);
        Task<T> GetAsync(long id);
    }
}
