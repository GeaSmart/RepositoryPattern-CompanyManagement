using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CompanyTypeRepository : RepositoryBase<CompanyTypeEntity>, ICompanyTypeRepository
    {
        public CompanyTypeRepository(ApplicationDBContext context) : base(context)
        {

        }

        public async Task<IEnumerable<CompanyTypeEntity>> GetAllAsync()
        {
            return await FindAllAsync();
        }

        public async Task<CompanyTypeEntity> GetAsync(int id)
        {
            return await FindAsync(id);
        }
    }
}
