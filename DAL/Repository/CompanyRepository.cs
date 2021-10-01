using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CompanyRepository : RepositoryBase<CompanyEntity>, ICompanyRepository
    {
        public CompanyRepository(ApplicationDBContext context): base(context)
        {

        }

        public async Task<IEnumerable<CompanyEntity>> GetAllAsync()
        {
            return await FindAllAsync();
        }

        public async Task<CompanyEntity> GetAsync(int id)
        {
            return await FindAsync(id);
        }
    }
}
