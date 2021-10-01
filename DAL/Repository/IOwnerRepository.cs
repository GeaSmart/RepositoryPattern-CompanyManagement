using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IOwnerRepository : IRepositoryBase<OwnerEntity>
    {
        Task<IEnumerable<OwnerEntity>> GetAllAsync();
        Task<OwnerEntity> GetAsync(int id);
    }
}
