using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class CompanyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string BankAccount { get; set; }
        public int OwnerId { get; set; }
        public int CompanyTypeId { get; set; }
    }
}
