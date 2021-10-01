using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class CompanyTypeEntity : BaseEntity
    {
        public string Name { get; set; }

        //Navigation properties
        public List<CompanyEntity> Companies { get; set; }
    }
}
