using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CompanyEntity> Companies { get; set; }
        public DbSet<OwnerEntity> Owners { get; set; }
        public DbSet<TrademarkEntity> Trademarks { get; set; }
        public DbSet<CompanyTypeEntity> CompanyTypes { get; set; }
    }
}
