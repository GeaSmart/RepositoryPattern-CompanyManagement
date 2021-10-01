using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ICompanyRepository : IRepositoryBase<CompanyEntity>
    {
        Task<IEnumerable<CompanyEntity>> GetAllAsync();
        Task<CompanyEntity> GetAsync(int id);
    }
}
