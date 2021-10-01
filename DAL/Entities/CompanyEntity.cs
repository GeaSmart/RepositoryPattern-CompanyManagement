using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class CompanyEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string BankAccount { get; set; }

        //FK
        public int OwnerId { get; set; }
        public int CompanyTypeId { get; set; }

        //Navigation properties
        public List<TrademarkEntity> Trademarks { get; set; }
        public OwnerEntity Owner { get; set; }
        public CompanyTypeEntity CompanyType { get; set; }

        
    }
}
