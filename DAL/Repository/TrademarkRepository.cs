using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TrademarkRepository : RepositoryBase<TrademarkEntity>, ITrademarkRepository
    {
        public TrademarkRepository(ApplicationDBContext context) : base(context)
        {

        }
        public async Task<IEnumerable<TrademarkEntity>> GetAllAsync()
        {
            return await FindAllAsync();
        }

        public async Task<TrademarkEntity> GetAsync(int id)
        {
            return await FindAsync(id);
        }
    }
}
