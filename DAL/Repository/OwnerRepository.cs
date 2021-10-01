using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class OwnerRepository : RepositoryBase<OwnerEntity>, IOwnerRepository
    {
        public OwnerRepository(ApplicationDBContext context) : base(context)
        {

        }

        public async Task<IEnumerable<OwnerEntity>> GetAllAsync()
        {
            return await FindAllAsync();
        }

        public async Task<OwnerEntity> GetAsync(int id)
        {
            return await FindAsync(id);
        }
    }
}
