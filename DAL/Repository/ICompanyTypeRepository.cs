using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ICompanyTypeRepository : IRepositoryBase<CompanyTypeEntity>
    {
        Task<IEnumerable<CompanyTypeEntity>> GetAllAsync();
        Task<CompanyTypeEntity> GetAsync(int id);
    }
}
