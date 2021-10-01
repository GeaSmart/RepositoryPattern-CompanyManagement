using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ITrademarkRepository : IRepositoryBase<TrademarkEntity>
    {
        Task<IEnumerable<TrademarkEntity>> GetAllAsync();
        Task<TrademarkEntity> GetAsync(int id);
    }
}
