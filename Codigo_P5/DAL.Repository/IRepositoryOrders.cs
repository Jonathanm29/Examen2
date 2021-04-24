using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DO.Objects;

namespace DAL.Repository
{
    public interface IRepositoryOrders : IRepository<Orders>
    {
        Task<IEnumerable<Orders>> GetAllWithAsync();
        Task<Orders> GetOneByIdWithAsync(int id);
    }
}
