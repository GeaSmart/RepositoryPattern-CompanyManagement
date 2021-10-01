using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class OwnerEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        //propiedades de navegación
        public List<CompanyEntity>  { get; set; }
    }
}
